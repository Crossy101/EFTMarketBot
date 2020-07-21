using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using EFTBot.Data.Classes.API.Old;
using EFTBot.Data.Models.RequestModels.Profile;
using EFTBot.Models.EFT.RequestModels;
using EFTBot.Models.EFT.RequestModels.Profile.ProfileSelect;
using EFTBot.Models.EFT.RequestModels.Trading.Localization;
using EFTBot.Shared.Classes;

namespace EFTBot.Data.Classes
{
    public class ProfileController : BaseController
    {
        private PlayerProfile _profile;
        private readonly Dictionary<string, Location> _itemsToKeep;

        public string SessionCookie = "";

        public ProfileController()
        {
            _itemsToKeep = new Dictionary<string, Location>();
        }

        public void SelectPMCProfile()
        {
            GetLatestPlayerProfile();

            var gameWebRequest = new EFTWebRequest(Log, SessionCookie);
            var selectRequest = new ProfileSelectRequest { uid = _profile.Id };
            var gameRequest = new GameRequest(LinkManager._selectProfileEndPoint, selectRequest);
            var selectResponse = gameWebRequest.EftGameRequest<ProfileSelectResponse>(gameRequest);

            gameRequest.URL = LinkManager._selectLocalizationEndPoint;
            gameRequest.body = new object();

            //TODO: This may be useful for getting all traders possible? As currently I believe we're very specific with what we pick
            var localizationData = gameWebRequest.EftGameRequest<LocalizationData>(gameRequest);
        } 

        public PlayerProfile GetLatestPlayerProfile()
        {
            var gameWebRequest = new EFTWebRequest(Log, SessionCookie);
            var gameRequest = new GameRequest(LinkManager._getProfileListEndPoint, new object());

            PlayerProfile profile = null;
            //Sometimes the web request can return null so we'll do a check to make sure we have actually grabbed our latest profile
            while (profile == null)
            {
                var profResp = gameWebRequest.EftGameRequest<ProfileResponse>(gameRequest);
                if (CanProcess(profResp))
                {
                    profile = profResp.Data.data.FirstOrDefault(info => info.Info.Side != "Savage");
                    break;
                }
            }

            return (_profile = profile);
        }

        /// <summary>
        /// Get a list of items from inventory that are sellable to trader
        /// </summary>
        /// <returns></returns>
        public List<SellablePlayerItem> GetSellableFromInventory()
        {
            var sellableItems = new List<SellablePlayerItem>();

            //Only sells extra copies. We always want to keep a single copy of an item to figure out the selling price.
            //Otherwise we risk selling at a loss. This way we ensure profitability every time we sell (after all items have been bought once)
            var applicableItems = _profile.Inventory.Items.Where(iItem => LinkManager.ItemsToLookFor.ContainsKey(iItem.ItemTypeId)).ToList();
            Log($"{applicableItems.Count} matching items to sell...");
            foreach (var applicableItem in applicableItems)
            {
                if (!applicableItem.Upd.StackObjectsCount.HasValue)
                {
                    continue;
                }

                int itemCount = applicableItem.Upd.StackObjectsCount.Value;

                //Only sell the extra copies. Always keep one instance of the item.
                if (_itemsToKeep.TryGetValue(applicableItem.ItemTypeId, out var trackingItemLoc))
                {
                    if (trackingItemLoc.Equals(applicableItem.Location))
                    {
                        //Only able to sell when quantity is more than one.
                        if (itemCount <= 1)
                        {
                            continue;
                        }

                        //Same item, so sell all but one. So we have a spare to use for price management.
                        sellableItems.Add(new SellablePlayerItem(applicableItem, itemCount - 1));
                    }
                    else
                    {
                        //Different item (Same type - but we can safely sell it)
                        sellableItems.Add(new SellablePlayerItem(applicableItem, itemCount));
                    }
                }
                else
                {
                    //We aren't tracking this item. First time we've had one in the inventory.
                    _itemsToKeep.Add(applicableItem.ItemTypeId, applicableItem.Location);
                    Log($"Now tracking item {applicableItem.ItemTypeId}'s price (Tracking {_itemsToKeep.Count}/{LinkManager.ItemsToLookFor.Count})");

                    if (itemCount > 1)
                    {
                        //Same item, so sell all but one. So we have a spare to use for price management.
                        sellableItems.Add(new SellablePlayerItem(applicableItem, itemCount - 1));
                    }
                }
            }

            return sellableItems;
        }

        /// <summary>
        /// Get the current roubles on profile by calculating all Rouble item IDs
        /// </summary>
        /// <returns></returns>
        public long GetCurrentRoubles()
        {
            return (long)_profile.Inventory.Items.Where(rItem => rItem.ItemTypeId == LinkManager.ROUBLE_CURRENCY_ID).Sum(rItem => rItem.Upd.StackObjectsCount);
        }

        /// <summary>
        /// Gets the price of the item and the current items in the offer and calculates how many items we can buy from that one offer
        /// </summary>
        public int CalculateItemCount(long price, int itemsInOffer)
        {
            //Calculate the items we can buy with our current roubles
            int itemsCanBuy = (int)Math.Floor((float)GetCurrentRoubles() / (float)price);

            if (itemsCanBuy >= itemsInOffer)
                return itemsInOffer;
            else
                return itemsCanBuy;
        }

        /// <summary>
        /// Grab an ID of a Rouble item id that has enough to buy the current item being bought
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetRoublesFromInventory(int price)
        {
            Dictionary<string, int> roublesToReturn = new Dictionary<string, int>();
            while (price > 0)
            {
                PlayerItem roubleItem = _profile.Inventory.Items.FirstOrDefault(item => item.ItemTypeId == LinkManager.ROUBLE_CURRENCY_ID && !roublesToReturn.ContainsKey(item.Id));
                if (roubleItem != null)
                {
                    //If the current price is above what the current roubles StackObjectCount is
                    if (price > roubleItem.Upd.StackObjectsCount)
                    {
                        roublesToReturn.Add(roubleItem.Id, (int)roubleItem.Upd.StackObjectsCount);
                        price -= (int)roubleItem.Upd.StackObjectsCount;

                        _profile.Inventory.Items.First(item => item.Id == roubleItem.Id).Upd.StackObjectsCount -= roubleItem.Upd.StackObjectsCount;
                    }
                    //If we only need a small part of the roubles StackObjectCount
                    else
                    {
                        roublesToReturn.Add(roubleItem.Id, price);
                        price -= price;

                        _profile.Inventory.Items.First(item => item.Id == roubleItem.Id).Upd.StackObjectsCount -= price;
                    }
                }
            }
            return roublesToReturn;
        }

        public class ItemStack
        {
            public string ItemId { get; set; }
            public int Amount { get; set; }
            public List<PlayerItem> Stacks { get; set; }
        }

        public ItemStack GetAllRoubles()
        {
            string itemTypeId = LinkManager.ROUBLE_CURRENCY_ID;
            int amount = 0;
            var roubles = _profile.Inventory.Items.Where(item => item.ItemTypeId == itemTypeId).ToList();
            foreach (var roubleStack in roubles)
            {
                amount += roubleStack.Upd.StackObjectsCount ?? 0;
            }

            return new ItemStack()
            {
                ItemId = itemTypeId,
                Amount = amount,
                Stacks = roubles
            };
        }
    }
}

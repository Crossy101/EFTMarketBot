using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using EFTBot.Data.Classes;
using EFTBot.Data.Classes.API.Old;
using EFTBot.Data.Classes.Database.Managers;
using EFTBot.Data.Models.API;
using EFTBot.Data.Models.RequestModels.Market;
using EFTBot.Data.Models.RequestModels.Profile;
using EFTBot.Data.Models.RequestModels.Trading.Market;
using EFTBot.Models.EFT.Enums;
using EFTBot.Models.EFT.RequestModels;
using EFTBot.Models.EFT.RequestModels.Market;
using EFTBot.Models.EFT.RequestModels.Profile;
using EFTBot.Models.EFT.RequestModels.Trading.Market;
using Newtonsoft.Json;

#nullable enable

namespace EFTBot.Data.Classes
{
    public class MarketController : BaseController
    {
        private readonly ProfileController _profileController;
        private readonly FleaMarketManager _fleaManager;

        public string SessionCookie { private get; set; }
        private const int MINIMUM_PROFIT = 10;

        public MarketController(ProfileController profileCont)
        {
            _profileController = profileCont;
            LinkManager.CurrentItemPrices = new List<CurrentItemPrice>();
            foreach (string itemTypeId in LinkManager.ItemsToLookFor.Keys)
            {
                var newItemPrice = new CurrentItemPrice
                {
                    Id = itemTypeId,
                    Price = 0
                };
                LinkManager.CurrentItemPrices.Add(newItemPrice);
            }
        }

        private void AddPurchaseOffer(List<BuyOfferPurchase> allOffers, Offer offer, string itemName, long expectedProfit = 0)
        {
            Dictionary<string, int> roublesToSwap = _profileController.GetRoublesFromInventory((int)offer.requirementsCost);
            if (roublesToSwap.Count <= 0)
            {
                Log($"We're unable to buy {itemName}! We are poor :(");
                return;
            }

            //var itemsToSwap = CalculateRoubles(offer.items.Count, roubles, offer);
            Log($"We're able to buy {itemName}!");
            if (roublesToSwap.Count >= 1)
            {
                var itemsToSwap = roublesToSwap.Select(r => new ItemToSwap()
                {
                    id = r.Key,
                    count = r.Value
                }).ToList();

                //var itemsToSwap = CalculateRoubles(offer.items.Count, roubles, offer);
                Log($"We're able to buy {itemName}!");
                var purchaseOffer = new BuyOfferPurchase(offer._id, 1, itemsToSwap)
                {
                    Offer = offer,
                    ExpectedProfit = expectedProfit,
                    TotalIndividualItems = offer.items.Count
                };
                allOffers.Add(purchaseOffer);
            }
            else
            {
                Log($"Unable to find any offers that will make us profit for item {itemName}");
                Thread.Sleep(LinkManager.Timer);
            }
        }

        private void SearchForFirstItemOfType(List<BuyOfferPurchase> allPurchasingOffers, CurrentItemPrice currentPrice, string itemName)
        {
            var newSearchRequest = new SearchRequest(currentPrice.Id);
            var gameRequest = new GameRequest(LinkManager._searchMarketEndPoint, newSearchRequest);
            var gameWebRequest = new EFTWebRequest(Log, SessionCookie);

            Offer? offer = null;
            while (offer == null)
            {
                try
                {
                    var searchResp = gameWebRequest.EftGameRequest<SearchResponse>(gameRequest);
                    if (searchResp.Error != null)
                    {
                        Log(
                            $"Unable to process search request. Error: {searchResp.Error.ErrorMessage}. Data: {searchResp.Error.Data}");
                        break;
                    }

                    offer = searchResp.Data.data.offers?.OrderBy(o => o.requirementsCost).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Log(ex.ToString());
                }

                if (offer == null)
                {
                    Thread.Sleep(500);
                }
            }

            Log($"Found offer - costs {offer.requirementsCost} to buy {itemName} (can be sold for {currentPrice.Price})");
            AddPurchaseOffer(allPurchasingOffers, offer, itemName, 0);
        }

        private void SearchForMultipleOfExistingType(List<BuyOfferPurchase> allPurchasingOffers, CurrentItemPrice currentPrice, string itemName)
        {
            var newSearchRequest = new SearchRequest(currentPrice.Id);
            var gameRequest = new GameRequest(LinkManager._searchMarketEndPoint, newSearchRequest);
            var gameWebRequest = new EFTWebRequest(Log, SessionCookie);

            SearchResponse? data = null;
            while (data == null)
            {
                var searchResp = gameWebRequest.EftGameRequest<SearchResponse>(gameRequest);
                if (!CanProcess(searchResp))
                {
                    break;
                }

                if (searchResp.Data?.data != null)
                {
                    data = searchResp.Data;
                }

                if (data == null)
                {
                    Thread.Sleep(LinkManager.Timer);
                }
            }

            //Get all offers, cheapest first. Gotta save those dollar bills yo
            //Ensure they only require roubles and no other items in order to buy.
            var allOffers = data.data.offers.OrderBy(o => o.requirementsCost)
                .Where(offer => currentPrice.Price > offer.requirementsCost)
                .Take(5)
                .ToList();

            if (allOffers.Count <= 0)
            {
                Log($"Unable to find any offers that will make us profit for item {itemName}");
                //Thread.Sleep(LinkManager.Timer);
                return;
            }

            foreach (var offer in allOffers)
            {
                var itemProfit = currentPrice.Price - offer.requirementsCost;

                if (itemProfit <= 0)
                {
                    continue;
                }

                //TODO: Why is offer.items[0].id null???? Compare with working API... Majority of our buy requests are failing qq
                //TODO: Compare our buying with our selling properly in code to see where we're going wrong.
                Log($"Found offer - costs {offer.requirementsCost} to buy {itemName} (can be sold for {currentPrice.Price} - {itemProfit} profit)");
                AddPurchaseOffer(allPurchasingOffers, offer, itemName, itemProfit);
            }
        }


        public IEnumerable<List<BuyOfferPurchase>> GetBuyableItems(PlayerProfile profile)
        {
            //TODO: This method is fucking huge. Could do with some loving.
            //Could possibly merge into a smaller method if we figure out a way to find item prices more effectively

            Log($"Attempting to buy items...");

            UpdateItemPrices(profile);

            var applicablePrices = LinkManager.CurrentItemPrices.Where(ip => LinkManager.ItemsToLookFor.ContainsKey(ip.Id)).ToList();
            foreach (var itemLookingFor in applicablePrices)
            {
                string itemName = LinkManager.ItemsToLookFor[itemLookingFor.Id];
                var allPurchasingOffers = new List<BuyOfferPurchase>();

                if (itemLookingFor.Price == 0)
                {
                    SearchForFirstItemOfType(allPurchasingOffers, itemLookingFor, itemName);
                }
                else
                {
                    SearchForMultipleOfExistingType(allPurchasingOffers, itemLookingFor, itemName);
                }

                if (allPurchasingOffers.Count <= 0)
                    continue;

                yield return allPurchasingOffers;
            }
        }


        public bool BuyIndividually(BuyOfferPurchase item) => BuyItemsInternal(new List<BuyOfferPurchase> { item });

        public bool BuyBulk(List<BuyOfferPurchase> itemsToBuy)
        {
            return BuyItemsInternal(itemsToBuy);
        }

        private bool BuyItemsInternal(List<BuyOfferPurchase> itemsToBuy)
        {
            var marketBuyRequest = new BuyOfferRequest(itemsToBuy);
            var gameRequest = new GameRequest(LinkManager._moveItemEndPoint, marketBuyRequest);
            var gameWebRequest = new EFTWebRequest(Log, SessionCookie);
            var offerResp = gameWebRequest.EftGameRequest<BuyOfferResponse>(gameRequest);
            if (!CanProcess(offerResp))
            {
                return false;
            }

            BuyOfferResponse marketResponse = offerResp.Data;
            if (marketResponse != null)
            {
                if (marketResponse.Data?.BadRequest.Count > 0)
                {
                    string formattedIds = string.Join(", ", itemsToBuy.Select(itb => itb.id));
                    foreach (var req in marketResponse.Data.BadRequest)
                    {
                        Log($"Bad request during buy offer ({formattedIds})... {req.err} - {req.index} - {req.errmsg}");
                    }

                    return false;
                }

                if (marketResponse.ErrorCode != (int)APIErrorCodes.Ok) return false;

                var itemNames = itemsToBuy.Select(bi => new {
                        Item = bi,
                        Name = LinkManager.ItemsToLookFor[bi.Offer.items[0]._tpl]
                    })
                    .GroupBy(bi => bi.Name, bi => bi)
                    .Select(bi => new { Count = bi.Count(), Name = bi.Key })
                    .ToList();
                List<BoughtItem> boughtItems = GetAllBoughtItems(itemsToBuy);
                LinkManager.AllCurrentItems.BoughtItems.AddRange(boughtItems);
                Log($"Successfully bought {itemNames.Count} type(s) of item ({string.Join(", ", itemNames.Select(i => $"{i.Count}x {i.Name}"))})");
                return true;
            }

            return false;
        }


        /// <summary>
        /// Get all bought items so far
        /// </summary>
        /// <returns></returns>
        public List<BoughtItem> GetAllBoughtItems(List<BuyOfferPurchase> itemsBeingBought)
        {
            foreach (var boughtItem in itemsBeingBought)
            {
                LinkManager.AllBoughtItems.Add(new BoughtItem
                {
                    id = boughtItem.id,
                    item_id = boughtItem.items.First().id,
                    BoughtFor = boughtItem.items.First().count,
                    SoldFor = 0
                });
            }
            return LinkManager.AllBoughtItems;
        }

        /// <summary>
        /// Get all prices from traders so the bot knows what to buy!
        /// </summary>
        public void UpdateItemPrices(PlayerProfile playerProf)
        {
            Log($"Updating item prices...");
            var gameWebRequest = new EFTWebRequest(Log, SessionCookie);
            var gameRequest = new GameRequest(LinkManager._searchTraderForPrices, new object());
            ItemPrice? traderPricesResponse = null;
            while (traderPricesResponse == null)
            {
                var itemPriceReq = gameWebRequest.EftGameRequest<ItemPrice>(gameRequest);

                if (!CanProcess(itemPriceReq))
                {
                    Thread.Sleep(500);
                    return;
                }

                traderPricesResponse = itemPriceReq.Data;
                if (traderPricesResponse == null)
                {
                    Thread.Sleep(500);
                }
            }

            Dictionary<string, List<List<ItemData>>> traderPrices = traderPricesResponse.Data;

            foreach (var item in LinkManager.CurrentItemPrices)
            {
                foreach (var traderPrice in traderPrices)
                {
                    PlayerItem currentItem = playerProf.Inventory.Items.FirstOrDefault(pi => pi.Id == traderPrice.Key);
                    if (currentItem != null)
                    {
                        if (currentItem.ItemTypeId == item.Id)
                        {
                            long curPrice = item.Price;
                            long newPrice = traderPrice.Value[0][0].Count;
                            if (item.Price == newPrice)
                            {
                                //Nothing has changed... next!
                                break;
                            }

                            item.Price = traderPrice.Value[0][0].Count;
                            Log($"Updated item {item.Id}'s price from {curPrice} to {item.Price}");
                            break;
                        }
                    }
                }
            }
        }
    }
}

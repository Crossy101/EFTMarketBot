using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using EFTBot.Data.Classes.API.Old;
using EFTBot.Data.Models.RequestModels.Profile;
using EFTBot.Data.Models.RequestModels.Trading.Market;
using EFTBot.Data.Models.Trader;
using EFTBot.Models.EFT.RequestModels;
using EFTBot.Models.EFT.RequestModels.Profile;
using EFTBot.Models.EFT.RequestModels.Trading.Market;

namespace EFTBot.Data.Classes
{
    public class TraderController : BaseController
    {
        //private const int INDIVIDUAL_ITEM_DELAY = 1_000;

        public bool SellBulk(List<SellablePlayerItem> sellableItems)
        {
            Log($"There are {sellableItems.Count} items to sell...");
            if (sellableItems.Count <= 0)
                return false;

            Log($"Bulk selling {sellableItems.Count} items");
            return SellItems(sellableItems) != null;
        }

        //public void SellItem(SellablePlayerItem sellableItem)
        //{
        //    if (sellableItem == null) return;

        //    Log($"Selling item {sellableItem.Item.Id} of type {sellableItem.Item.ItemTypeId} for {sellableItem.AmountToSell} profit");
        //    SellItemsIndividually(new List<SellablePlayerItem>{ sellableItem });
        //}

        ///// <summary>
        ///// Sells items slowly as a player would.<br/>
        ///// Attempts once per item.
        ///// </summary>
        //private void SellItemsIndividually(List<SellablePlayerItem> sellableItems)
        //{
        //    for(int i = 0; i < sellableItems.Count; i++) { 
        //        Log($"Selling item {i + 1} of {sellableItems.Count}");
        //        var itemsToSell = sellableItems.Skip(i).Take(1);
        //        SellItems(itemsToSell);
        //        Thread.Sleep(INDIVIDUAL_ITEM_DELAY);
        //    }
        //}

        private List<SellItemResponseModel> SellItems(IEnumerable<SellablePlayerItem> sellables)
        {
            var itemsToSell = sellables.ToDictionary(s => s.Item.Id, s => s.AmountToSell);
            var gameWebRequest = new EFTWebRequest(Log, _sessionCookie);
            var newTraderDeal = new SellItemTrader(itemsToSell);

            var responseModels = new List<SellItemResponseModel>(); 

            try
            {
                var newGameRequest = new GameRequest(LinkManager._sellItemsToTraderEndPoint, newTraderDeal);
                SellTraderResponse sellReq = null;
                while (sellReq == null)
                {
                    var sellResp = gameWebRequest.EftGameRequest<SellTraderResponse>(newGameRequest);
                    if (!CanProcess(sellResp))
                    {
                        Log($"Attempted to sell {itemsToSell.Count} items. Failed.");
                        return null;
                    }

                    sellReq = sellResp.Data;
                }

                if (sellReq.data.badRequest.Count > 0)
                {
                    Log($"Unable to sell {itemsToSell.Count} items... {sellReq.data.badRequest.Count} bad request(s)");
                    foreach (var badReq in sellReq.data.badRequest)
                    {
                        Log(badReq.ToString());
                    }

                    return null;
                }
                else
                {
                    foreach (var item in sellReq.data.items.del)
                    {
                        var match = sellables.First(si => si.Item.Id == item._id);

                        string itemName = item._id;
                        if (LinkManager.ItemsToLookFor.TryGetValue(match.Item.ItemTypeId, out var itemToLookFor))
                        {
                            itemName = itemToLookFor;
                        }

                        responseModels.Add(new SellItemResponseModel()
                        {
                            ActualProfit = match.AmountToSell
                        });

                        Log($"Successfully sold item {itemName}");

                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.ToString());
            }

            return responseModels;
        }
    }
}

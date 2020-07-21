using System.Collections.Generic;

namespace EFTBot.Data.Models.RequestModels.Trading.Market
{
    public class SellItemTrader
    {
        public List<SellItemAction> data { get; set; }
        public int tm { get; set; } = 2;

        public SellItemTrader(Dictionary<string, int> itemsToTrade)
        {
            data = new List<SellItemAction>
            {
                new SellItemAction(itemsToTrade)
            };
        }
    }

    public class SellItemAction
    {
        public string Action { get; set; } = "TradingConfirm";
        public string type { get; set; } = "sell_to_trader";
        public string tid { get; set; } = "54cb57776803fa99248b456e";
        public List<ItemToSell> items { get; set; }

        public SellItemAction(Dictionary<string, int> itemsToTrade)
        {
            items = new List<ItemToSell>();
            foreach (var item in itemsToTrade)
            {
                items.Add(new ItemToSell
                {
                    id = item.Key,
                    count = item.Value
                }) ;
            }
        }
    }

    public class ItemToSell
    {
        public string id { get; set; }
        public int count { get; set; }
        public int scheme_id { get; set; } = 0;
    }
}

using System.Collections.Generic;

#nullable enable

namespace EFTBot.Data.Models.RequestModels.Trading.Market
{
    public class Location
    {
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }
        public bool isSearched { get; set; }
    }

    public class Upd
    {
        public int StackObjectsCount { get; set; }
    }

    public class Change
    {
        public string _id { get; set; }
        public string _tpl { get; set; }
        public string parentId { get; set; }
        public string slotId { get; set; }
        public Location location { get; set; }
        public Upd upd { get; set; }
    }

    public class Del
    {
        public string _id { get; set; }
    }

    public class Items
    {
        public List<Change>? change { get; set; }
        public List<Del>? del { get; set; }
    }

    //public class CurrentSalesSums
    //{
    //    public Dictionary<string, long> __invalid_name__54cb57776803fa99248b456e { get; set; }
    //}

    public class Data
    {
        public Items items { get; set; }
        public List<object> badRequest { get; set; }
        public List<object> quests { get; set; }
        public List<object> ragFairOffers { get; set; }
        public List<object> builds { get; set; }
        public Dictionary<string, long> currentSalesSums { get; set; }
    }

    public class SellTraderResponse
    {
        public int err { get; set; }
        public string errmsg { get; set; }
        public Data data { get; set; }
    }

    public class SellTraderFailureResponse
    {
        public int err { get; set; }
        public string errmsg { get; set; }
        public object[] data { get; set; }
    }
}

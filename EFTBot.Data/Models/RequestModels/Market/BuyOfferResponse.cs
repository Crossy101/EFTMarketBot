using System.Collections.Generic;
using Newtonsoft.Json;

#nullable enable

namespace EFTBot.Data.Models.RequestModels.Market
{
    public class Location
    {
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }
    }

    public class New
    {
        public string _id { get; set; }
        public string _tpl { get; set; }
        public string parentId { get; set; }
        public string slotId { get; set; }
        public Location location { get; set; }
        public object upd { get; set; }
    }

    public class Location2
    {
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }
        public bool isSearched { get; set; }
    }

    public class Change
    {
        public string _id { get; set; }
        public string _tpl { get; set; }
        public string parentId { get; set; }
        public string slotId { get; set; }
        public Location2 location { get; set; }
        public Upd upd { get; set; }
    }

    public class Items
    {
        public List<New>? @new { get; set; }
        public List<Change>? change { get; set; }
    }

    public class Data
    {
        [JsonProperty("items")]
        public Items Items { get; set; }

        [JsonProperty("badRequest")]
        public List<dynamic> BadRequest { get; set; }

        [JsonProperty("quests")]
        public List<object> Quests { get; set; }

        [JsonProperty("ragFairOffers")]
        public List<object> RagFairOffers { get; set; }

        [JsonProperty("builds")]
        public List<object> Builds { get; set; }
    }

    public class BuyOfferResponse
    {
        [JsonProperty("err")]
        public int ErrorCode { get; set; }

        [JsonProperty("errmsg")]
        public object ErrorMessage { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class BadRequest
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("errmsg")]
        public string ErrorMessage { get; set; }

        [JsonProperty("err")]
        public int ErrorCode { get; set; }
    }

}

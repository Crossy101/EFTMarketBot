using EFTBot.Models.EFT.Enums;
using System.Collections.Generic;
using Newtonsoft.Json;

#nullable enable

namespace EFTBot.Models.EFT.RequestModels.Trading.Market
{
    public class ItemPrice
    {
        [JsonProperty("err")]
        public APIErrorCodes ErrorCode { get; set; }

        [JsonProperty("errmsg")]
        public string? ErrorMessage { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, List<List<ItemData>>> Data { get; set; }
    }

    public class ItemData
    {
        [JsonProperty("_tpl")]
        public string Tpl { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }
}

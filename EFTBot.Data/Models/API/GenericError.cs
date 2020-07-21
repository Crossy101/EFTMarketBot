using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace EFTBot.Data.Models.API
{
    public class GenericError
    {
        [JsonProperty("err")]
        public int Error { get; set; }

        [JsonProperty("errmsg")]
        public string ErrorMessage { get; set; }

        [JsonProperty("data")]
        public dynamic Data { get; set; }
    }
}

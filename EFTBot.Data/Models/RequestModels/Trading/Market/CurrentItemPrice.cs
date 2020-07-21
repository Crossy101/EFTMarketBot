using Newtonsoft.Json;

namespace EFTBot.Data.Models.RequestModels.Trading.Market
{
    public class CurrentItemPrice
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        public override string ToString() => $"{Id} - {Price}";
    }
}

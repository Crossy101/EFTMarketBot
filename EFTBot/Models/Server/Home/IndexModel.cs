using EFTBot.Models.EFT.RequestModels.Trading.Market;
using System.Collections.Generic;
using EFTBot.Data.Models;
using EFTBot.Data.Models.RequestModels.Trading.Market;

namespace EFTBot.Models.Server.Home
{
    public class IndexModel
    {
        public string CurrentRequests { get; set; }
        public string CurrentRoubles { get; set; }
        public string CurrentProfit { get; set; }
        public List<CurrentItemPrice> ItemPrices { get; set; }
        public Dictionary<string, string> ItemsToLookFor { get; set; }
        public List<CurrentProfitModel> ProfitEveryHour { get; set; }
    }
}

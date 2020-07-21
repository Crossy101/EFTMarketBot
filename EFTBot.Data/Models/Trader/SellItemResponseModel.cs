using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace EFTBot.Data.Models.Trader
{
    public class SellItemResponseModel
    {
        public string Id { get; set; }
        public string ItemTypeId { get; set; }
        public long ExpectedProfit { get; set; }
        public long ActualProfit { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.Server.Home
{
    public class ProfitMarginModel
    {
        public string item_id { get; set; }
        public long CurrentProfitMargin { get; set; }

        public void AddToProfitMargin(long profit)
        {
            CurrentProfitMargin += profit;
        }
    }
}

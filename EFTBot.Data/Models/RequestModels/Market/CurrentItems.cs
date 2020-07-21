using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Market
{
    public class CurrentItems
    {
        public List<BoughtItem> BoughtItems { get; set; }

        public CurrentItems()
        {
            BoughtItems = new List<BoughtItem>();
        }
    }

    public class BoughtItem
    {
        public string id { get; set; }
        public string item_id { get; set; }
        public long BoughtFor { get; set; }
        public long SoldFor { get; set; }
        public long ProfitMargin { get; set; }
        public void SetProfitMargin(long soldPrice)
        {
            this.SoldFor = soldPrice;
            this.ProfitMargin = SoldFor - BoughtFor;
        }
    }

}

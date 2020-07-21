using System;
using System.Collections.Generic;
using System.Text;

namespace EFTBot.Data.Models.RequestModels.Profile
{
    public class SellablePlayerItem
    {
        public PlayerItem Item { get; set; }

        public int AmountToSell { get; set; }
        public long ExpectedProfit { get; set; }

        public SellablePlayerItem(PlayerItem item, int amountToSell = 0)
        {
            Item = item;
            AmountToSell = amountToSell;
        }
    }
}

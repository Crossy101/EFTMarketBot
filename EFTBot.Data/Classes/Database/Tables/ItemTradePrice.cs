using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFTBot.Data.Classes.Database.Tables
{
    public class ItemTradePrice
    {
        public string ItemId { get; set; }
        public string TraderId { get; set; }
        /// <summary>
        /// The amount the item can be sold to a trader for
        /// </summary>
        public long SellingPrice { get; set; }
        /// <summary>
        /// When the price needs to be retrieved again (as the trader's prices have changed)
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }

        [ForeignKey(nameof(TraderId))]
        public Trader Trader { get; set; }
    }
}

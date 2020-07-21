using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFTBot.Data.Classes.Database.Tables
{
    /// <summary>
    /// Represents a trade between a bot and a player on the flea market
    /// </summary>
    [Table("ItemTrades")]
    public class ItemTrade
    {
        [Key]
        public string TradeId { get; set; }

        /// <summary>
        /// The bot that made the trade
        /// </summary>
        public int BotId { get; set; }

        /// <summary>
        /// When the trade occurred
        /// </summary>
        public DateTime TradeDate { get; set; }
        public string PlayerId { get; set; }       
        
        /// <summary>
        /// The item that was traded
        /// </summary>
        public int ItemId { get; set; }
        public long ItemCost { get; set; }
        public int Quantity { get; set; }


        [ForeignKey(nameof(PlayerId))]
        public virtual Player Player { get; set; }

        [ForeignKey(nameof(BotId))]
        public virtual Bot Bot { get; set; }

        [ForeignKey(nameof(ItemId))]
        public virtual Item Item { get; set; }
    }
}

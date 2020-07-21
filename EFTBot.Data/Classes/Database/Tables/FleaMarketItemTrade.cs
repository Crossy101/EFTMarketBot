using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using EFTBot.Data.Enums;

namespace EFTBot.Data.Classes.Database.Tables
{
    [Table("FleaMarketItemTrades")]
    public class FleaMarketItemTrade
    {
        [Key]
        public string TradeId { get; set; }

        public string ItemId { get; set; }
        public long Price { get; set; }
        public CurrencyType Currency { get; set; }

        /// <summary>
        /// The bot that bought the trade item
        /// </summary>
        public int BotId { get; set; }

        /// <summary>
        /// The id of the player that listed the item in the market
        /// </summary>
        public string PlayerId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }

        [ForeignKey(nameof(BotId))]
        public Bot Bot { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; }
    }
}

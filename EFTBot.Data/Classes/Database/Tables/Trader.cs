using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFTBot.Data.Classes.Database.Tables
{
    [Table("Traders")]
    public class Trader
    {
        [Key]
        public string TraderId { get; set; }
        public string Name { get; set; }
    }
}

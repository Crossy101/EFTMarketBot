using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFTBot.Data.Classes.Database.Tables
{
    [Table("Items")]
    public class Item
    {
        /// <summary>
        /// Represents a unique type of item.
        /// </summary>
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}

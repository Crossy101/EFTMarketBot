using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFTBot.Data.Classes.Database.Tables
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public string PlayerId { get; set; }
    }
}

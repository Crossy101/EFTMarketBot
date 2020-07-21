using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFTBot.Data.Classes.Database.Tables
{
    [Table("Bots")]
    public class Bot
    {
        /// <summary>
        /// Identifier for the bot itself. Not used in-game
        /// </summary>
        [Key]
        public int BotId { get; set; }

        /// <summary>
        /// A nickname for easier identification of a bot
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// The player id of the bot in-game
        /// </summary>
        public string UserId { get; set; }

        public string IPAddress { get; set; }
        
        /// <summary>
        /// Whether or not a bot is online.
        /// </summary>
        public bool Active { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EFTBot.Business.Models.Traders
{
    public class SimpleTraderItemPrice
    {
        ///// <summary>
        ///// Specific instance of an item type
        ///// </summary>
        //public string Id { get; set; }

        /// <summary>
        /// The item type itself (AK47, AK47 Ammo etc...)
        /// </summary>
        public string ItemTypeId { get; set; }

        public long Price { get; set; }

        public override string ToString()
        {
            //return $"{Id} - {ItemTypeId} - {Price}";
            return $"{ItemTypeId} - {Price}";
        }
    }
}

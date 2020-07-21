using System;
using System.Collections.Generic;
using System.Text;
using EFTBot.Data.Classes.API;

namespace EFTBot.Business.Classes
{
    /// <summary>
    /// Automates the selling of items to traders (focuses on maximizing profit)
    /// </summary>
    public class TradeManager : BaseManager
    {
        public TradeManager(EftApi api) : base(api)
        {

        }
    }
}

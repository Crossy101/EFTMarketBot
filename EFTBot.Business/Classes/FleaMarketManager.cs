using System;
using System.Collections.Generic;
using System.Text;
using EFTBot.Data.Classes.API;
using EFTBot.Data.Models.RequestModels.Profile;
using EFTBot.Models.EFT.RequestModels.Profile;

namespace EFTBot.Business.Classes
{

    /// <summary>
    /// Automates the buying of items from the flea market (Buys the cheapest items which are worth the most to NPC traders)
    /// </summary>
    public class FleaMarketManager : BaseManager
    {
        public PlayerProfile Profile { get; private set; }
        public FleaMarketManager(EftApi api) : base(api)
        {

        }
    }
}

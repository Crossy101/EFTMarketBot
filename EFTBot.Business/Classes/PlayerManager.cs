using System;
using System.Collections.Generic;
using System.Text;
using EFTBot.Data.Classes.API;
using EFTBot.Data.Models.RequestModels.Profile;
using EFTBot.Models.EFT.RequestModels.Profile;

namespace EFTBot.Business.Classes
{
    /// <summary>
    /// Manages the user's inventory, roubles etc...
    /// </summary>
    public class PlayerManager : BaseManager
    {
        public PlayerManager(EftApi api) : base(api)
        {

        }
    }
}

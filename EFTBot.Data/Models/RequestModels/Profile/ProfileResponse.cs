using System.Collections.Generic;
using EFTBot.Models.EFT.RequestModels;

namespace EFTBot.Data.Models.RequestModels.Profile
{
    public class ProfileResponse : WebResponse
    {
        public List<PlayerProfile> data { get; set; }
    }
}

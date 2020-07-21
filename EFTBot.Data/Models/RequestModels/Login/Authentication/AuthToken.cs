using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login.Authentication
{
    public class AuthToken
    {
        public AuthServerDetails version { get; set; }
        public string hwCode { get; set; }

        public AuthToken(string hwid, string gameVersion)
        {
            version = new AuthServerDetails
            {
                major = gameVersion,
                game = "live",
                backend = "6"
            };
            this.hwCode = hwid;
        }
    }
}

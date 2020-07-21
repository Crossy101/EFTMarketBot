using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login
{
    public class LoginData
    {
        public string aid { get; set; }
        public string lang { get; set; }
        public string region { get; set; }
        public string gameVersion { get; set; }
        public List<string> dataCenters { get; set; }
        public string ipRegion { get; set; }
        public bool checkLegal { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
    }
}

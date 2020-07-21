using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login.Authentication
{
    public class AuthResponseData
    {
        public bool queued { get; set; }
        public string session { get; set; }
    }
}

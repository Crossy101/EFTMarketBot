using EFTBot.Models.EFT.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login.Authentication
{
    public class AuthReponse : WebResponse
    {
        public AuthResponseData data { get; set; }
    }
}

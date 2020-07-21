using EFTBot.Models.EFT.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login
{
    public class LoginResponse : WebResponse
    {
        public LoginData data { get; set; }
    }
}

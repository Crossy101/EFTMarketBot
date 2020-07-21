using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login
{
    public class LoginRequest
    {
        public string email { get; set; }
        public string pass { get; set; }
        public string hwCode { get; set; }
        public string captcha { get; set; }
    }
}

using EFTBot.Models.EFT.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels
{
    public class WebResponse
    {
        public APIErrorCodes err { get; set; }
        public string errmsg { get; set; }
    }



}

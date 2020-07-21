using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login
{
    public class MachineActivation
    {
        public string email { get; set; }
        public string code { get; set; }
        public string hwid { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.Server
{
    public class EFTAccountDetails
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HardwareID { get; set; }
        public bool Authenticated { get; set; }
        public DateTime Created { get; set; }
    }
}

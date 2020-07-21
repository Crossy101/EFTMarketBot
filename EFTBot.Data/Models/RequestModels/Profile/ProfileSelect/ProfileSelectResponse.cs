using EFTBot.Models.EFT.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Profile.ProfileSelect
{
    public class ProfileSelectResponse : WebResponse
    {
        public Data data { get; set; }
    }

    public class Notifier
    {
        public string server { get; set; }
        public string channel_id { get; set; }
        public string url { get; set; }
    }

    public class Data
    {
        
        public string status { get; set; }
        public Notifier notifier { get; set; }
        public string notifierServer { get; set; }
    }
}

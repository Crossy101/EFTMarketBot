using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login.Version
{
    public class LauncherVersionResponse
    {
        public int err { get; set; }
        public object errmsg { get; set; }
        public LauncherVersion data { get; set; }
    }
    public class LauncherVersion
    {
        public string Version { get; set; }
        public string hash { get; set; }
        public string DownloadUri { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Login.Version
{
    public class GameVersionResponse
    {
        public int err { get; set; }
        public object errmsg { get; set; }
        public List<GameVersions> data { get; set; }
    }

    public class GameVersions
    {
        public string Version { get; set; }
        public string FromVersion { get; set; }
        public string Hash { get; set; }
        public string DownloadUri { get; set; }
        public bool FullConsistencyCheck { get; set; }
        public bool ClearCache { get; set; }
        public bool DeleteLocalIni { get; set; }
        public bool DeleteSharedIni { get; set; }
        public string TorrentUri { get; set; }
    }
}

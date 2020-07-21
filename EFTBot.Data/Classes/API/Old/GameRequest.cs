using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels
{
    public class GameRequest
    {
        public string URL { get; set; }
        public object body { get; set; }

        public GameRequest(string _url, object _body)
        {
            this.URL = _url;
            this.body = _body;
        }
    }
}

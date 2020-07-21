using System;
using System.Collections.Generic;
using System.Text;
using EFTBot.Data.Classes.API;

namespace EFTBot.Business.Classes
{
    public class BaseManager
    {
        protected readonly EftApi _api;
        public BaseManager(EftApi api)
        {
            _api = api;
        }
    }
}

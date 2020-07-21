using System;
using System.Collections.Generic;
using System.Text;
using EFTBot.Data.Classes.Database.Tables;

namespace EFTBot.Data.Classes.Database.Managers
{
    public class FleaMarketManager : BaseTableManager<FleaMarketItemTrade>
    {
        public FleaMarketManager(EftBotServerContext db) : base(db)
        {

        }
    }
}

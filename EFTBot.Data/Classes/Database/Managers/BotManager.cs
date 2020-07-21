using EFTBot.Data.Classes.Database.Tables;

namespace EFTBot.Data.Classes.Database.Managers
{
    public class BotManager : BaseTableManager<Bot>
    {
        public BotManager(EftBotServerContext db) : base(db)
        {

        }
    }
}

using EFTBot.Data.Classes.Database.Tables;

namespace EFTBot.Data.Classes.Database.Managers
{
    public class ItemManager : BaseTableManager<Bot>
    {
        public ItemManager(EftBotServerContext db) : base(db)
        {

        }
    }
}

using EFTBot.Data.Classes.Database.Tables;

namespace EFTBot.Data.Classes.Database.Managers
{
    public class ItemTradePriceManager : BaseTableManager<Bot>
    {
        public ItemTradePriceManager(EftBotServerContext db) : base(db)
        {

        }
    }
}

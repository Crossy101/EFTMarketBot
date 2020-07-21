using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Data.Classes.Database.Managers
{
    /// <summary>
    /// Manages a single row type.
    /// Bulk methods won't submit changes to database by themselves (they can all be chained - call .SaveChangesAsync to submit changes to the db)
    /// </summary>
    /// <typeparam name="T">Type representation of a row</typeparam>
    public class BaseTableManager<T> where T : class
    {
        protected readonly EftBotServerContext _db;
        public BaseTableManager(EftBotServerContext db)
        {
            _db = db;
        }

        protected object[] FindKeys(T obj)
        {
            var entry = _db.Entry(obj);
            var keys = entry.Metadata
                .FindPrimaryKey()
                .Properties
                .Select(p => entry.Property(p.Name).CurrentValue)
                .ToArray();
            return keys;
        }

        /// <summary>
        /// Adds or updates an existing item.<br/>
        /// </summary>
        /// <param name="obj">The row to modify</param>
        public async Task AddOrUpdateBulk(T obj)
        {
            var objKeys = FindKeys(obj);
            var dbObj = await _db.FindAsync(typeof(T), objKeys);
            if (dbObj != null)
            {
                //Add object.
                await _db.AddAsync(obj);
            }
            else
            {
                //Update existing object with the changed properties only.
                //More efficient than marking the entity as Modified and forcing all properties to be updated.
                _db.Entry(dbObj).CurrentValues.SetValues(obj);
            }
        }

        public async Task<bool> AddOrUpdate(T obj)
        {
            await AddOrUpdateBulk(obj);
            return await _db.SaveChangesAsync() > 0;
        }

        public void DeleteBulk(T obj)
        {
            _db.Remove(obj);
        }

        public async Task<bool> DeleteBulkAsync(T obj)
        {
            _db.Remove(obj);
            return await _db.SaveChangesAsync() > 0;
        }
    }
}

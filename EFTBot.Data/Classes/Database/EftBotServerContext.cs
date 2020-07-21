using System;
using System.Collections.Generic;
using System.Text;
using EFTBot.Data.Classes.Database.Tables;
using Microsoft.EntityFrameworkCore;

namespace EFTBot.Data.Classes.Database
{
    public class EftBotServerContext : DbContext
    {
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemTrade> ItemTrades { get; set; }
        public DbSet<ItemTradePrice> ItemTradePrices { get; set; }
        public DbSet<Player> Players { get; set; }

        public EftBotServerContext(DbContextOptions opts) : base(opts)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemTradePrice>()
                .HasKey(itp => new { itp.ItemId, itp.TraderId });
        }
    }
}

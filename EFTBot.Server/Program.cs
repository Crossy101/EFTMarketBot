using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFTBot.Data.Classes.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EFTBot.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    services.AddDbContext<EftBotServerContext>(opts => opts.UseSqlServer(hostContext.Configuration.GetConnectionString("EftBotServer")));
                });
    }
}

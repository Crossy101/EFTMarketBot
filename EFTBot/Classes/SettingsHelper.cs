using EFTBot.Data.Models.Configuration;
using Microsoft.Extensions.Configuration;

namespace EFTBot.Classes
{
    public static class SettingsHelper
    {
        public static StartupSettings GetSettings(IConfiguration config)
        {
            //TODO: On load generate a HWID and use it forever (well until user wants it changed...)
            return new StartupSettings()
            {
                Email = config["Login:Email"],
                Password = config["Login:Password"].ToLower(),
                HardwareId = config["Auth:HardwareId"]
            };
        }
    }
}

using EFTBot.Data.Models;
using System.Collections.Generic;
using System.Threading;
using EFTBot.Data.Models.RequestModels.Trading.Market;
using EFTBot.Models.EFT.RequestModels.Market;

namespace EFTBot.Data.Classes
{
    public static class LinkManager
    {
        #region EFT_GAME_VERSIONS
        public static string LAUNCHER_VERSION;// = "0.9.3.1023";
        public static string GAME_VERSION = "0.12.3.6152";
        public static string UNITY_VERSION = "2018.4.13f1";
        #endregion

        #region EFT_GAME_URLS
        private const string _launcherEndPoint = "https://launcher.escapefromtarkov.com";
        private const string _ragfairEndPoint = "https://ragfair.escapefromtarkov.com";
        private const string _prodEndPoint = "https://prod.escapefromtarkov.com";
        private const string _tradingEndPoint = "https://trading.escapefromtarkov.com";
        #endregion

        public static string _loginEndPoint = $"{_launcherEndPoint}/launcher/login?launcherVersion={LAUNCHER_VERSION}&branch=live";
        public static string _authoriseAccountEndPoint = $"{_launcherEndPoint}/launcher/game/start?launcherVersion={LAUNCHER_VERSION}&branch=live";
        public static string _activateHardwareEndPoint = $"{_launcherEndPoint}/launcher/hardwareCode/activate?launcherVersion={LAUNCHER_VERSION}";

        public static string _sellItemsToTraderEndPoint = $"{_prodEndPoint}/client/game/profile/items/moving";
        public static string _getProfileListEndPoint = $"{_prodEndPoint}/client/game/profile/list";
        public static string _selectProfileEndPoint = $"{_prodEndPoint}/client/game/profile/select";
        public static string _selectLocalizationEndPoint = $"{_prodEndPoint}/client/locale/en";
        public static string _moveItemEndPoint = $"{_prodEndPoint}/client/game/profile/items/moving"; // Can be used for both buying and selling items
        public static string _itemPrices = $"{_prodEndPoint}/client/items/prices";

        public static string _searchTraderForPrices = $"{_tradingEndPoint}/client/trading/api/getUserAssortPrice/trader/54cb57776803fa99248b456e";
        public static string _getTradersEndPoint = $"{_tradingEndPoint}/client/trading/api/getTradersList";

        public static string _searchMarketEndPoint = $"{_ragfairEndPoint}/client/ragfair/find";

        public static int RequestsSents = 0;
        public static long CurrentRoubles = 0;

        public const int Timer = 300;

        public static List<CurrentItemPrice> CurrentItemPrices { get; set; } = new List<CurrentItemPrice>();
        public static CurrentItems AllCurrentItems { get; set; } = new CurrentItems();

        public static List<BoughtItem> AllBoughtItems { get; set; } = new List<BoughtItem>();
        public static List<CurrentProfitModel> CurrentProfit { get; set; } = new List<CurrentProfitModel>();

        //Controls whether the bot can buy or not. This is used for shutting down the bot
        private static bool _canBuy;

        public static bool CanBuy
        {
            get => Volatile.Read(ref _canBuy);
            set => Volatile.Write(ref _canBuy, value);
        }

        static LinkManager()
        {
            CanBuy = false;
        }


        //Currency Rouble
        public const string ROUBLE_CURRENCY_ID = "5449016a4bdc2d6f028b456f";

        public static Dictionary<string, string> ItemsToLookFor = new Dictionary<string, string>
        {
            //BITCOIN
            { "59faff1d86f7746c51718c9c", "Bitcoin" },
            //ANTIQUE TEAPOT
            { "590de71386f774347051a052", "Antique Teapot" },
            //ANTIQUE VASE
            { "590de7e986f7741b096e5f32", "Antique Vase" },
            //GOLD SKULL RING
            { "5d235a5986f77443f6329bc6", "Gold Skull Ring" },
            //GOLDEN NECK CHAIN
            { "5734758f24597738025ee253", "Golden Neck Chain" },
            //ANTQUIE BOOK
            { "5bc9c049d4351e44f824d360", "Antique Book" },

            //TODO: Support other traders :(
            //{ "590c645c86f77412b01304d9", "Battered Antique Book" },

            //BRONZE LION
            { "59e3639286f7741777737013", "Bronze Lion" },
            //CAT FIGURINE
            { "59e3658a86f7741776641ac4", "Cat Figurine" },
            //CHAIN PROKILL MEDALION
            { "5c1267ee86f77416ec610f72", "Chain Medallion" },
            //CHAINLET
            { "573474f924597738002c6174", "Chainlet" },
            //GP COIN
            { "5d235b4d86f7742e017bc88a", "GP Coin" },
            //GOLDEN ROOSTER
            { "5bc9bc53d4351e00367fbcee", "Golden Rooster" },
            //HORSE FIGURINE
            { "573478bc24597738002c6175", "Horse Figurine" },
            //OLD FIRESTEEL
            { "5bc9c377d4351e3bac12251b", "Old Firesteel" },
            //ROLER WRIST WATCH
            { "59faf7ca86f7740dbe19f6c2", "Roler Wrist Watch" },
            //SILVER BADGE
            { "5bc9bdb8d4351e003562b8a1", "Silver Badge" },
            //WOODEN CLOCK
            { "59e3647686f774176a362507", "Wooden Clock" },
            //BROKEN GPHONE
            { "56742c324bdc2d150f8b456d", "Broken GPhone" },
            //GAS ANALYZER
            { "590a3efd86f77437d351a25b", "Gas Analyzer" },
            //CAR BATTERY
            { "5733279d245977289b77ec24", "Car Battery" },
            //RECHARGEABLE BATTERY
            { "590a358486f77429692b2790", "Recharable Battery" },
            //#FIREKLEAN GUN LUBE
            { "5bc9b355d4351e6d1509862a", "#FireKlean Gun Lube" },
            //HYDROGEN PEROXIDE
            { "59e361e886f774176c10a2a5", "Hydrogen Peroxide" },
            //LONG FLAT SCREWDRIVER
            { "5d4042a986f7743185265463", "Long Flat Screwdriver" },
            //ROUND PLIERS
            { "5d1b31ce86f7742523398394", "Round Pliers" },
            //42ND ENGLISH TEA
            { "5bc9be8fd4351e00334cae6e", "42nd English Tea" }
        };
    }
}

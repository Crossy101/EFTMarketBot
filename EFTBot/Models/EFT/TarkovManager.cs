using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EFTBot.Data.Classes;
using EFTBot.Data.Classes.API;
using EFTBot.Data.Models;
using EFTBot.Data.Models.Configuration;
using EFTBot.Data.Models.RequestModels.Profile;

namespace EFTBot.Models.EFT
{
    public class TarkovManager : BaseController
    {
        private LoginController _loginController;
        private ProfileController _profileController;
        private MarketController _marketController;
        private TraderController _traderController;

        private DateTime _botEndTime;

        private DateTime _nextProfitCheck;
        private int _lastRoublesCheck;

        private int _hoursForBotToRestart = 4;

        private readonly StartupSettings _config;

        #region Constructors
        //BOT STARTING POINT
        public TarkovManager(StartupSettings config, EftApi api)
        {
            _config = config;

            //Create the Login Controller
            _loginController = new LoginController(_config, api);

            //Create the Profile Controller
            _profileController = new ProfileController();

            //Create the Market Controller
            _marketController = new MarketController(_profileController);

            //Create the Trader Controller
            _traderController = new TraderController();

            _botEndTime = DateTime.Now.AddHours(_hoursForBotToRestart);

            //Create a thread for a back-end task that the server will complete
            var botTask = new Task(StartTradingGrind);
            botTask.Start();
        }

        public void StartFindingItems()
        {
            _loginController.AuthenticateLogin();

            SetAllControllerCookies(_loginController._authResponse.data.session);

            _profileController.SelectPMCProfile();
            while (true)
            {
                Thread.Sleep(LinkManager.Timer);
            }
        }

        public void StartTradingGrind()
        {
            _loginController.AuthenticateLogin();

            SetAllControllerCookies(_loginController._authResponse.data.session);

            _profileController.SelectPMCProfile();
            PlayerProfile profile = _profileController.GetLatestPlayerProfile();
            LinkManager.CurrentRoubles = _profileController.GetCurrentRoubles(); 
            _profileController.GetSellableFromInventory();
            long currentRoubles = LinkManager.CurrentRoubles;
            while (true)
            {
                Log("Running main loop!");

                CheckBotTime();

                LinkManager.AllBoughtItems.Clear();

                //TODO: Handle error 201 (Need to login again)
                //TODO: Maybe a check to exit the bot once we've filled all of our slots? Otherwise we're just spamming their API for no reason - too obvious

                foreach (var itemsToBuy in _marketController.GetBuyableItems(profile))
                {
                    profile = _profileController.GetLatestPlayerProfile();

                    currentRoubles = (LinkManager.CurrentRoubles = _profileController.GetCurrentRoubles());
                    bool haveBoughtItems = _marketController.BuyBulk(itemsToBuy);
                    Thread.Sleep(LinkManager.Timer);

                    //TODO: After buying items, update the inventory on our end without calling server. Saves requests too.
                    profile = _profileController.GetLatestPlayerProfile();

                    if (!haveBoughtItems)
                    {
                        continue;
                    }

                    var sellableItems = _profileController.GetSellableFromInventory();
                    //foreach (var sellableItem in sellableItems)
                    //{
                    //    var matchingBuyOffer = itemToBuy.First(itb => itb.Offer.items[0]._id == sellableItem.Item.Id);
                    //    sellableItem.ExpectedProfit = matchingBuyOffer.ExpectedProfit;
                    //}

                    //TODO: Update inventory situation based on the updates from buying/selling (delete/change properties). Cheaper than two profile lookups each time we buy a set.
                    bool sellSuccessful = _traderController.SellBulk(sellableItems);
                    if (sellSuccessful)
                    {
                        profile = _profileController.GetLatestPlayerProfile();
                        long amountAfterSelling = (LinkManager.CurrentRoubles = _profileController.GetCurrentRoubles());
                        long profitMade = amountAfterSelling - currentRoubles;
                        Log($"Profit made: {profitMade}");
                        Console.Title = $"Current Roubles: {amountAfterSelling:C}";
                    }
                    else
                    {
                        Log($"Failed to sell items. Not calculating profit as there is none (pending items to sell)");
                    }

                    Thread.Sleep(LinkManager.Timer);
                }
                GetLastHourProfit();
                Thread.Sleep(LinkManager.Timer);
            }
        }

        public TarkovManager(StartupSettings config, EftApi api, string sessionCookie)
        {
            _config = config;
            _loginController = new LoginController(_config, api);
            _sessionCookie = sessionCookie;
        }
#endregion

        //Set all controllers sessionCookies
        private void SetAllControllerCookies(string sessionCookie)
        {
            _profileController.SessionCookie = sessionCookie;
            _marketController.SessionCookie = sessionCookie;
            _traderController.SetCookie(sessionCookie);
        }

        //If bot has been running consistently for 4 hours restart the bot so we get a new token
        private void CheckBotTime()
        {

            if (DateTime.Now < _botEndTime)
                return;

            Thread.Sleep(60000);

            _botEndTime = DateTime.Now.AddHours(_hoursForBotToRestart);
            StartTradingGrind();
        }

        private void GetLastHourProfit()
        {
            //If the bot has just started
            if(_nextProfitCheck == default)
            {
                LinkManager.CurrentProfit.Add(new CurrentProfitModel
                {
                    CurrentProfit = 0,
                    CurrentTime = DateTime.Now
                });

                _nextProfitCheck = DateTime.Now.AddHours(1);
                _lastRoublesCheck = (int)LinkManager.CurrentRoubles;
                return;
            }

            //Collect profit every hour
            if (DateTime.Now >= _nextProfitCheck)
            {
                LinkManager.CurrentProfit.Add(new CurrentProfitModel
                {
                    CurrentProfit = ((int)LinkManager.CurrentRoubles - _lastRoublesCheck),
                    CurrentTime = DateTime.Now
                });
                _lastRoublesCheck = (int)LinkManager.CurrentRoubles;
                _nextProfitCheck = DateTime.Now.AddHours(1);
            };   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EFTBot.Data.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFTBot.Models;
using EFTBot.Models.EFT;
using EFTBot.Models.Server.Home;

namespace EFTBot.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public JsonResult ToggleBuyingStatus(bool enabled)
        {
            //TODO: Proper IoC - So we can do _botManger.SendEvent<CanBuyEvent>(new CanBuyEvent(true));
            LinkManager.CanBuy = enabled;
            return new JsonResult(enabled);
        }

        [HttpGet]
        public IActionResult Index()
        {
            IndexModel viewModel = new IndexModel
            {
                CurrentRequests = $"{LinkManager.RequestsSents:n0}",
                CurrentRoubles = $"{LinkManager.CurrentRoubles:n0}",
                CurrentProfit = $"{0:n0}",
                ItemPrices = LinkManager.CurrentItemPrices,
                ItemsToLookFor = LinkManager.ItemsToLookFor,
                ProfitEveryHour = LinkManager.CurrentProfit
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

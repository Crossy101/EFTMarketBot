using EFTBot.Models.EFT.Enums.Trading.MarketFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.RequestModels.Market
{
    public class SearchRequest
    {
        public int page { get; set; } = 0;
        public int limit { get; set; } = 15;
        public SortFilter sortType { get; set; } = SortFilter.Price;
        public SortDirection sortDirection { get; set; } = SortDirection.Descending;
        public Currency currency { get; set; } = Currency.Any;
        public int priceFrom { get; set; } = 0;
        public int priceTo { get; set; } = 0;
        public int quantityFrom { get; set; } = 0;
        public int quantityTo { get; set; } = 0;
        public int conditionFrom { get; set; } = 0;
        public int conditionTo { get; set; } = 100;
        public bool oneHourExpiration { get; set; } = false;
        public bool removeBartering { get; set; } = true;
        public Trader offerOwnerType { get; set; } = Trader.Any;
        public bool onlyFunctional { get; set; } = false;
        public bool updateOfferCount { get; set; } = false;
        public string handbookId { get; set; } = "";
        public string linkedSearchId { get; set; } = "";
        public string neededSearchId { get; set; } = "";
        public BuildItems buildItems { get; set; }
        public int buildCount { get; set; } = 0;
        public int tm { get; set; } = 1;

        public SearchRequest()
        {
            removeBartering = true;
            currency = Currency.Roubles;
            offerOwnerType = Trader.Players;
        }

        public SearchRequest(string itemId) : this()
        {
            handbookId = itemId;
        }

        //public SearchRequest(string itemId) : this()
        //{
        //    handbookId = itemId;
        //}
    }

    public class BuildItems
    {

    }
}

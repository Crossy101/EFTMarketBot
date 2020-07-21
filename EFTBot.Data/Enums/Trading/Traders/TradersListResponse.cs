using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.Enums.Trading.Traders
{
    public class Repair
    {
        public bool availability { get; set; }
        public string quality { get; set; }
        public List<object> excluded_id_list { get; set; }
        public List<object> excluded_category { get; set; }
        public string currency { get; set; }
        public int currency_coefficient { get; set; }
        public int price_rate { get; set; }
    }

    public class Insurance
    {
        public bool availability { get; set; }
        public int min_payment { get; set; }
        public int min_return_hour { get; set; }
        public int max_return_hour { get; set; }
        public int max_storage_time { get; set; }
        public List<object> excluded_category { get; set; }
    }

    public class __invalid_type__0
    {
        public int minLevel { get; set; }
        public int minSalesSum { get; set; }
        public int minStanding { get; set; }
    }

    public class __invalid_type__1
    {
        public int minLevel { get; set; }
        public int minSalesSum { get; set; }
        public double minStanding { get; set; }
    }

    public class __invalid_type__2
    {
        public int minLevel { get; set; }
        public int minSalesSum { get; set; }
        public double minStanding { get; set; }
    }

    public class __invalid_type__3
    {
        public int minLevel { get; set; }
        public int minSalesSum { get; set; }
        public double minStanding { get; set; }
    }

    public class LoyaltyLevels
    {
        public __invalid_type__0 __invalid_name__0 { get; set; }
        public __invalid_type__1 __invalid_name__1 { get; set; }
        public __invalid_type__2 __invalid_name__2 { get; set; }
        public __invalid_type__3 __invalid_name__3 { get; set; }
    }

    public class Loyalty
    {
        public int currentLevel { get; set; }
        public double currentStanding { get; set; }
        public int currentSalesSum { get; set; }
        public LoyaltyLevels loyaltyLevels { get; set; }
    }

    public class TraderDetails
    {
        public string _id { get; set; }
        public bool working { get; set; }
        public bool customization_seller { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string nickname { get; set; }
        public string location { get; set; }
        public string avatar { get; set; }
        public int balance_rub { get; set; }
        public int balance_dol { get; set; }
        public int balance_eur { get; set; }
        public bool display { get; set; }
        public int discount { get; set; }
        public int discount_end { get; set; }
        public bool buyer_up { get; set; }
        public string currency { get; set; }
        public int supply_next_time { get; set; }
        public Repair repair { get; set; }
        public Insurance insurance { get; set; }
        public int gridHeight { get; set; }
        public Loyalty loyalty { get; set; }
        public List<object> sell_category { get; set; }
    }

    public class TradersListResponse
    {
        public int err { get; set; }
        public string errmsg { get; set; }
        public List<TraderDetails> data { get; set; }
    }
}

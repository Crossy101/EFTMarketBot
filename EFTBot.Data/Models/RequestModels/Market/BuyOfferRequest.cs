using System.Collections.Generic;
using Newtonsoft.Json;

namespace EFTBot.Data.Models.RequestModels.Market
{
    public class BuyOfferRequest
    {
        public List<BuyOfferAction> data { get; set; }
        public int tm { get; set; } = 2;

        public BuyOfferRequest(List<BuyOfferPurchase> itemsToPurchase)
        {
            data = new List<BuyOfferAction>();
            data.Add(new BuyOfferAction(itemsToPurchase));
        }
    }

    public class BuyOfferAction
    {
        public string Action { get; set; } = "RagFairBuyOffer";

        public List<BuyOfferPurchase> offers { get; set; }
        public BuyOfferAction(List<BuyOfferPurchase> itemsToPurchase)
        {
            offers = new List<BuyOfferPurchase>();

            foreach (BuyOfferPurchase item in itemsToPurchase)
            {
                offers.Add(item);
            }
        }
    }

    public class BuyOfferPurchase
    {
        public string id { get; set; }
        public int count { get; set; }
        public List<ItemToSwap> items { get; set; }

        [JsonIgnore]
        public long ExpectedProfit { get; set; }

        [JsonIgnore]
        public int TotalIndividualItems { get; set; }

        [JsonIgnore]
        public Offer Offer { get; set; }

        public BuyOfferPurchase(string id, int count, List<ItemToSwap> itemToSwap)
        {
            this.id = id;
            this.count = count;
            items = itemToSwap;
        }
    }

    public class ItemToSwap
    {
        public string id { get; set; }
        public long count { get; set; }
    }
}

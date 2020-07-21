using System;
using System.Collections.Generic;
using EFTBot.Models.EFT.Enums;

#nullable enable

namespace EFTBot.Data.Models.RequestModels.Market
{
    public class SearchResponse
    {
        public APIErrorCodes err { get; set; }

        public string? errmsg { get; set; }
        public SearchResponseData data { get; set; }
    }

    public class SearchResponseData
    {
        public List<Offer> offers { get; set; }
        public int offersCount { get; set; }
        public string selectedCatergory { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public int memberType { get; set; }
        public string nickname { get; set; }
        public float rating { get; set; }
        public bool isRatingGrowing { get; set; }
        public object? avatar { get; set; }
    }

    public class _Key
    {
        public int NumberOfUsages { get; set; }
    }

    public class Upd
    {
        public _Key Key { get; set; }
        public Int64 StackObjectsCount { get; set; }
    }

    public class Item
    {
        public string _id { get; set; }
        public string _tpl { get; set; }
        public Upd upd { get; set; }
    }

    public class Requirement
    {
        public Int64 count { get; set; }
        public string _tpl { get; set; }
    }

    public class Offer
    {
        public string _id { get; set; }
        public string intId { get; set; }
        public User user { get; set; }
        public string root { get; set; }
        public List<Item> items { get; set; }
        public int itemsCost { get; set; }
        public List<Requirement> requirements { get; set; }
        public Int64 requirementsCost { get; set; }
        public Int64 summaryCost { get; set; }
        public bool sellInOnePiece { get; set; }
        public Int64 startTime { get; set; }
        public Int64 endTime { get; set; }
        public int loyaltyLevel { get; set; }
    }
}

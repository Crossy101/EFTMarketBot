using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTBot.Models.EFT.Enums
{
    public enum APIErrorCodes : int
    {
        Ok = 0,
        NotAuthorized = 201,
        InvalidUserID = 205,
        BadLogin = 206,
        InvalidParameters = 207,
        TwoFactorRequired = 209,
        BadTwoFactor = 211,
        CaptchaRequired = 214,
        InvalidBarterItems = 228,
        RateLimited = 230,
        WrongMajorVersion = 232,
        Maintenance  = 263,
        BackendError = 1000,
        MaxOfferCount = 1501,
        InsufficientTaxFunds = 1502,
        OfferNotFound = 1507,
        BadLoyaltyLevel = 1510,
        OfferNotAvailableYet = 1512,
        TransactionError = 1514
    }
}

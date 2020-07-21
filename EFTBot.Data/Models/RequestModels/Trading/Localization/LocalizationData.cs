using System.Collections.Generic;
using Newtonsoft.Json;

namespace EFTBot.Models.EFT.RequestModels.Trading.Localization
{

    public partial class LocalizationData : WebResponse
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("crc")]
        public long Crc { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("interface")]
        public Dictionary<string, string> Interface { get; set; }

        [JsonProperty("enum")]
        public object[] Enum { get; set; }

        [JsonProperty("error")]
        public Error Error { get; set; }

        [JsonProperty("mail")]
        public Mail Mail { get; set; }

        [JsonProperty("quest")]
        public Quest Quest { get; set; }

        [JsonProperty("preset")]
        public Dictionary<string, Preset> Preset { get; set; }

        [JsonProperty("handbook")]
        public Dictionary<string, string> Handbook { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("templates")]
        public Dictionary<string, Template> Templates { get; set; }

        [JsonProperty("locations")]
        public Locations Locations { get; set; }

        [JsonProperty("banners")]
        public Banners Banners { get; set; }

        [JsonProperty("trading")]
        public Dictionary<string, Trading> Trading { get; set; }
    }

    public partial class Banners
    {
        [JsonProperty("5464e0404bdc2d2a708b4567")]
        public The5464_E0404Bdc2D2A708B4567 The5464E0404Bdc2D2A708B4567 { get; set; }

        [JsonProperty("5464e0454bdc2d06708b4567")]
        public The5464_E0404Bdc2D2A708B4567 The5464E0454Bdc2D06708B4567 { get; set; }

        [JsonProperty("5803a58524597710ca36fcb2")]
        public The5464_E0404Bdc2D2A708B4567 The5803A58524597710Ca36Fcb2 { get; set; }

        [JsonProperty("5805f617245977100b2c1f41")]
        public The5464_E0404Bdc2D2A708B4567 The5805F617245977100B2C1F41 { get; set; }

        [JsonProperty("5807be8924597742c603fa19")]
        public The5464_E0404Bdc2D2A708B4567 The5807Be8924597742C603Fa19 { get; set; }

        [JsonProperty("5807bfe124597742a92e0a4c")]
        public The5464_E0404Bdc2D2A708B4567 The5807Bfe124597742A92E0A4C { get; set; }

        [JsonProperty("5807c3f124597746bf2db2ce")]
        public The5464_E0404Bdc2D2A708B4567 The5807C3F124597746Bf2Db2Ce { get; set; }

        [JsonProperty("5c1b857086f77465f465faa4")]
        public The5_C1B857086F77465F465Faa4 The5C1B857086F77465F465Faa4 { get; set; }
    }

    public partial class The5464_E0404Bdc2D2A708B4567
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class The5_C1B857086F77465F465Faa4
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ShortName")]
        public string ShortName { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public partial class Error
    {
        [JsonProperty("Offer not found")]
        public string OfferNotFound { get; set; }

        [JsonProperty("Unknown error")]
        public string UnknownError { get; set; }

        [JsonProperty("The item is already sold")]
        public string TheItemIsAlreadySold { get; set; }

        [JsonProperty("Attempted transaction with items missing from the stash")]
        public string AttemptedTransactionWithItemsMissingFromTheStash { get; set; }

        [JsonProperty("The trader is out of stock")]
        public string TheTraderIsOutOfStock { get; set; }

        [JsonProperty("The trader is out of cash")]
        public string TheTraderIsOutOfCash { get; set; }

        [JsonProperty("Not enough space in stash")]
        public string NotEnoughSpaceInStash { get; set; }

        [JsonProperty("Trader does not deal in this type of items")]
        public string TraderDoesNotDealInThisTypeOfItems { get; set; }

        [JsonProperty("Transaction error. The cost of goods has already changed.")]
        public string TransactionErrorTheCostOfGoodsHasAlreadyChanged { get; set; }

        [JsonProperty("You have already bought the maximum amount of this item in the current restock")]
        public string YouHaveAlreadyBoughtTheMaximumAmountOfThisItemInTheCurrentRestock { get; set; }

        [JsonProperty("Bad user loyalty level")]
        public string BadUserLoyaltyLevel { get; set; }

        [JsonProperty("230 - MAX LOGIN COUNT")]
        public string The230MaxLoginCount { get; set; }

        [JsonProperty("1514 - Transaction error. The cost of goods has already changed.")]
        public string The1514TransactionErrorTheCostOfGoodsHasAlreadyChanged { get; set; }

        [JsonProperty("201 - Client not authorized or not selected game profile")]
        public string The201ClientNotAuthorizedOrNotSelectedGameProfile { get; set; }

        [JsonProperty("Backend error: Unknown Error")]
        public string BackendErrorUnknownError { get; set; }

        [JsonProperty("BackendErrorHeader")]
        public string BackendErrorHeader { get; set; }

        [JsonProperty("BackendErrorMessage")]
        public string BackendErrorMessage { get; set; }
    }

    public partial class Locations
    {
        [JsonProperty("5704e47ed2720bb35b8b4568")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5704E47Ed2720Bb35B8B4568 { get; set; }

        [JsonProperty("5704e4dad2720bb55b8b4567")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5704E4Dad2720Bb55B8B4567 { get; set; }

        [JsonProperty("55f2d3fd4bdc2d5f408b4567")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The55F2D3Fd4Bdc2D5F408B4567 { get; set; }

        [JsonProperty("56f40101d2720b2a4d8b45d6")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The56F40101D2720B2A4D8B45D6 { get; set; }

        [JsonProperty("5704e5fad2720bc05b8b4567")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5704E5Fad2720Bc05B8B4567 { get; set; }

        [JsonProperty("5704e64ad2720bb55b8b456e")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5704E64Ad2720Bb55B8B456E { get; set; }

        [JsonProperty("5704e3c2d2720bac5b8b4567")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5704E3C2D2720Bac5B8B4567 { get; set; }

        [JsonProperty("5714dc342459777137212e0b")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5714Dc342459777137212E0B { get; set; }

        [JsonProperty("56db0b3bd2720bb0678b4567")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The56Db0B3Bd2720Bb0678B4567 { get; set; }

        [JsonProperty("5714dbc024597771384a510d")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5714Dbc024597771384A510D { get; set; }

        [JsonProperty("5704e554d2720bac5b8b456e")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5704E554D2720Bac5B8B456E { get; set; }

        [JsonProperty("5704e5a4d2720bb45b8b4567")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5704E5A4D2720Bb45B8B4567 { get; set; }

        [JsonProperty("599319c986f7740dca3070a6")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The599319C986F7740Dca3070A6 { get; set; }

        [JsonProperty("59fc81d786f774390775787e")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The59Fc81D786F774390775787E { get; set; }

        [JsonProperty("5714dc692459777137212e12")]
        public The55_F2D3Fd4Bdc2D5F408B4567 The5714Dc692459777137212E12 { get; set; }

        [JsonProperty("5b0fc42d86f7744a585f9105")]
        public The5_C1B857086F77465F465Faa4 The5B0Fc42D86F7744A585F9105 { get; set; }
    }

    public partial class The55_F2D3Fd4Bdc2D5F408B4567
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public partial class Mail
    {
        [JsonProperty("5a8fd75188a45036844e0ae6")]
        public string The5A8Fd75188A45036844E0Ae6 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae8")]
        public string The5A8Fd75188A45036844E0Ae8 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b09")]
        public string The5A8Fd75188A45036844E0B09 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae7")]
        public string The5A8Fd75188A45036844E0Ae7 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af7")]
        public string The5A8Fd75188A45036844E0Af7 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0afd")]
        public string The5A8Fd75188A45036844E0Afd { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af1")]
        public string The5A8Fd75188A45036844E0Af1 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b01")]
        public string The5A8Fd75188A45036844E0B01 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b06")]
        public string The5A8Fd75188A45036844E0B06 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b03")]
        public string The5A8Fd75188A45036844E0B03 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b08")]
        public string The5A8Fd75188A45036844E0B08 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af9")]
        public string The5A8Fd75188A45036844E0Af9 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0afb")]
        public string The5A8Fd75188A45036844E0Afb { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b05")]
        public string The5A8Fd75188A45036844E0B05 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af3")]
        public string The5A8Fd75188A45036844E0Af3 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af4")]
        public string The5A8Fd75188A45036844E0Af4 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0aff")]
        public string The5A8Fd75188A45036844E0Aff { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b0e")]
        public string The5A8Fd75188A45036844E0B0E { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b0c")]
        public string The5A8Fd75188A45036844E0B0C { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ad8")]
        public string The5A8Fd75188A45036844E0Ad8 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0add")]
        public string The5A8Fd75188A45036844E0Add { get; set; }

        [JsonProperty("5a8fd75188a45036844e0aef")]
        public string The5A8Fd75188A45036844E0Aef { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ad9")]
        public string The5A8Fd75188A45036844E0Ad9 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0aed")]
        public string The5A8Fd75188A45036844E0Aed { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ad7")]
        public string The5A8Fd75188A45036844E0Ad7 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae1")]
        public string The5A8Fd75188A45036844E0Ae1 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0adf")]
        public string The5A8Fd75188A45036844E0Adf { get; set; }

        [JsonProperty("5a8fd75188a45036844e0adc")]
        public string The5A8Fd75188A45036844E0Adc { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ada")]
        public string The5A8Fd75188A45036844E0Ada { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae4")]
        public string The5A8Fd75188A45036844E0Ae4 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ade")]
        public string The5A8Fd75188A45036844E0Ade { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae5")]
        public string The5A8Fd75188A45036844E0Ae5 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af0")]
        public string The5A8Fd75188A45036844E0Af0 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0aea")]
        public string The5A8Fd75188A45036844E0Aea { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae0")]
        public string The5A8Fd75188A45036844E0Ae0 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0aec")]
        public string The5A8Fd75188A45036844E0Aec { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae3")]
        public string The5A8Fd75188A45036844E0Ae3 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae2")]
        public string The5A8Fd75188A45036844E0Ae2 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0afa")]
        public string The5A8Fd75188A45036844E0Afa { get; set; }

        [JsonProperty("5a8fd75188a45036844e0adb")]
        public string The5A8Fd75188A45036844E0Adb { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af6")]
        public string The5A8Fd75188A45036844E0Af6 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af2")]
        public string The5A8Fd75188A45036844E0Af2 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b02")]
        public string The5A8Fd75188A45036844E0B02 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0aee")]
        public string The5A8Fd75188A45036844E0Aee { get; set; }

        [JsonProperty("5a8fd75188a45036844e0afe")]
        public string The5A8Fd75188A45036844E0Afe { get; set; }

        [JsonProperty("5a8fd75188a45036844e0ae9")]
        public string The5A8Fd75188A45036844E0Ae9 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0afc")]
        public string The5A8Fd75188A45036844E0Afc { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b0a")]
        public string The5A8Fd75188A45036844E0B0A { get; set; }

        [JsonProperty("5a8fd75188a45036844e0aeb")]
        public string The5A8Fd75188A45036844E0Aeb { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af5")]
        public string The5A8Fd75188A45036844E0Af5 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b0b")]
        public string The5A8Fd75188A45036844E0B0B { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b07")]
        public string The5A8Fd75188A45036844E0B07 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0af8")]
        public string The5A8Fd75188A45036844E0Af8 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b00")]
        public string The5A8Fd75188A45036844E0B00 { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b0d")]
        public string The5A8Fd75188A45036844E0B0D { get; set; }

        [JsonProperty("5a8fd75188a45036844e0b04")]
        public string The5A8Fd75188A45036844E0B04 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f566")]
        public string The5Ab0F32686F7745Dd409F566 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f599")]
        public string The5Ab0F32686F7745Dd409F599 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f562")]
        public string The5Ab0F32686F7745Dd409F562 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f568")]
        public string The5Ab0F32686F7745Dd409F568 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f563")]
        public string The5Ab0F32686F7745Dd409F563 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f564")]
        public string The5Ab0F32686F7745Dd409F564 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f579")]
        public string The5Ab0F32686F7745Dd409F579 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5b0")]
        public string The5Ab0F32686F7745Dd409F5B0 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f56f")]
        public string The5Ab0F32686F7745Dd409F56F { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f569")]
        public string The5Ab0F32686F7745Dd409F569 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f56b")]
        public string The5Ab0F32686F7745Dd409F56B { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f56d")]
        public string The5Ab0F32686F7745Dd409F56D { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f570")]
        public string The5Ab0F32686F7745Dd409F570 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f571")]
        public string The5Ab0F32686F7745Dd409F571 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f572")]
        public string The5Ab0F32686F7745Dd409F572 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f565")]
        public string The5Ab0F32686F7745Dd409F565 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f56c")]
        public string The5Ab0F32686F7745Dd409F56C { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f582")]
        public string The5Ab0F32686F7745Dd409F582 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f576")]
        public string The5Ab0F32686F7745Dd409F576 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f577")]
        public string The5Ab0F32686F7745Dd409F577 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f56a")]
        public string The5Ab0F32686F7745Dd409F56A { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f57e")]
        public string The5Ab0F32686F7745Dd409F57E { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f567")]
        public string The5Ab0F32686F7745Dd409F567 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f57a")]
        public string The5Ab0F32686F7745Dd409F57A { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f575")]
        public string The5Ab0F32686F7745Dd409F575 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f578")]
        public string The5Ab0F32686F7745Dd409F578 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f573")]
        public string The5Ab0F32686F7745Dd409F573 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f581")]
        public string The5Ab0F32686F7745Dd409F581 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f57b")]
        public string The5Ab0F32686F7745Dd409F57B { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f56e")]
        public string The5Ab0F32686F7745Dd409F56E { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f57c")]
        public string The5Ab0F32686F7745Dd409F57C { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f588")]
        public string The5Ab0F32686F7745Dd409F588 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f57f")]
        public string The5Ab0F32686F7745Dd409F57F { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f574")]
        public string The5Ab0F32686F7745Dd409F574 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f57d")]
        public string The5Ab0F32686F7745Dd409F57D { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f58d")]
        public string The5Ab0F32686F7745Dd409F58D { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f580")]
        public string The5Ab0F32686F7745Dd409F580 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f587")]
        public string The5Ab0F32686F7745Dd409F587 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f58a")]
        public string The5Ab0F32686F7745Dd409F58A { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f585")]
        public string The5Ab0F32686F7745Dd409F585 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f594")]
        public string The5Ab0F32686F7745Dd409F594 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f583")]
        public string The5Ab0F32686F7745Dd409F583 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f58c")]
        public string The5Ab0F32686F7745Dd409F58C { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f589")]
        public string The5Ab0F32686F7745Dd409F589 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f584")]
        public string The5Ab0F32686F7745Dd409F584 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f586")]
        public string The5Ab0F32686F7745Dd409F586 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f58f")]
        public string The5Ab0F32686F7745Dd409F58F { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f59e")]
        public string The5Ab0F32686F7745Dd409F59E { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f59d")]
        public string The5Ab0F32686F7745Dd409F59D { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f595")]
        public string The5Ab0F32686F7745Dd409F595 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f58b")]
        public string The5Ab0F32686F7745Dd409F58B { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f58e")]
        public string The5Ab0F32686F7745Dd409F58E { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f590")]
        public string The5Ab0F32686F7745Dd409F590 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a1")]
        public string The5Ab0F32686F7745Dd409F5A1 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f591")]
        public string The5Ab0F32686F7745Dd409F591 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f592")]
        public string The5Ab0F32686F7745Dd409F592 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a2")]
        public string The5Ab0F32686F7745Dd409F5A2 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a9")]
        public string The5Ab0F32686F7745Dd409F5A9 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f593")]
        public string The5Ab0F32686F7745Dd409F593 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f59a")]
        public string The5Ab0F32686F7745Dd409F59A { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f59b")]
        public string The5Ab0F32686F7745Dd409F59B { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f59c")]
        public string The5Ab0F32686F7745Dd409F59C { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a3")]
        public string The5Ab0F32686F7745Dd409F5A3 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a7")]
        public string The5Ab0F32686F7745Dd409F5A7 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a0")]
        public string The5Ab0F32686F7745Dd409F5A0 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5ad")]
        public string The5Ab0F32686F7745Dd409F5Ad { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5b1")]
        public string The5Ab0F32686F7745Dd409F5B1 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5b2")]
        public string The5Ab0F32686F7745Dd409F5B2 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a4")]
        public string The5Ab0F32686F7745Dd409F5A4 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f59f")]
        public string The5Ab0F32686F7745Dd409F59F { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5ac")]
        public string The5Ab0F32686F7745Dd409F5Ac { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a8")]
        public string The5Ab0F32686F7745Dd409F5A8 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5ab")]
        public string The5Ab0F32686F7745Dd409F5Ab { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5af")]
        public string The5Ab0F32686F7745Dd409F5Af { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a5")]
        public string The5Ab0F32686F7745Dd409F5A5 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5a6")]
        public string The5Ab0F32686F7745Dd409F5A6 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5aa")]
        public string The5Ab0F32686F7745Dd409F5Aa { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5b7")]
        public string The5Ab0F32686F7745Dd409F5B7 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5ae")]
        public string The5Ab0F32686F7745Dd409F5Ae { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5b3")]
        public string The5Ab0F32686F7745Dd409F5B3 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5b5")]
        public string The5Ab0F32686F7745Dd409F5B5 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5b4")]
        public string The5Ab0F32686F7745Dd409F5B4 { get; set; }

        [JsonProperty("5ab0f32686f7745dd409f5b6")]
        public string The5Ab0F32686F7745Dd409F5B6 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da90")]
        public string The5Abe61A886F7746Ad512Da90 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da6f")]
        public string The5Abe61A886F7746Ad512Da6F { get; set; }

        [JsonProperty("5abe61a786f7746ad512da47")]
        public string The5Abe61A786F7746Ad512Da47 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da49")]
        public string The5Abe61A786F7746Ad512Da49 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da61")]
        public string The5Abe61A786F7746Ad512Da61 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da48")]
        public string The5Abe61A786F7746Ad512Da48 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da50")]
        public string The5Abe61A786F7746Ad512Da50 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da45")]
        public string The5Abe61A786F7746Ad512Da45 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da46")]
        public string The5Abe61A786F7746Ad512Da46 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da87")]
        public string The5Abe61A886F7746Ad512Da87 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da4d")]
        public string The5Abe61A786F7746Ad512Da4D { get; set; }

        [JsonProperty("5abe61a886f7746ad512da98")]
        public string The5Abe61A886F7746Ad512Da98 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da4a")]
        public string The5Abe61A786F7746Ad512Da4A { get; set; }

        [JsonProperty("5abe61a786f7746ad512da4f")]
        public string The5Abe61A786F7746Ad512Da4F { get; set; }

        [JsonProperty("5abe61a786f7746ad512da51")]
        public string The5Abe61A786F7746Ad512Da51 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da4c")]
        public string The5Abe61A786F7746Ad512Da4C { get; set; }

        [JsonProperty("5abe61a786f7746ad512da52")]
        public string The5Abe61A786F7746Ad512Da52 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da4b")]
        public string The5Abe61A786F7746Ad512Da4B { get; set; }

        [JsonProperty("5abe61a786f7746ad512da56")]
        public string The5Abe61A786F7746Ad512Da56 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da4e")]
        public string The5Abe61A786F7746Ad512Da4E { get; set; }

        [JsonProperty("5abe61a786f7746ad512da54")]
        public string The5Abe61A786F7746Ad512Da54 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da55")]
        public string The5Abe61A786F7746Ad512Da55 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da5e")]
        public string The5Abe61A786F7746Ad512Da5E { get; set; }

        [JsonProperty("5abe61a786f7746ad512da57")]
        public string The5Abe61A786F7746Ad512Da57 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da5b")]
        public string The5Abe61A786F7746Ad512Da5B { get; set; }

        [JsonProperty("5abe61a786f7746ad512da59")]
        public string The5Abe61A786F7746Ad512Da59 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da5f")]
        public string The5Abe61A786F7746Ad512Da5F { get; set; }

        [JsonProperty("5abe61a786f7746ad512da53")]
        public string The5Abe61A786F7746Ad512Da53 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da5c")]
        public string The5Abe61A786F7746Ad512Da5C { get; set; }

        [JsonProperty("5abe61a786f7746ad512da58")]
        public string The5Abe61A786F7746Ad512Da58 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da5a")]
        public string The5Abe61A786F7746Ad512Da5A { get; set; }

        [JsonProperty("5abe61a886f7746ad512da67")]
        public string The5Abe61A886F7746Ad512Da67 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da65")]
        public string The5Abe61A886F7746Ad512Da65 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da60")]
        public string The5Abe61A786F7746Ad512Da60 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da66")]
        public string The5Abe61A886F7746Ad512Da66 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da6b")]
        public string The5Abe61A886F7746Ad512Da6B { get; set; }

        [JsonProperty("5abe61a786f7746ad512da5d")]
        public string The5Abe61A786F7746Ad512Da5D { get; set; }

        [JsonProperty("5abe61a886f7746ad512da68")]
        public string The5Abe61A886F7746Ad512Da68 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da63")]
        public string The5Abe61A786F7746Ad512Da63 { get; set; }

        [JsonProperty("5abe61a786f7746ad512da62")]
        public string The5Abe61A786F7746Ad512Da62 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da69")]
        public string The5Abe61A886F7746Ad512Da69 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da6a")]
        public string The5Abe61A886F7746Ad512Da6A { get; set; }

        [JsonProperty("5abe61a786f7746ad512da64")]
        public string The5Abe61A786F7746Ad512Da64 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da6c")]
        public string The5Abe61A886F7746Ad512Da6C { get; set; }

        [JsonProperty("5abe61a886f7746ad512da6d")]
        public string The5Abe61A886F7746Ad512Da6D { get; set; }

        [JsonProperty("5abe61a886f7746ad512da77")]
        public string The5Abe61A886F7746Ad512Da77 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da71")]
        public string The5Abe61A886F7746Ad512Da71 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da72")]
        public string The5Abe61A886F7746Ad512Da72 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da73")]
        public string The5Abe61A886F7746Ad512Da73 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da7a")]
        public string The5Abe61A886F7746Ad512Da7A { get; set; }

        [JsonProperty("5abe61a886f7746ad512da70")]
        public string The5Abe61A886F7746Ad512Da70 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da7b")]
        public string The5Abe61A886F7746Ad512Da7B { get; set; }

        [JsonProperty("5ac242f286f774138762ee00")]
        public string The5Ac242F286F774138762Ee00 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da78")]
        public string The5Abe61A886F7746Ad512Da78 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da7c")]
        public string The5Abe61A886F7746Ad512Da7C { get; set; }

        [JsonProperty("5abe61a886f7746ad512da79")]
        public string The5Abe61A886F7746Ad512Da79 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da74")]
        public string The5Abe61A886F7746Ad512Da74 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da75")]
        public string The5Abe61A886F7746Ad512Da75 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da84")]
        public string The5Abe61A886F7746Ad512Da84 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da81")]
        public string The5Abe61A886F7746Ad512Da81 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da76")]
        public string The5Abe61A886F7746Ad512Da76 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da7e")]
        public string The5Abe61A886F7746Ad512Da7E { get; set; }

        [JsonProperty("5abe61a886f7746ad512da80")]
        public string The5Abe61A886F7746Ad512Da80 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da86")]
        public string The5Abe61A886F7746Ad512Da86 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da7d")]
        public string The5Abe61A886F7746Ad512Da7D { get; set; }

        [JsonProperty("5abe61a886f7746ad512da8b")]
        public string The5Abe61A886F7746Ad512Da8B { get; set; }

        [JsonProperty("5abe61a886f7746ad512da91")]
        public string The5Abe61A886F7746Ad512Da91 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da82")]
        public string The5Abe61A886F7746Ad512Da82 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da85")]
        public string The5Abe61A886F7746Ad512Da85 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da83")]
        public string The5Abe61A886F7746Ad512Da83 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da88")]
        public string The5Abe61A886F7746Ad512Da88 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da7f")]
        public string The5Abe61A886F7746Ad512Da7F { get; set; }

        [JsonProperty("5abe61a886f7746ad512da93")]
        public string The5Abe61A886F7746Ad512Da93 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da94")]
        public string The5Abe61A886F7746Ad512Da94 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da92")]
        public string The5Abe61A886F7746Ad512Da92 { get; set; }

        [JsonProperty("5ac2430486f77412450b42c4")]
        public string The5Ac2430486F77412450B42C4 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da8d")]
        public string The5Abe61A886F7746Ad512Da8D { get; set; }

        [JsonProperty("5ac2430486f77412450b42c1")]
        public string The5Ac2430486F77412450B42C1 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da99")]
        public string The5Abe61A886F7746Ad512Da99 { get; set; }

        [JsonProperty("5ac242f286f774138762ee03")]
        public string The5Ac242F286F774138762Ee03 { get; set; }

        [JsonProperty("5ac2438186f77412450b42c5")]
        public string The5Ac2438186F77412450B42C5 { get; set; }

        [JsonProperty("5abe61a886f7746ad512da95")]
        public string The5Abe61A886F7746Ad512Da95 { get; set; }

        [JsonProperty("5ac2437986f774124836841b")]
        public string The5Ac2437986F774124836841B { get; set; }

        [JsonProperty("5ac2438186f77412450b42c8")]
        public string The5Ac2438186F77412450B42C8 { get; set; }

        [JsonProperty("5ac244f386f7741356335af6")]
        public string The5Ac244F386F7741356335Af6 { get; set; }

        [JsonProperty("5ac244ce86f7741356335aed")]
        public string The5Ac244Ce86F7741356335Aed { get; set; }

        [JsonProperty("5ac2437986f774124836841e")]
        public string The5Ac2437986F774124836841E { get; set; }

        [JsonProperty("5ac3463486f7741d6118b985")]
        public string The5Ac3463486F7741D6118B985 { get; set; }

        [JsonProperty("5ac345e886f7741d632339f0")]
        public string The5Ac345E886F7741D632339F0 { get; set; }

        [JsonProperty("5ac244ce86f7741356335af0")]
        public string The5Ac244Ce86F7741356335Af0 { get; set; }

        [JsonProperty("5ac244f386f7741356335af3")]
        public string The5Ac244F386F7741356335Af3 { get; set; }

        [JsonProperty("5ac3461486f7741d6224abb8")]
        public string The5Ac3461486F7741D6224Abb8 { get; set; }

        [JsonProperty("5ac345e886f7741d632339f3")]
        public string The5Ac345E886F7741D632339F3 { get; set; }

        [JsonProperty("5ac3461486f7741d6224abbb")]
        public string The5Ac3461486F7741D6224Abbb { get; set; }

        [JsonProperty("5ac3479686f774288030819b")]
        public string The5Ac3479686F774288030819B { get; set; }

        [JsonProperty("5ac3468b86f7741d6118b98f")]
        public string The5Ac3468B86F7741D6118B98F { get; set; }

        [JsonProperty("5ac346ba86f7741d6118b996")]
        public string The5Ac346Ba86F7741D6118B996 { get; set; }

        [JsonProperty("5ac3465286f7741d6118b98d")]
        public string The5Ac3465286F7741D6118B98D { get; set; }

        [JsonProperty("5ac3463486f7741d6118b988")]
        public string The5Ac3463486F7741D6118B988 { get; set; }

        [JsonProperty("5ac3465286f7741d6118b98a")]
        public string The5Ac3465286F7741D6118B98A { get; set; }

        [JsonProperty("5ac3468b86f7741d6118b992")]
        public string The5Ac3468B86F7741D6118B992 { get; set; }

        [JsonProperty("5ac346d786f7741d645149f2")]
        public string The5Ac346D786F7741D645149F2 { get; set; }

        [JsonProperty("5ac346d786f7741d645149ef")]
        public string The5Ac346D786F7741D645149Ef { get; set; }

        [JsonProperty("5ac346ba86f7741d6118b999")]
        public string The5Ac346Ba86F7741D6118B999 { get; set; }

        [JsonProperty("5ac3475b86f7741d6224abd5")]
        public string The5Ac3475B86F7741D6224Abd5 { get; set; }

        [JsonProperty("5ac3477a86f7742880308194")]
        public string The5Ac3477A86F7742880308194 { get; set; }

        [JsonProperty("5ac346ee86f7741d6224abca")]
        public string The5Ac346Ee86F7741D6224Abca { get; set; }

        [JsonProperty("5ac3475b86f7741d6224abd8")]
        public string The5Ac3475B86F7741D6224Abd8 { get; set; }

        [JsonProperty("5ac3479686f774288030819e")]
        public string The5Ac3479686F774288030819E { get; set; }

        [JsonProperty("5ac346ee86f7741d6224abcd")]
        public string The5Ac346Ee86F7741D6224Abcd { get; set; }

        [JsonProperty("5ac3477a86f7742880308197")]
        public string The5Ac3477A86F7742880308197 { get; set; }

        [JsonProperty("5ae327d286f7745d3a7704be")]
        public string The5Ae327D286F7745D3A7704Be { get; set; }

        [JsonProperty("5ae44bfe86f7744d733e560c")]
        public string The5Ae44Bfe86F7744D733E560C { get; set; }

        [JsonProperty("5ae326bc86f7742a41359305")]
        public string The5Ae326Bc86F7742A41359305 { get; set; }

        [JsonProperty("5ae44bfe86f7744d733e560f")]
        public string The5Ae44Bfe86F7744D733E560F { get; set; }

        [JsonProperty("5ae44dd386f7744f1a7eb65d")]
        public string The5Ae44Dd386F7744F1A7Eb65D { get; set; }

        [JsonProperty("5ae3272086f77444fd36f5e3")]
        public string The5Ae3272086F77444Fd36F5E3 { get; set; }

        [JsonProperty("5ae327d286f7745d3a7704bb")]
        public string The5Ae327D286F7745D3A7704Bb { get; set; }

        [JsonProperty("5ae3277d86f7745b4246b391")]
        public string The5Ae3277D86F7745B4246B391 { get; set; }

        [JsonProperty("5ae326bc86f7742a41359302")]
        public string The5Ae326Bc86F7742A41359302 { get; set; }

        [JsonProperty("5ae3272086f77444fd36f5e6")]
        public string The5Ae3272086F77444Fd36F5E6 { get; set; }

        [JsonProperty("5ae3280a86f77444fc552709")]
        public string The5Ae3280A86F77444Fc552709 { get; set; }

        [JsonProperty("5ae44dd386f7744f1a7eb660")]
        public string The5Ae44Dd386F7744F1A7Eb660 { get; set; }

        [JsonProperty("5ae3277d86f7745b4246b38e")]
        public string The5Ae3277D86F7745B4246B38E { get; set; }

        [JsonProperty("5ae3280a86f77444fc552706")]
        public string The5Ae3280A86F77444Fc552706 { get; set; }

        [JsonProperty("5ae44ffe86f774149f15f4ec")]
        public string The5Ae44Ffe86F774149F15F4Ec { get; set; }

        [JsonProperty("5ae454ed86f774626b445ec0")]
        public string The5Ae454Ed86F774626B445Ec0 { get; set; }

        [JsonProperty("5ae44ffe86f774149f15f4e9")]
        public string The5Ae44Ffe86F774149F15F4E9 { get; set; }

        [JsonProperty("5ae454ed86f774626b445ec3")]
        public string The5Ae454Ed86F774626B445Ec3 { get; set; }

        [JsonProperty("5ae4525986f7741b747a048e")]
        public string The5Ae4525986F7741B747A048E { get; set; }

        [JsonProperty("5ae4536b86f7741b747a04ec")]
        public string The5Ae4536B86F7741B747A04Ec { get; set; }

        [JsonProperty("5ae9b1c986f7743a5736fc04")]
        public string The5Ae9B1C986F7743A5736Fc04 { get; set; }

        [JsonProperty("5ae4525986f7741b747a048b")]
        public string The5Ae4525986F7741B747A048B { get; set; }

        [JsonProperty("5ae4568186f7744a4c600479")]
        public string The5Ae4568186F7744A4C600479 { get; set; }

        [JsonProperty("5ae4536b86f7741b747a04e9")]
        public string The5Ae4536B86F7741B747A04E9 { get; set; }

        [JsonProperty("5ae4568186f7744a4c60047c")]
        public string The5Ae4568186F7744A4C60047C { get; set; }

        [JsonProperty("5ae9b57d86f77432c81e2fad")]
        public string The5Ae9B57D86F77432C81E2Fad { get; set; }

        [JsonProperty("5ae9b1c986f7743a5736fc07")]
        public string The5Ae9B1C986F7743A5736Fc07 { get; set; }

        [JsonProperty("5ae9ba1086f77415a869b403")]
        public string The5Ae9Ba1086F77415A869B403 { get; set; }

        [JsonProperty("5ae9bf2886f774703201f139")]
        public string The5Ae9Bf2886F774703201F139 { get; set; }

        [JsonProperty("5ae9b57d86f77432c81e2faa")]
        public string The5Ae9B57D86F77432C81E2Faa { get; set; }

        [JsonProperty("5ae9c05d86f77427153c7f9c")]
        public string The5Ae9C05D86F77427153C7F9C { get; set; }

        [JsonProperty("5ae9c32886f774703201f16a")]
        public string The5Ae9C32886F774703201F16A { get; set; }

        [JsonProperty("5ae9e06286f7741e755650a9")]
        public string The5Ae9E06286F7741E755650A9 { get; set; }

        [JsonProperty("5ae9ba1086f77415a869b400")]
        public string The5Ae9Ba1086F77415A869B400 { get; set; }

        [JsonProperty("5ae9bf2886f774703201f136")]
        public string The5Ae9Bf2886F774703201F136 { get; set; }

        [JsonProperty("5ae9c05d86f77427153c7f99")]
        public string The5Ae9C05D86F77427153C7F99 { get; set; }

        [JsonProperty("5ae9e4fc86f77443f2500fe1")]
        public string The5Ae9E4Fc86F77443F2500Fe1 { get; set; }

        [JsonProperty("5ae9c25086f77415a869b604")]
        public string The5Ae9C25086F77415A869B604 { get; set; }

        [JsonProperty("5ae9c25086f77415a869b601")]
        public string The5Ae9C25086F77415A869B601 { get; set; }

        [JsonProperty("5ae9c32886f774703201f167")]
        public string The5Ae9C32886F774703201F167 { get; set; }

        [JsonProperty("5ae9e06286f7741e755650a6")]
        public string The5Ae9E06286F7741E755650A6 { get; set; }

        [JsonProperty("5ae9e3f386f774346013b844")]
        public string The5Ae9E3F386F774346013B844 { get; set; }

        [JsonProperty("5ae9e4fc86f77443f2500fe4")]
        public string The5Ae9E4Fc86F77443F2500Fe4 { get; set; }

        [JsonProperty("5af5886186f774153d712bb6")]
        public long The5Af5886186F774153D712Bb6 { get; set; }

        [JsonProperty("5ae9e3f386f774346013b847")]
        public string The5Ae9E3F386F774346013B847 { get; set; }

        [JsonProperty("5af5886186f774153d712bb9")]
        public long The5Af5886186F774153D712Bb9 { get; set; }

        [JsonProperty("5af5886186f774153d712bb8")]
        public long The5Af5886186F774153D712Bb8 { get; set; }

        [JsonProperty("5af5886186f774153d712bb7")]
        public long The5Af5886186F774153D712Bb7 { get; set; }

        [JsonProperty("5b486ce586f7744882493785")]
        public string The5B486Ce586F7744882493785 { get; set; }

        [JsonProperty("5b486d8686f77450c05449c6")]
        public string The5B486D8686F77450C05449C6 { get; set; }

        [JsonProperty("5b486ce586f7744882493788")]
        public string The5B486Ce586F7744882493788 { get; set; }

        [JsonProperty("5b486c9386f7744a08514b18")]
        public string The5B486C9386F7744A08514B18 { get; set; }

        [JsonProperty("5b486d3e86f7743780259fd4")]
        public string The5B486D3E86F7743780259Fd4 { get; set; }

        [JsonProperty("5b486d0e86f7744f4b12d792")]
        public string The5B486D0E86F7744F4B12D792 { get; set; }

        [JsonProperty("5b486c9386f7744a08514b1b")]
        public string The5B486C9386F7744A08514B1B { get; set; }

        [JsonProperty("5b486d0e86f7744f4b12d78f")]
        public string The5B486D0E86F7744F4B12D78F { get; set; }

        [JsonProperty("5b486e6186f7744a08514b24")]
        public string The5B486E6186F7744A08514B24 { get; set; }

        [JsonProperty("5b486d3e86f7743780259fd1")]
        public string The5B486D3E86F7743780259Fd1 { get; set; }

        [JsonProperty("5b486ddf86f7744ba00f2237")]
        public string The5B486Ddf86F7744Ba00F2237 { get; set; }

        [JsonProperty("5b486e6186f7744a08514b27")]
        public string The5B486E6186F7744A08514B27 { get; set; }

        [JsonProperty("5b486d8686f77450c05449c9")]
        public string The5B486D8686F77450C05449C9 { get; set; }

        [JsonProperty("5b486e2a86f7744a08514b1c")]
        public string The5B486E2A86F7744A08514B1C { get; set; }

        [JsonProperty("5b486ddf86f7744ba00f2234")]
        public string The5B486Ddf86F7744Ba00F2234 { get; set; }

        [JsonProperty("5b486e8e86f77448824937b0")]
        public string The5B486E8E86F77448824937B0 { get; set; }

        [JsonProperty("5b48700686f7744f4b12d7ef")]
        public string The5B48700686F7744F4B12D7Ef { get; set; }

        [JsonProperty("5b486e2a86f7744a08514b1f")]
        public string The5B486E2A86F7744A08514B1F { get; set; }

        [JsonProperty("5b486e8e86f77448824937ad")]
        public string The5B486E8E86F77448824937Ad { get; set; }

        [JsonProperty("5b48704286f7744a14343905")]
        public string The5B48704286F7744A14343905 { get; set; }

        [JsonProperty("5b486fbf86f77450c0544c19")]
        public string The5B486Fbf86F77450C0544C19 { get; set; }

        [JsonProperty("5b486fbf86f77450c0544c16")]
        public string The5B486Fbf86F77450C0544C16 { get; set; }

        [JsonProperty("5b48704286f7744a14343908")]
        public string The5B48704286F7744A14343908 { get; set; }

        [JsonProperty("5b4870d386f7743780259ff3")]
        public string The5B4870D386F7743780259Ff3 { get; set; }

        [JsonProperty("5b48700686f7744f4b12d7f2")]
        public string The5B48700686F7744F4B12D7F2 { get; set; }

        [JsonProperty("5b4870a386f7744d06237e0a")]
        public string The5B4870A386F7744D06237E0A { get; set; }

        [JsonProperty("5b4870d386f7743780259ff6")]
        public string The5B4870D386F7743780259Ff6 { get; set; }

        [JsonProperty("5b4870a386f7744d06237e0d")]
        public string The5B4870A386F7744D06237E0D { get; set; }

        [JsonProperty("5b55a3fd86f77469823e8121")]
        public string The5B55A3Fd86F77469823E8121 { get; set; }

        [JsonProperty("5bc477dc86f7744fd57fafeb")]
        public string The5Bc477Dc86F7744Fd57Fafeb { get; set; }

        [JsonProperty("5bc0c06486f7740a5c291e84")]
        public string The5Bc0C06486F7740A5C291E84 { get; set; }

        [JsonProperty("5bc477dc86f7744fd57fafe8")]
        public string The5Bc477Dc86F7744Fd57Fafe8 { get; set; }

        [JsonProperty("5bc47df886f7741e6b2f3325")]
        public string The5Bc47Df886F7741E6B2F3325 { get; set; }

        [JsonProperty("5bc47a2386f7743920281689")]
        public string The5Bc47A2386F7743920281689 { get; set; }

        [JsonProperty("5bc47a2386f774392028168c")]
        public string The5Bc47A2386F774392028168C { get; set; }

        [JsonProperty("5bc47df886f7741e6b2f3328")]
        public string The5Bc47Df886F7741E6B2F3328 { get; set; }

        [JsonProperty("5bc480f886f7741b09231869")]
        public string The5Bc480F886F7741B09231869 { get; set; }

        [JsonProperty("5bc4829786f774105516c76d")]
        public string The5Bc4829786F774105516C76D { get; set; }

        [JsonProperty("5bc4839f86f7746b5a283eb5")]
        public string The5Bc4839F86F7746B5A283Eb5 { get; set; }

        [JsonProperty("5bc4839f86f7746b5a283eb8")]
        public string The5Bc4839F86F7746B5A283Eb8 { get; set; }

        [JsonProperty("5bc4829786f774105516c76a")]
        public string The5Bc4829786F774105516C76A { get; set; }

        [JsonProperty("5bc4859286f7746ea275856e")]
        public string The5Bc4859286F7746Ea275856E { get; set; }

        [JsonProperty("5bc4898e86f7746b7978fe35")]
        public string The5Bc4898E86F7746B7978Fe35 { get; set; }

        [JsonProperty("5bc4859286f7746ea2758571")]
        public string The5Bc4859286F7746Ea2758571 { get; set; }

        [JsonProperty("5bdac0b686f7743e1665e09e")]
        public string The5Bdac0B686F7743E1665E09E { get; set; }

        [JsonProperty("5bc4898e86f7746b7978fe32")]
        public string The5Bc4898E86F7746B7978Fe32 { get; set; }

        [JsonProperty("5bc480f886f7741b0923186c")]
        public string The5Bc480F886F7741B0923186C { get; set; }

        [JsonProperty("5bdac06e86f774296f5a19c5")]
        public string The5Bdac06E86F774296F5A19C5 { get; set; }

        [JsonProperty("5c0bd95686f77479cf22c2f5")]
        public string The5C0Bd95686F77479Cf22C2F5 { get; set; }

        [JsonProperty("5c0bbabb86f77466d96707a2")]
        public string The5C0Bbabb86F77466D96707A2 { get; set; }

        [JsonProperty("5c0bbabb86f77466d96707a3")]
        public string The5C0Bbabb86F77466D96707A3 { get; set; }

        [JsonProperty("5c0bc93186f77459d871478d")]
        public string The5C0Bc93186F77459D871478D { get; set; }

        [JsonProperty("5c0bbabb86f77466d96707a5")]
        public string The5C0Bbabb86F77466D96707A5 { get; set; }

        [JsonProperty("5c0bc93186f77459d8714790")]
        public string The5C0Bc93186F77459D8714790 { get; set; }

        [JsonProperty("5c0bd03386f7746fe16dbbaa")]
        public string The5C0Bd03386F7746Fe16Dbbaa { get; set; }

        [JsonProperty("5c0bd03386f7746fe16dbbad")]
        public string The5C0Bd03386F7746Fe16Dbbad { get; set; }

        [JsonProperty("5c0bd95686f77479cf22c2f2")]
        public string The5C0Bd95686F77479Cf22C2F2 { get; set; }

        [JsonProperty("5c0bdb7c86f77422c8027f40")]
        public string The5C0Bdb7C86F77422C8027F40 { get; set; }

        [JsonProperty("5c0bdb7c86f77422c8027f43")]
        public string The5C0Bdb7C86F77422C8027F43 { get; set; }

        [JsonProperty("5c0bde1a86f7747bcb347d52")]
        public string The5C0Bde1A86F7747Bcb347D52 { get; set; }

        [JsonProperty("5c0bde1a86f7747bcb347d55")]
        public string The5C0Bde1A86F7747Bcb347D55 { get; set; }

        [JsonProperty("5c0be15086f7746f016734ae")]
        public string The5C0Be15086F7746F016734Ae { get; set; }

        [JsonProperty("5c0be15086f7746f016734ab")]
        public string The5C0Be15086F7746F016734Ab { get; set; }

        [JsonProperty("5c0be61786f7744525260758")]
        public string The5C0Be61786F7744525260758 { get; set; }

        [JsonProperty("5c0be61786f774452526075b")]
        public string The5C0Be61786F774452526075B { get; set; }

        [JsonProperty("5c0d0d9586f77433ec4de6c7")]
        public string The5C0D0D9586F77433Ec4De6C7 { get; set; }

        [JsonProperty("5c0d0f4186f774363760aef3")]
        public string The5C0D0F4186F774363760Aef3 { get; set; }

        [JsonProperty("5c0d0f4186f774363760aef6")]
        public string The5C0D0F4186F774363760Aef6 { get; set; }

        [JsonProperty("5c0d0d9586f77433ec4de6c4")]
        public string The5C0D0D9586F77433Ec4De6C4 { get; set; }

        [JsonProperty("5c1129a586f774656777d1a6")]
        public string The5C1129A586F774656777D1A6 { get; set; }

        [JsonProperty("5c11424286f77461fd4d9582")]
        public string The5C11424286F77461Fd4D9582 { get; set; }

        [JsonProperty("5c12350786f7745c8b0203f2")]
        public string The5C12350786F7745C8B0203F2 { get; set; }

        [JsonProperty("5c12350786f7745c8b0203ef")]
        public string The5C12350786F7745C8B0203Ef { get; set; }

        [JsonProperty("5c12428d86f77406fa13baf3")]
        public string The5C12428D86F77406Fa13Baf3 { get; set; }

        [JsonProperty("5c12a6a086f77456f7429b85")]
        public string The5C12A6A086F77456F7429B85 { get; set; }

        [JsonProperty("5c112dad86f77465c36be0c6")]
        public string The5C112Dad86F77465C36Be0C6 { get; set; }

        [JsonProperty("5c11412586f7745f60313bf2")]
        public string The5C11412586F7745F60313Bf2 { get; set; }

        [JsonProperty("5c1129a586f774656777d1a9")]
        public string The5C1129A586F774656777D1A9 { get; set; }

        [JsonProperty("5c112dad86f77465c36be0c3")]
        public string The5C112Dad86F77465C36Be0C3 { get; set; }

        [JsonProperty("5c12428d86f77406fa13baf6")]
        public string The5C12428D86F77406Fa13Baf6 { get; set; }

        [JsonProperty("5c11412586f7745f60313bf5")]
        public string The5C11412586F7745F60313Bf5 { get; set; }

        [JsonProperty("5c11424286f77461fd4d9585")]
        public string The5C11424286F77461Fd4D9585 { get; set; }

        [JsonProperty("5c12457886f77468cf6f7345")]
        public string The5C12457886F77468Cf6F7345 { get; set; }

        [JsonProperty("5c12457886f77468cf6f7342")]
        public string The5C12457886F77468Cf6F7342 { get; set; }

        [JsonProperty("5c12a6a086f77456f7429b88")]
        public string The5C12A6A086F77456F7429B88 { get; set; }

        [JsonProperty("5c13946186f774210563ecc6")]
        public string The5C13946186F774210563Ecc6 { get; set; }

        [JsonProperty("5c13a99d86f77463932d9bc2")]
        public string The5C13A99D86F77463932D9Bc2 { get; set; }

        [JsonProperty("5c13946186f774210563ecc3")]
        public string The5C13946186F774210563Ecc3 { get; set; }

        [JsonProperty("5c13997e86f774210563ece0")]
        public string The5C13997E86F774210563Ece0 { get; set; }

        [JsonProperty("5c13997e86f774210563ece1")]
        public string The5C13997E86F774210563Ece1 { get; set; }

        [JsonProperty("5c13997e86f774210563ece3")]
        public string The5C13997E86F774210563Ece3 { get; set; }

        [JsonProperty("5c13a99d86f77463932d9bc5")]
        public string The5C13A99D86F77463932D9Bc5 { get; set; }

        [JsonProperty("5c1a4e1286f774072447df2b")]
        public string The5C1A4E1286F774072447Df2B { get; set; }

        [JsonProperty("5c1a4d5286f77431700f6134")]
        public string The5C1A4D5286F77431700F6134 { get; set; }

        [JsonProperty("5c1a4ccf86f774072447defe")]
        public string The5C1A4Ccf86F774072447Defe { get; set; }

        [JsonProperty("5c1a52c686f77431740a3839")]
        public string The5C1A52C686F77431740A3839 { get; set; }

        [JsonProperty("5c1a4cc786f77435a060f47a")]
        public string The5C1A4Cc786F77435A060F47A { get; set; }

        [JsonProperty("5c1a533f86f77438bd2bfc6d")]
        public string The5C1A533F86F77438Bd2Bfc6D { get; set; }

        [JsonProperty("5c5d950686f7747a777ade0c")]
        public string The5C5D950686F7747A777Ade0C { get; set; }

        [JsonProperty("5c5d950686f7747a777ade0f")]
        public string The5C5D950686F7747A777Ade0F { get; set; }

        [JsonProperty("5d2496bd86f77425cc4e9475")]
        public string The5D2496Bd86F77425Cc4E9475 { get; set; }

        [JsonProperty("5d2496bd86f77425cc4e9478")]
        public string The5D2496Bd86F77425Cc4E9478 { get; set; }

        [JsonProperty("5d24b83286f7743d2612b6f8")]
        public string The5D24B83286F7743D2612B6F8 { get; set; }

        [JsonProperty("5d24b83286f7743d2612b6fb")]
        public string The5D24B83286F7743D2612B6Fb { get; set; }

        [JsonProperty("5d25a9e486f77443e3514eba")]
        public string The5D25A9E486F77443E3514Eba { get; set; }

        [JsonProperty("5d25af0f86f77443e55d1454")]
        public string The5D25Af0F86F77443E55D1454 { get; set; }

        [JsonProperty("5d25af0f86f77443e55d1457")]
        public string The5D25Af0F86F77443E55D1457 { get; set; }

        [JsonProperty("5d25b6ce86f77443ff46b9eb")]
        public string The5D25B6Ce86F77443Ff46B9Eb { get; set; }

        [JsonProperty("5d25b6ce86f77443ff46b9ee")]
        public string The5D25B6Ce86F77443Ff46B9Ee { get; set; }

        [JsonProperty("5d25c3e886f77444001e2840")]
        public string The5D25C3E886F77444001E2840 { get; set; }

        [JsonProperty("5d25c3e886f77444001e2843")]
        public string The5D25C3E886F77444001E2843 { get; set; }

        [JsonProperty("5d25c85586f77408251c4225")]
        public string The5D25C85586F77408251C4225 { get; set; }

        [JsonProperty("5d25c85586f77408251c4228")]
        public string The5D25C85586F77408251C4228 { get; set; }

        [JsonProperty("5d25cf5d86f77408251c422a")]
        public string The5D25Cf5D86F77408251C422A { get; set; }

        [JsonProperty("5d25cf5d86f77408251c422b")]
        public string The5D25Cf5D86F77408251C422B { get; set; }

        [JsonProperty("5d25cf5d86f77408251c422d")]
        public string The5D25Cf5D86F77408251C422D { get; set; }

        [JsonProperty("5d25d4cb86f77443e55d2f73")]
        public string The5D25D4Cb86F77443E55D2F73 { get; set; }

        [JsonProperty("5d25d4cb86f77443e55d2f76")]
        public string The5D25D4Cb86F77443E55D2F76 { get; set; }

        [JsonProperty("5d25dbd086f77443e625e380")]
        public string The5D25Dbd086F77443E625E380 { get; set; }

        [JsonProperty("5d25dbd086f77443e625e383")]
        public string The5D25Dbd086F77443E625E383 { get; set; }

        [JsonProperty("5d25fd4c86f77409de05bba6")]
        public string The5D25Fd4C86F77409De05Bba6 { get; set; }

        [JsonProperty("5d25fd4c86f77409de05bba9")]
        public string The5D25Fd4C86F77409De05Bba9 { get; set; }

        [JsonProperty("5d26042386f77443ff46d19a")]
        public string The5D26042386F77443Ff46D19A { get; set; }

        [JsonProperty("5d26042386f77443ff46d19d")]
        public string The5D26042386F77443Ff46D19D { get; set; }

        [JsonProperty("5d260f8686f77469f04444b2")]
        public string The5D260F8686F77469F04444B2 { get; set; }

        [JsonProperty("5d260f8686f77469f04444b5")]
        public string The5D260F8686F77469F04444B5 { get; set; }

        [JsonProperty("5d26f9f086f77469ee70ac2c")]
        public string The5D26F9F086F77469Ee70Ac2C { get; set; }

        [JsonProperty("5d26f9f086f77469ee70ac2f")]
        public string The5D26F9F086F77469Ee70Ac2F { get; set; }

        [JsonProperty("5d27018e86f77469ef0f8950")]
        public string The5D27018E86F77469Ef0F8950 { get; set; }

        [JsonProperty("5d27018e86f77469ef0f8953")]
        public string The5D27018E86F77469Ef0F8953 { get; set; }

        [JsonProperty("5d27080886f77469ef0f8955")]
        public string The5D27080886F77469Ef0F8955 { get; set; }

        [JsonProperty("5d27080886f77469ef0f8958")]
        public string The5D27080886F77469Ef0F8958 { get; set; }

        [JsonProperty("5d270bbc86f77469f1599fe3")]
        public string The5D270Bbc86F77469F1599Fe3 { get; set; }

        [JsonProperty("5d270bbc86f77469f1599fe6")]
        public string The5D270Bbc86F77469F1599Fe6 { get; set; }

        [JsonProperty("5d27245186f774483c7bdb13")]
        public string The5D27245186F774483C7Bdb13 { get; set; }

        [JsonProperty("5d27245186f774483c7bdb16")]
        public string The5D27245186F774483C7Bdb16 { get; set; }

        [JsonProperty("5d272b9086f774070261ec1d")]
        public string The5D272B9086F774070261Ec1D { get; set; }

        [JsonProperty("5d272b9086f774070261ec20")]
        public string The5D272B9086F774070261Ec20 { get; set; }

        [JsonProperty("5d27323c86f77445722f1f98")]
        public string The5D27323C86F77445722F1F98 { get; set; }

        [JsonProperty("5d27323c86f77445722f1f9b")]
        public string The5D27323C86F77445722F1F9B { get; set; }

        [JsonProperty("5d27366b86f77445710a8072")]
        public string The5D27366B86F77445710A8072 { get; set; }

        [JsonProperty("5d27366b86f77445710a8075")]
        public string The5D27366B86F77445710A8075 { get; set; }

        [JsonProperty("5d2739d386f77445710a8077")]
        public string The5D2739D386F77445710A8077 { get; set; }

        [JsonProperty("5d2739d386f77445710a807a")]
        public string The5D2739D386F77445710A807A { get; set; }

        [JsonProperty("5d27429986f774457527c7eb")]
        public string The5D27429986F774457527C7Eb { get; set; }

        [JsonProperty("5d27429986f774457527c7ee")]
        public string The5D27429986F774457527C7Ee { get; set; }

        [JsonProperty("5d2747db86f7741d0b1f40ac")]
        public string The5D2747Db86F7741D0B1F40Ac { get; set; }

        [JsonProperty("5d2747db86f7741d0b1f40af")]
        public string The5D2747Db86F7741D0B1F40Af { get; set; }

        [JsonProperty("5d274eae86f77475a86565c1")]
        public string The5D274Eae86F77475A86565C1 { get; set; }

        [JsonProperty("5d274eae86f77475a86565c4")]
        public string The5D274Eae86F77475A86565C4 { get; set; }

        [JsonProperty("5d2f378786f774169b7e0066")]
        public string The5D2F378786F774169B7E0066 { get; set; }

        [JsonProperty("5d2f378786f774169b7e0069")]
        public string The5D2F378786F774169B7E0069 { get; set; }

        [JsonProperty("5d3076e386f7743c836efc88")]
        public string The5D3076E386F7743C836Efc88 { get; set; }

        [JsonProperty("5d3076e386f7743c836efc8b")]
        public string The5D3076E386F7743C836Efc8B { get; set; }

        [JsonProperty("5d4bec6a86f7741e530d2c02")]
        public string The5D4Bec6A86F7741E530D2C02 { get; set; }

        [JsonProperty("5d4bec6a86f7741e530d2c05")]
        public string The5D4Bec6A86F7741E530D2C05 { get; set; }

        [JsonProperty("5d66912c86f774368f43a242")]
        public string The5D66912C86F774368F43A242 { get; set; }

        [JsonProperty("5d66912c86f774368f43a245")]
        public string The5D66912C86F774368F43A245 { get; set; }

        [JsonProperty("5d66914986f7743690020691")]
        public string The5D66914986F7743690020691 { get; set; }

        [JsonProperty("5d66914986f7743690020694")]
        public string The5D66914986F7743690020694 { get; set; }

        [JsonProperty("5d6fb45f86f77449d825f9cc")]
        public string The5D6Fb45F86F77449D825F9Cc { get; set; }

        [JsonProperty("5d6fb45f86f77449d825f9cf")]
        public string The5D6Fb45F86F77449D825F9Cf { get; set; }

        [JsonProperty("5d6fbedb86f77449d825f9d4")]
        public string The5D6Fbedb86F77449D825F9D4 { get; set; }

        [JsonProperty("5d6fbedb86f77449d825f9d7")]
        public string The5D6Fbedb86F77449D825F9D7 { get; set; }

        [JsonProperty("5da89bb186f77414b61f8a43")]
        public string The5Da89Bb186F77414B61F8A43 { get; set; }

        [JsonProperty("5da89be186f7742f9026cb8b")]
        public string The5Da89Be186F7742F9026Cb8B { get; set; }

        [JsonProperty("5db82b8e8bf4c142f615e0d8")]
        public string The5Db82B8E8Bf4C142F615E0D8 { get; set; }

        [JsonProperty("5dc5401c86f77469c5053043")]
        public string The5Dc5401C86F77469C5053043 { get; set; }

        [JsonProperty("5dc5401c86f77469c5053046")]
        public string The5Dc5401C86F77469C5053046 { get; set; }

        [JsonProperty("5e0653d486f774478e6132f3")]
        public string The5E0653D486F774478E6132F3 { get; set; }
    }

    public partial class Preset
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public partial class Quest
    {
        [JsonProperty("59675ea386f77414b32bded2")]
        public The59675Ea386F77414B32Bded2 The59675Ea386F77414B32Bded2 { get; set; }

        [JsonProperty("596760e186f7741e11214d58")]
        public The596760E186F7741E11214D58 The596760E186F7741E11214D58 { get; set; }

        [JsonProperty("59689fbd86f7740d137ebfc4")]
        public The59689Fbd86F7740D137Ebfc4 The59689Fbd86F7740D137Ebfc4 { get; set; }

        [JsonProperty("59674cd986f7744ab26e32f2")]
        public The59674Cd986F7744Ab26E32F2 The59674Cd986F7744Ab26E32F2 { get; set; }

        [JsonProperty("596b43fb86f77457ca186186")]
        public The596B43Fb86F77457Ca186186 The596B43Fb86F77457Ca186186 { get; set; }

        [JsonProperty("596a0e1686f7741ddf17dbee")]
        public The596A0E1686F7741Ddf17Dbee The596A0E1686F7741Ddf17Dbee { get; set; }

        [JsonProperty("5969f90786f77420d2328015")]
        public The5969F90786F77420D2328015 The5969F90786F77420D2328015 { get; set; }

        [JsonProperty("5979eee086f774311955e614")]
        public The5979Eee086F774311955E614 The5979Eee086F774311955E614 { get; set; }

        [JsonProperty("5979f9ba86f7740f6c3fe9f2")]
        public The5979F9Ba86F7740F6C3Fe9F2 The5979F9Ba86F7740F6C3Fe9F2 { get; set; }

        [JsonProperty("597a0e5786f77426d66c0636")]
        public The597A0E5786F77426D66C0636 The597A0E5786F77426D66C0636 { get; set; }

        [JsonProperty("5936da9e86f7742d65037edf")]
        public The5936Da9E86F7742D65037Edf The5936Da9E86F7742D65037Edf { get; set; }

        [JsonProperty("5a27c99a86f7747d2c6bdd8e")]
        public The5A27C99A86F7747D2C6Bdd8E The5A27C99A86F7747D2C6Bdd8E { get; set; }

        [JsonProperty("596a204686f774576d4c95de")]
        public The596A204686F774576D4C95De The596A204686F774576D4C95De { get; set; }

        [JsonProperty("59ca264786f77445a80ed044")]
        public The59Ca264786F77445A80Ed044 The59Ca264786F77445A80Ed044 { get; set; }

        [JsonProperty("596a1e6c86f7741ddc2d3206")]
        public The596A1E6C86F7741Ddc2D3206 The596A1E6C86F7741Ddc2D3206 { get; set; }

        [JsonProperty("5967530a86f77462ba22226b")]
        public The5967530A86F77462Ba22226B The5967530A86F77462Ba22226B { get; set; }

        [JsonProperty("59675d6c86f7740a842fc482")]
        public The59675D6C86F7740A842Fc482 The59675D6C86F7740A842Fc482 { get; set; }

        [JsonProperty("596b36c586f77450d6045ad2")]
        public The596B36C586F77450D6045Ad2 The596B36C586F77450D6045Ad2 { get; set; }

        [JsonProperty("5979f8bb86f7743ec214c7a6")]
        public The5979F8Bb86F7743Ec214C7A6 The5979F8Bb86F7743Ec214C7A6 { get; set; }

        [JsonProperty("596b455186f77457cb50eccb")]
        public The596B455186F77457Cb50Eccb The596B455186F77457Cb50Eccb { get; set; }

        [JsonProperty("596a218586f77420d232807c")]
        public The596A218586F77420D232807C The596A218586F77420D232807C { get; set; }

        [JsonProperty("5968eb3186f7741dde183a4d")]
        public The5968Eb3186F7741Dde183A4D The5968Eb3186F7741Dde183A4D { get; set; }

        [JsonProperty("5969f9e986f7741dde183a50")]
        public The5969F9E986F7741Dde183A50 The5969F9E986F7741Dde183A50 { get; set; }

        [JsonProperty("5979ed3886f77431307dc512")]
        public The5979Ed3886F77431307Dc512 The5979Ed3886F77431307Dc512 { get; set; }

        [JsonProperty("59ca1a6286f774509a270942")]
        public The59Ca1A6286F774509A270942 The59Ca1A6286F774509A270942 { get; set; }

        [JsonProperty("5936d90786f7742b1420ba5b")]
        public The5936D90786F7742B1420Ba5B The5936D90786F7742B1420Ba5B { get; set; }

        [JsonProperty("596a101f86f7741ddb481582")]
        public The596A101F86F7741Ddb481582 The596A101F86F7741Ddb481582 { get; set; }

        [JsonProperty("59674eb386f774539f14813a")]
        public The59674Eb386F774539F14813A The59674Eb386F774539F14813A { get; set; }

        [JsonProperty("59689ee586f7740d1570bbd5")]
        public The59689Ee586F7740D1570Bbd5 The59689Ee586F7740D1570Bbd5 { get; set; }

        [JsonProperty("597a171586f77405ba6887d3")]
        public The597A171586F77405Ba6887D3 The597A171586F77405Ba6887D3 { get; set; }

        [JsonProperty("5967725e86f774601a446662")]
        public The5967725E86F774601A446662 The5967725E86F774601A446662 { get; set; }

        [JsonProperty("597a0f5686f774273b74f676")]
        public The597A0F5686F774273B74F676 The597A0F5686F774273B74F676 { get; set; }

        [JsonProperty("5967733e86f774602332fc84")]
        public The5967733E86F774602332Fc84 The5967733E86F774602332Fc84 { get; set; }

        [JsonProperty("597a160786f77477531d39d2")]
        public The597A160786F77477531D39D2 The597A160786F77477531D39D2 { get; set; }

        [JsonProperty("5a27ba1c86f77461ea5a3c56")]
        public The5A27Ba1C86F77461Ea5A3C56 The5A27Ba1C86F77461Ea5A3C56 { get; set; }

        [JsonProperty("5a03173786f77451cb427172")]
        public The5A03173786F77451Cb427172 The5A03173786F77451Cb427172 { get; set; }

        [JsonProperty("59c93e8e86f7742a406989c4")]
        public The59C93E8E86F7742A406989C4 The59C93E8E86F7742A406989C4 { get; set; }

        [JsonProperty("597a0b2986f77426d66c0633")]
        public The597A0B2986F77426D66C0633 The597A0B2986F77426D66C0633 { get; set; }

        [JsonProperty("59c50c8886f7745fed3193bf")]
        public The59C50C8886F7745Fed3193Bf The59C50C8886F7745Fed3193Bf { get; set; }

        [JsonProperty("5a27bb3d86f77411ea361a21")]
        public The5A27Bb3D86F77411Ea361A21 The5A27Bb3D86F77411Ea361A21 { get; set; }

        [JsonProperty("59c124d686f774189b3c843f")]
        public The59C124D686F774189B3C843F The59C124D686F774189B3C843F { get; set; }

        [JsonProperty("59c50a9e86f7745fef66f4ff")]
        public The59C50A9E86F7745Fef66F4Ff The59C50A9E86F7745Fef66F4Ff { get; set; }

        [JsonProperty("59ca29fb86f77445ab465c87")]
        public The59Ca29Fb86F77445Ab465C87 The59Ca29Fb86F77445Ab465C87 { get; set; }

        [JsonProperty("5a0449d586f77474e66227b7")]
        public The5A0449D586F77474E66227B7 The5A0449D586F77474E66227B7 { get; set; }

        [JsonProperty("59c512ad86f7741f0d09de9b")]
        public The59C512Ad86F7741F0D09De9B The59C512Ad86F7741F0D09De9B { get; set; }

        [JsonProperty("5a03153686f77442d90e2171")]
        public The5A03153686F77442D90E2171 The5A03153686F77442D90E2171 { get; set; }

        [JsonProperty("5a27bb5986f7741dfb660900")]
        public The5A27Bb5986F7741Dfb660900 The5A27Bb5986F7741Dfb660900 { get; set; }

        [JsonProperty("59c9392986f7742f6923add2")]
        public The59C9392986F7742F6923Add2 The59C9392986F7742F6923Add2 { get; set; }

        [JsonProperty("59ca2eb686f77445a80ed049")]
        public The59Ca2Eb686F77445A80Ed049 The59Ca2Eb686F77445A80Ed049 { get; set; }

        [JsonProperty("5a0327ba86f77456b9154236")]
        public The5A0327Ba86F77456B9154236 The5A0327Ba86F77456B9154236 { get; set; }

        [JsonProperty("5a03296886f774569778596a")]
        public The5A03296886F774569778596A The5A03296886F774569778596A { get; set; }

        [JsonProperty("5a27ba9586f7741b543d8e85")]
        public The5A27Ba9586F7741B543D8E85 The5A27Ba9586F7741B543D8E85 { get; set; }

        [JsonProperty("5a27b7a786f774579c3eb376")]
        public The5A27B7A786F774579C3Eb376 The5A27B7A786F774579C3Eb376 { get; set; }

        [JsonProperty("5a27b9de86f77464e5044585")]
        public The5A27B9De86F77464E5044585 The5A27B9De86F77464E5044585 { get; set; }

        [JsonProperty("5a68667486f7742607157d28")]
        public The5A68667486F7742607157D28 The5A68667486F7742607157D28 { get; set; }

        [JsonProperty("5a27b7d686f77460d847e6a6")]
        public The5A27B7D686F77460D847E6A6 The5A27B7D686F77460D847E6A6 { get; set; }

        [JsonProperty("5a27b87686f77460de0252a8")]
        public The5A27B87686F77460De0252A8 The5A27B87686F77460De0252A8 { get; set; }

        [JsonProperty("5a27b75b86f7742e97191958")]
        public The5A27B75B86F7742E97191958 The5A27B75B86F7742E97191958 { get; set; }

        [JsonProperty("5a27bafb86f7741c73584017")]
        public The5A27Bafb86F7741C73584017 The5A27Bafb86F7741C73584017 { get; set; }

        [JsonProperty("5a27bb1e86f7741f27621b7e")]
        public The5A27Bb1E86F7741F27621B7E The5A27Bb1E86F7741F27621B7E { get; set; }

        [JsonProperty("59f9da6786f774714230d751")]
        public The59F9Da6786F774714230D751 The59F9Da6786F774714230D751 { get; set; }

        [JsonProperty("5a27b80086f774429a5d7e20")]
        public The5A27B80086F774429A5D7E20 The5A27B80086F774429A5D7E20 { get; set; }

        [JsonProperty("5a27bc6986f7741c7358402b")]
        public The5A27Bc6986F7741C7358402B The5A27Bc6986F7741C7358402B { get; set; }

        [JsonProperty("5a27bc3686f7741c73584026")]
        public The5A27Bc3686F7741C73584026 The5A27Bc3686F7741C73584026 { get; set; }

        [JsonProperty("5a27bbf886f774333a418eeb")]
        public The5A27Bbf886F774333A418Eeb The5A27Bbf886F774333A418Eeb { get; set; }

        [JsonProperty("5a27bb8386f7741c770d2d0a")]
        public The5A27Bb8386F7741C770D2D0A The5A27Bb8386F7741C770D2D0A { get; set; }

        [JsonProperty("5a27bc1586f7741f6d40fa2f")]
        public The5A27Bc1586F7741F6D40Fa2F The5A27Bc1586F7741F6D40Fa2F { get; set; }

        [JsonProperty("5a27bc8586f7741b543d8ea4")]
        public The5A27Bc8586F7741B543D8Ea4 The5A27Bc8586F7741B543D8Ea4 { get; set; }

        [JsonProperty("5a27d2af86f7744e1115b323")]
        public The5A27D2Af86F7744E1115B323 The5A27D2Af86F7744E1115B323 { get; set; }

        [JsonProperty("5a5642ce86f77445c63c3419")]
        public The5A5642Ce86F77445C63C3419 The5A5642Ce86F77445C63C3419 { get; set; }

        [JsonProperty("5a68665c86f774255929b4c7")]
        public The5A68665C86F774255929B4C7 The5A68665C86F774255929B4C7 { get; set; }

        [JsonProperty("5a68661a86f774500f48afb0")]
        public The5A68661A86F774500F48Afb0 The5A68661A86F774500F48Afb0 { get; set; }

        [JsonProperty("5a68669a86f774255929b4d4")]
        public The5A68669A86F774255929B4D4 The5A68669A86F774255929B4D4 { get; set; }

        [JsonProperty("5a68663e86f774501078f78a")]
        public The5A68663E86F774501078F78A The5A68663E86F774501078F78A { get; set; }

        [JsonProperty("5ac23c6186f7741247042bad")]
        public The5Ac23C6186F7741247042Bad The5Ac23C6186F7741247042Bad { get; set; }

        [JsonProperty("5ac2428686f77412450b42bf")]
        public The5Ac2428686F77412450B42Bf The5Ac2428686F77412450B42Bf { get; set; }

        [JsonProperty("5ac242ab86f77412464f68b4")]
        public The5Ac242Ab86F77412464F68B4 The5Ac242Ab86F77412464F68B4 { get; set; }

        [JsonProperty("5ac2426c86f774138762edfe")]
        public The5Ac2426C86F774138762Edfe The5Ac2426C86F774138762Edfe { get; set; }

        [JsonProperty("5ac244c486f77413e12cf945")]
        public The5Ac244C486F77413E12Cf945 The5Ac244C486F77413E12Cf945 { get; set; }

        [JsonProperty("5ac244eb86f7741356335af1")]
        public The5Ac244Eb86F7741356335Af1 The5Ac244Eb86F7741356335Af1 { get; set; }

        [JsonProperty("5ac3464c86f7741d651d6877")]
        public The5Ac3464C86F7741D651D6877 The5Ac3464C86F7741D651D6877 { get; set; }

        [JsonProperty("5ac345dc86f774288030817f")]
        public The5Ac345Dc86F774288030817F The5Ac345Dc86F774288030817F { get; set; }

        [JsonProperty("5ac3462b86f7741d6118b983")]
        public The5Ac3462B86F7741D6118B983 The5Ac3462B86F7741D6118B983 { get; set; }

        [JsonProperty("5ac346cf86f7741d63233a02")]
        public The5Ac346Cf86F7741D63233A02 The5Ac346Cf86F7741D63233A02 { get; set; }

        [JsonProperty("5ac3460c86f7742880308185")]
        public The5Ac3460C86F7742880308185 The5Ac3460C86F7742880308185 { get; set; }

        [JsonProperty("5ac3467986f7741d6224abc2")]
        public The5Ac3467986F7741D6224Abc2 The5Ac3467986F7741D6224Abc2 { get; set; }

        [JsonProperty("5ac346a886f7744e1b083d67")]
        public The5Ac346A886F7744E1B083D67 The5Ac346A886F7744E1B083D67 { get; set; }

        [JsonProperty("5ac3475486f7741d6224abd3")]
        public The5Ac3475486F7741D6224Abd3 The5Ac3475486F7741D6224Abd3 { get; set; }

        [JsonProperty("5ac3477486f7741d651d6885")]
        public The5Ac3477486F7741D651D6885 The5Ac3477486F7741D651D6885 { get; set; }

        [JsonProperty("5ac346e886f7741d6118b99b")]
        public The5Ac346E886F7741D6118B99B The5Ac346E886F7741D6118B99B { get; set; }

        [JsonProperty("5ac3479086f7742880308199")]
        public The5Ac3479086F7742880308199 The5Ac3479086F7742880308199 { get; set; }

        [JsonProperty("5ae448a386f7744d3730fff0")]
        public The5Ae448A386F7744D3730Fff0 The5Ae448A386F7744D3730Fff0 { get; set; }

        [JsonProperty("5ae3277186f7745973054106")]
        public The5Ae3277186F7745973054106 The5Ae3277186F7745973054106 { get; set; }

        [JsonProperty("5ae327c886f7745c7b3f2f3f")]
        public The5Ae327C886F7745C7B3F2F3F The5Ae327C886F7745C7B3F2F3F { get; set; }

        [JsonProperty("5ae3270f86f77445ba41d4dd")]
        public The5Ae3270F86F77445Ba41D4Dd The5Ae3270F86F77445Ba41D4Dd { get; set; }

        [JsonProperty("5ae3280386f7742a41359364")]
        public The5Ae3280386F7742A41359364 The5Ae3280386F7742A41359364 { get; set; }

        [JsonProperty("5ae3267986f7742a413592fe")]
        public The5Ae3267986F7742A413592Fe The5Ae3267986F7742A413592Fe { get; set; }

        [JsonProperty("5ae448bf86f7744d733e55ee")]
        public The5Ae448Bf86F7744D733E55Ee The5Ae448Bf86F7744D733E55Ee { get; set; }

        [JsonProperty("5ae448e586f7744dcf0c2a67")]
        public The5Ae448E586F7744Dcf0C2A67 The5Ae448E586F7744Dcf0C2A67 { get; set; }

        [JsonProperty("5ae4490786f7744ca822adcc")]
        public The5Ae4490786F7744Ca822Adcc The5Ae4490786F7744Ca822Adcc { get; set; }

        [JsonProperty("5ae4495c86f7744e87761355")]
        public The5Ae4495C86F7744E87761355 The5Ae4495C86F7744E87761355 { get; set; }

        [JsonProperty("5ae4495086f77443c122bc40")]
        public The5Ae4495086F77443C122Bc40 The5Ae4495086F77443C122Bc40 { get; set; }

        [JsonProperty("5ae448f286f77448d73c0131")]
        public The5Ae448F286F77448D73C0131 The5Ae448F286F77448D73C0131 { get; set; }

        [JsonProperty("5ae4497b86f7744cf402ed00")]
        public The5Ae4497B86F7744Cf402Ed00 The5Ae4497B86F7744Cf402Ed00 { get; set; }

        [JsonProperty("5ae4493486f7744efa289417")]
        public The5Ae4493486F7744Efa289417 The5Ae4493486F7744Efa289417 { get; set; }

        [JsonProperty("5ae4493d86f7744b8e15aa8f")]
        public The5Ae4493D86F7744B8E15Aa8F The5Ae4493D86F7744B8E15Aa8F { get; set; }

        [JsonProperty("5ae4498786f7744bde357695")]
        public The5Ae4498786F7744Bde357695 The5Ae4498786F7744Bde357695 { get; set; }

        [JsonProperty("5ae4496986f774459e77beb6")]
        public The5Ae4496986F774459E77Beb6 The5Ae4496986F774459E77Beb6 { get; set; }

        [JsonProperty("5ae449a586f7744bde357696")]
        public The5Ae449A586F7744Bde357696 The5Ae449A586F7744Bde357696 { get; set; }

        [JsonProperty("5ae449b386f77446d8741719")]
        public The5Ae449B386F77446D8741719 The5Ae449B386F77446D8741719 { get; set; }

        [JsonProperty("5ae449d986f774453a54a7e1")]
        public The5Ae449D986F774453A54A7E1 The5Ae449D986F774453A54A7E1 { get; set; }

        [JsonProperty("5ae4499a86f77449783815db")]
        public The5Ae4499A86F77449783815Db The5Ae4499A86F77449783815Db { get; set; }

        [JsonProperty("5ae449c386f7744bde357697")]
        public The5Ae449C386F7744Bde357697 The5Ae449C386F7744Bde357697 { get; set; }

        [JsonProperty("5b47876e86f7744d1c353205")]
        public The5B47876E86F7744D1C353205 The5B47876E86F7744D1C353205 { get; set; }

        [JsonProperty("5b47749f86f7746c5d6a5fd4")]
        public The5B47749F86F7746C5D6A5Fd4 The5B47749F86F7746C5D6A5Fd4 { get; set; }

        [JsonProperty("5b47799d86f7746c5d6a5fd8")]
        public The5B47799D86F7746C5D6A5Fd8 The5B47799D86F7746C5D6A5Fd8 { get; set; }

        [JsonProperty("5b477b6f86f7747290681823")]
        public The5B477B6F86F7747290681823 The5B477B6F86F7747290681823 { get; set; }

        [JsonProperty("5b47825886f77468074618d3")]
        public The5B47825886F77468074618D3 The5B47825886F77468074618D3 { get; set; }

        [JsonProperty("5b47891f86f7744d1b23c571")]
        public The5B47891F86F7744D1B23C571 The5B47891F86F7744D1B23C571 { get; set; }

        [JsonProperty("5b4794cb86f774598100d5d4")]
        public The5B4794Cb86F774598100D5D4 The5B4794Cb86F774598100D5D4 { get; set; }

        [JsonProperty("5b478b1886f7744d1b23c57d")]
        public The5B478B1886F7744D1B23C57D The5B478B1886F7744D1B23C57D { get; set; }

        [JsonProperty("5b477f7686f7744d1b23c4d2")]
        public The5B477F7686F7744D1B23C4D2 The5B477F7686F7744D1B23C4D2 { get; set; }

        [JsonProperty("5b478ff486f7744d184ecbbf")]
        public The5B478Ff486F7744D184Ecbbf The5B478Ff486F7744D184Ecbbf { get; set; }

        [JsonProperty("5b478eca86f7744642012254")]
        public The5B478Eca86F7744642012254 The5B478Eca86F7744642012254 { get; set; }

        [JsonProperty("5b47926a86f7747ccc057c15")]
        public The5B47926A86F7747Ccc057C15 The5B47926A86F7747Ccc057C15 { get; set; }

        [JsonProperty("5b478d0f86f7744d190d91b5")]
        public The5B478D0F86F7744D190D91B5 The5B478D0F86F7744D190D91B5 { get; set; }

        [JsonProperty("5b4795fb86f7745876267770")]
        public The5B4795Fb86F7745876267770 The5B4795Fb86F7745876267770 { get; set; }

        [JsonProperty("5bc4776586f774512d07cf05")]
        public The5Bc4776586F774512D07Cf05 The5Bc4776586F774512D07Cf05 { get; set; }

        [JsonProperty("5bc479e586f7747f376c7da3")]
        public The5Bc479E586F7747F376C7Da3 The5Bc479E586F7747F376C7Da3 { get; set; }

        [JsonProperty("5bc4826c86f774106d22d88b")]
        public The5Bc4826C86F774106D22D88B The5Bc4826C86F774106D22D88B { get; set; }

        [JsonProperty("5bc47dbf86f7741ee74e93b9")]
        public The5Bc47Dbf86F7741Ee74E93B9 The5Bc47Dbf86F7741Ee74E93B9 { get; set; }

        [JsonProperty("5bc480a686f7741af0342e29")]
        public The5Bc480A686F7741Af0342E29 The5Bc480A686F7741Af0342E29 { get; set; }

        [JsonProperty("5bc4836986f7740c0152911c")]
        public The5Bc4836986F7740C0152911C The5Bc4836986F7740C0152911C { get; set; }

        [JsonProperty("5bc4856986f77454c317bea7")]
        public The5Bc4856986F77454C317Bea7 The5Bc4856986F77454C317Bea7 { get; set; }

        [JsonProperty("5bc4893c86f774626f5ebf3e")]
        public The5Bc4893C86F774626F5Ebf3E The5Bc4893C86F774626F5Ebf3E { get; set; }

        [JsonProperty("5c0be5fc86f774467a116593")]
        public The5C0Be5Fc86F774467A116593 The5C0Be5Fc86F774467A116593 { get; set; }

        [JsonProperty("5c0bbaa886f7746941031d82")]
        public The5C0Bbaa886F7746941031D82 The5C0Bbaa886F7746941031D82 { get; set; }

        [JsonProperty("5c0bc91486f7746ab41857a2")]
        public The5C0Bc91486F7746Ab41857A2 The5C0Bc91486F7746Ab41857A2 { get; set; }

        [JsonProperty("5c0bd94186f7747a727f09b2")]
        public The5C0Bd94186F7747A727F09B2 The5C0Bd94186F7747A727F09B2 { get; set; }

        [JsonProperty("5c0bde0986f77479cf22c2f8")]
        public The5C0Bde0986F77479Cf22C2F8 The5C0Bde0986F77479Cf22C2F8 { get; set; }

        [JsonProperty("5c0bd01e86f7747cdd799e56")]
        public The5C0Bd01E86F7747Cdd799E56 The5C0Bd01E86F7747Cdd799E56 { get; set; }

        [JsonProperty("5c0bdb5286f774166e38eed4")]
        public The5C0Bdb5286F774166E38Eed4 The5C0Bdb5286F774166E38Eed4 { get; set; }

        [JsonProperty("5c0be13186f7746f016734aa")]
        public The5C0Be13186F7746F016734Aa The5C0Be13186F7746F016734Aa { get; set; }

        [JsonProperty("5c0d0f1886f77457b8210226")]
        public The5C0D0F1886F77457B8210226 The5C0D0F1886F77457B8210226 { get; set; }

        [JsonProperty("5c0d0d5086f774363760aef2")]
        public The5C0D0D5086F774363760Aef2 The5C0D0D5086F774363760Aef2 { get; set; }

        [JsonProperty("5c112d7e86f7740d6f647486")]
        public The5C112D7E86F7740D6F647486 The5C112D7E86F7740D6F647486 { get; set; }

        [JsonProperty("5c1128e386f7746565181106")]
        public The5C1128E386F7746565181106 The5C1128E386F7746565181106 { get; set; }

        [JsonProperty("5c1141f386f77430ff393792")]
        public The5C1141F386F77430Ff393792 The5C1141F386F77430Ff393792 { get; set; }

        [JsonProperty("5c0d190cd09282029f5390d8")]
        public The5C0D190Cd09282029F5390D8 The5C0D190Cd09282029F5390D8 { get; set; }

        [JsonProperty("5c12452c86f7744b83469073")]
        public The5C12452C86F7744B83469073 The5C12452C86F7744B83469073 { get; set; }

        [JsonProperty("5c10f94386f774227172c572")]
        public The5C10F94386F774227172C572 The5C10F94386F774227172C572 { get; set; }

        [JsonProperty("5c1234c286f77406fa13baeb")]
        public The5C1234C286F77406Fa13Baeb The5C1234C286F77406Fa13Baeb { get; set; }

        [JsonProperty("5c0d1c4cd0928202a02a6f5c")]
        public The5C0D1C4Cd0928202A02A6F5C The5C0D1C4Cd0928202A02A6F5C { get; set; }

        [JsonProperty("5c0d4c12d09282029f539173")]
        public The5C0D4C12D09282029F539173 The5C0D4C12D09282029F539173 { get; set; }

        [JsonProperty("5c139eb686f7747878361a6f")]
        public The5C139Eb686F7747878361A6F The5C139Eb686F7747878361A6F { get; set; }

        [JsonProperty("5c0d4e61d09282029f53920e")]
        public The5C0D4E61D09282029F53920E The5C0D4E61D09282029F53920E { get; set; }

        [JsonProperty("5c51aac186f77432ea65c552")]
        public The5C51Aac186F77432Ea65C552 The5C51Aac186F77432Ea65C552 { get; set; }

        [JsonProperty("5d2495a886f77425cd51e403")]
        public The5D2495A886F77425Cd51E403 The5D2495A886F77425Cd51E403 { get; set; }

        [JsonProperty("5d24b81486f77439c92d6ba8")]
        public The5D24B81486F77439C92D6Ba8 The5D24B81486F77439C92D6Ba8 { get; set; }

        [JsonProperty("5d25aed386f77442734d25d2")]
        public The5D25Aed386F77442734D25D2 The5D25Aed386F77442734D25D2 { get; set; }

        [JsonProperty("5d25b6be86f77444001e1b89")]
        public The5D25B6Be86F77444001E1B89 The5D25B6Be86F77444001E1B89 { get; set; }

        [JsonProperty("5d25bfd086f77442734d3007")]
        public The5D25Bfd086F77442734D3007 The5D25Bfd086F77442734D3007 { get; set; }

        [JsonProperty("5d25c81b86f77443e625dd71")]
        public The5D25C81B86F77443E625Dd71 The5D25C81B86F77443E625Dd71 { get; set; }

        [JsonProperty("5d25cf2686f77443e75488d4")]
        public The5D25Cf2686F77443E75488D4 The5D25Cf2686F77443E75488D4 { get; set; }

        [JsonProperty("5d25d2c186f77443e35162e5")]
        public The5D25D2C186F77443E35162E5 The5D25D2C186F77443E35162E5 { get; set; }

        [JsonProperty("5d25dae186f77443e55d2f78")]
        public The5D25Dae186F77443E55D2F78 The5D25Dae186F77443E55D2F78 { get; set; }

        [JsonProperty("5d25e29d86f7740a22516326")]
        public The5D25E29D86F7740A22516326 The5D25E29D86F7740A22516326 { get; set; }

        [JsonProperty("5d25e2a986f77409dd5cdf2a")]
        public The5D25E2A986F77409Dd5Cdf2A The5D25E2A986F77409Dd5Cdf2A { get; set; }

        [JsonProperty("5d25e2b486f77409de05bba0")]
        public The5D25E2B486F77409De05Bba0 The5D25E2B486F77409De05Bba0 { get; set; }

        [JsonProperty("5d25e2c386f77443e7549029")]
        public The5D25E2C386F77443E7549029 The5D25E2C386F77443E7549029 { get; set; }

        [JsonProperty("5d25e2cc86f77443e47ae019")]
        public The5D25E2Cc86F77443E47Ae019 The5D25E2Cc86F77443E47Ae019 { get; set; }

        [JsonProperty("5d25e2d886f77442734d335e")]
        public The5D25E2D886F77442734D335E The5D25E2D886F77442734D335E { get; set; }

        [JsonProperty("5d25e2e286f77444001e2e48")]
        public The5D25E2E286F77444001E2E48 The5D25E2E286F77444001E2E48 { get; set; }

        [JsonProperty("5d25e2ee86f77443e35162ea")]
        public The5D25E2Ee86F77443E35162Ea The5D25E2Ee86F77443E35162Ea { get; set; }

        [JsonProperty("5d25e43786f7740a212217fa")]
        public The5D25E43786F7740A212217Fa The5D25E43786F7740A212217Fa { get; set; }

        [JsonProperty("5d25e44386f77409453bce7b")]
        public The5D25E44386F77409453Bce7B The5D25E44386F77409453Bce7B { get; set; }

        [JsonProperty("5d25e44f86f77443e625e385")]
        public The5D25E44F86F77443E625E385 The5D25E44F86F77443E625E385 { get; set; }

        [JsonProperty("5d25e45e86f77408251c4bfa")]
        public The5D25E45E86F77408251C4Bfa The5D25E45E86F77408251C4Bfa { get; set; }

        [JsonProperty("5d25e46e86f77409453bce7c")]
        public The5D25E46E86F77409453Bce7C The5D25E46E86F77409453Bce7C { get; set; }

        [JsonProperty("5d25e48d86f77408251c4bfb")]
        public The5D25E48D86F77408251C4Bfb The5D25E48D86F77408251C4Bfb { get; set; }

        [JsonProperty("5d25e4ad86f77443e625e387")]
        public The5D25E4Ad86F77443E625E387 The5D25E4Ad86F77443E625E387 { get; set; }

        [JsonProperty("5d25e4b786f77408251c4bfc")]
        public The5D25E4B786F77408251C4Bfc The5D25E4B786F77408251C4Bfc { get; set; }

        [JsonProperty("5d25e48186f77443e625e386")]
        public The5D25E48186F77443E625E386 The5D25E48186F77443E625E386 { get; set; }

        [JsonProperty("5d4bec3486f7743cac246665")]
        public The5D4Bec3486F7743Cac246665 The5D4Bec3486F7743Cac246665 { get; set; }

        [JsonProperty("5d25e4ca86f77409dd5cdf2c")]
        public The5D25E4Ca86F77409Dd5Cdf2C The5D25E4Ca86F77409Dd5Cdf2C { get; set; }

        [JsonProperty("5d25e4d586f77443e625e388")]
        public The5D25E4D586F77443E625E388 The5D25E4D586F77443E625E388 { get; set; }

        [JsonProperty("5d6fb2c086f77449da599c24")]
        public The5D6Fb2C086F77449Da599C24 The5D6Fb2C086F77449Da599C24 { get; set; }

        [JsonProperty("5d6fbc2886f77449d825f9d3")]
        public The5D6Fbc2886F77449D825F9D3 The5D6Fbc2886F77449D825F9D3 { get; set; }

        [JsonProperty("5dc53acb86f77469c740c893")]
        public The5Dc53Acb86F77469C740C893 The5Dc53Acb86F77469C740C893 { get; set; }
    }

    public partial class The5936D90786F7742B1420Ba5B
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5936D90786F7742B1420Ba5BConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5936D90786F7742B1420Ba5BConditions
    {
        [JsonProperty("5967379186f77463860dadd6")]
        public string The5967379186F77463860Dadd6 { get; set; }

        [JsonProperty("596737cb86f77463a8115efd")]
        public string The596737Cb86F77463A8115Efd { get; set; }
    }

    public partial class The5936Da9E86F7742D65037Edf
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5936Da9E86F7742D65037EdfConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5936Da9E86F7742D65037EdfConditions
    {
        [JsonProperty("5967920f86f77468d219d632")]
        public string The5967920F86F77468D219D632 { get; set; }

        [JsonProperty("5968ec9986f7741ddd6c1012")]
        public string The5968Ec9986F7741Ddd6C1012 { get; set; }

        [JsonProperty("5975de1f86f7744ca53b7c82")]
        public string The5975De1F86F7744Ca53B7C82 { get; set; }
    }

    public partial class The59674Cd986F7744Ab26E32F2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59674Cd986F7744Ab26E32F2Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59674Cd986F7744Ab26E32F2Conditions
    {
        [JsonProperty("5cb31b6188a450159d330a18")]
        public string The5Cb31B6188A450159D330A18 { get; set; }
    }

    public partial class The59674Eb386F774539F14813A
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59674Eb386F774539F14813AConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59674Eb386F774539F14813AConditions
    {
        [JsonProperty("59674fe586f7744f4e358aa2")]
        public string The59674Fe586F7744F4E358Aa2 { get; set; }

        [JsonProperty("5968929e86f7740d121082d3")]
        public string The5968929E86F7740D121082D3 { get; set; }

        [JsonProperty("5977784486f774285402cf52")]
        public string The5977784486F774285402Cf52 { get; set; }

        [JsonProperty("5978b48b86f7746ef62ef859")]
        public string The5978B48B86F7746Ef62Ef859 { get; set; }
    }

    public partial class The5967530A86F77462Ba22226B
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5967530A86F77462Ba22226BConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5967530A86F77462Ba22226BConditions
    {
        [JsonProperty("596762ec86f77426d3687a87")]
        public string The596762Ec86F77426D3687A87 { get; set; }

        [JsonProperty("5968941f86f7740d1570bbd2")]
        public string The5968941F86F7740D1570Bbd2 { get; set; }

        [JsonProperty("5968943f86f7740d137ebfc2")]
        public string The5968943F86F7740D137Ebfc2 { get; set; }

        [JsonProperty("5968948986f7740d121082d4")]
        public string The5968948986F7740D121082D4 { get; set; }

        [JsonProperty("5a3fbdb086f7745a554f0c31")]
        public string The5A3Fbdb086F7745A554F0C31 { get; set; }
    }

    public partial class The59675D6C86F7740A842Fc482
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59675D6C86F7740A842Fc482Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59675D6C86F7740A842Fc482Conditions
    {
        [JsonProperty("59675e1d86f77414b07f137d")]
        public string The59675E1D86F77414B07F137D { get; set; }

        [JsonProperty("5967938c86f77468cf5f9f54")]
        public string The5967938C86F77468Cf5F9F54 { get; set; }

        [JsonProperty("5968ed3186f77420d2328013")]
        public string The5968Ed3186F77420D2328013 { get; set; }

        [JsonProperty("5a3fbe3a86f77414422e0d9b")]
        public string The5A3Fbe3A86F77414422E0D9B { get; set; }
    }

    public partial class The59675Ea386F77414B32Bded2
    {
        [JsonProperty("conditions")]
        public The59675Ea386F77414B32Bded2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59675Ea386F77414B32Bded2Conditions
    {
        [JsonProperty("596895f986f7740d14064722")]
        public string The596895F986F7740D14064722 { get; set; }

        [JsonProperty("5968962686f7740e7266d973")]
        public string The5968962686F7740E7266D973 { get; set; }

        [JsonProperty("596896c386f7740d1570bbd4")]
        public string The596896C386F7740D1570Bbd4 { get; set; }
    }

    public partial class The596760E186F7741E11214D58
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596760E186F7741E11214D58Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596760E186F7741E11214D58Conditions
    {
        [JsonProperty("5968975586f7740e7266d974")]
        public string The5968975586F7740E7266D974 { get; set; }
    }

    public partial class The5967725E86F774601A446662
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5967725E86F774601A446662Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5967725E86F774601A446662Conditions
    {
        [JsonProperty("5968981986f7740d1648df42")]
        public string The5968981986F7740D1648Df42 { get; set; }

        [JsonProperty("5968988286f7740d14064724")]
        public string The5968988286F7740D14064724 { get; set; }

        [JsonProperty("5a3fc03286f77414d64f9941")]
        public string The5A3Fc03286F77414D64F9941 { get; set; }
    }

    public partial class The5967733E86F774602332Fc84
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5967733E86F774602332Fc84Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5967733E86F774602332Fc84Conditions
    {
        [JsonProperty("59689eb886f7740d137ebfc3")]
        public string The59689Eb886F7740D137Ebfc3 { get; set; }

        [JsonProperty("5968edc086f77420d2328014")]
        public string The5968Edc086F77420D2328014 { get; set; }
    }

    public partial class The59689Ee586F7740D1570Bbd5
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59689Ee586F7740D1570Bbd5Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59689Ee586F7740D1570Bbd5Conditions
    {
        [JsonProperty("59689f7586f7740d14064726")]
        public string The59689F7586F7740D14064726 { get; set; }

        [JsonProperty("5a3fc0ff86f7744d9c2eff86")]
        public string The5A3Fc0Ff86F7744D9C2Eff86 { get; set; }

        [JsonProperty("5ca6026286f77446d87abec3")]
        public string The5Ca6026286F77446D87Abec3 { get; set; }

        [JsonProperty("5cb6f32986f7746ef55e17a0")]
        public string The5Cb6F32986F7746Ef55E17A0 { get; set; }
    }

    public partial class The59689Fbd86F7740D137Ebfc4
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59689Fbd86F7740D137Ebfc4Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59689Fbd86F7740D137Ebfc4Conditions
    {
        [JsonProperty("5968a06486f7740d14064728")]
        public string The5968A06486F7740D14064728 { get; set; }

        [JsonProperty("5a3fb73b86f77458e0324376")]
        public string The5A3Fb73B86F77458E0324376 { get; set; }
    }

    public partial class The5968Eb3186F7741Dde183A4D
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5968Eb3186F7741Dde183A4DConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5968Eb3186F7741Dde183A4DConditions
    {
        [JsonProperty("5968eb9b86f7741ddb481543")]
        public string The5968Eb9B86F7741Ddb481543 { get; set; }
    }

    public partial class The5969F90786F77420D2328015
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5969F90786F77420D2328015Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5969F90786F77420D2328015Conditions
    {
        [JsonProperty("5969f98286f774576d4c9542")]
        public string The5969F98286F774576D4C9542 { get; set; }

        [JsonProperty("5969f99286f77456630ea442")]
        public string The5969F99286F77456630Ea442 { get; set; }

        [JsonProperty("596a212e86f774576d4c95df")]
        public string The596A212E86F774576D4C95Df { get; set; }
    }

    public partial class The5969F9E986F7741Dde183A50
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5969F9E986F7741Dde183A50Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5969F9E986F7741Dde183A50Conditions
    {
        [JsonProperty("5969fa4886f7741ddb481544")]
        public string The5969Fa4886F7741Ddb481544 { get; set; }

        [JsonProperty("5969fa8986f7741ddc2d3154")]
        public string The5969Fa8986F7741Ddc2D3154 { get; set; }

        [JsonProperty("5a3fb8f686f7742384533f10")]
        public string The5A3Fb8F686F7742384533F10 { get; set; }

        [JsonProperty("5a3fb92286f77422b46cdb18")]
        public string The5A3Fb92286F77422B46Cdb18 { get; set; }
    }

    public partial class The596A0E1686F7741Ddf17Dbee
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596A0E1686F7741Ddf17DbeeConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596A0E1686F7741Ddf17DbeeConditions
    {
        [JsonProperty("596a0e7086f7741ddf17dbef")]
        public string The596A0E7086F7741Ddf17Dbef { get; set; }

        [JsonProperty("596a0e8086f7741ddd6c104c")]
        public string The596A0E8086F7741Ddd6C104C { get; set; }

        [JsonProperty("596a0eaf86f774576d4c957f")]
        public string The596A0Eaf86F774576D4C957F { get; set; }

        [JsonProperty("596a113d86f7741ddd6c104d")]
        public string The596A113D86F7741Ddd6C104D { get; set; }
    }

    public partial class The596A101F86F7741Ddb481582
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596A101F86F7741Ddb481582Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596A101F86F7741Ddb481582Conditions
    {
        [JsonProperty("596a10d886f7741ddf17dbf0")]
        public string The596A10D886F7741Ddf17Dbf0 { get; set; }

        [JsonProperty("596a117386f7741ddf17dbf1")]
        public string The596A117386F7741Ddf17Dbf1 { get; set; }
    }

    public partial class The596A1E6C86F7741Ddc2D3206
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596A1E6C86F7741Ddc2D3206Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596A1E6C86F7741Ddc2D3206Conditions
    {
        [JsonProperty("596a1f0486f77456630ea4d2")]
        public string The596A1F0486F77456630Ea4D2 { get; set; }

        [JsonProperty("596a1f1586f77420d2328077")]
        public string The596A1F1586F77420D2328077 { get; set; }
    }

    public partial class The596A204686F774576D4C95De
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596A204686F774576D4C95DeConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596A204686F774576D4C95DeConditions
    {
        [JsonProperty("596a20ac86f7741ddf17dbf4")]
        public string The596A20Ac86F7741Ddf17Dbf4 { get; set; }
    }

    public partial class The596A218586F77420D232807C
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596A218586F77420D232807CConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596A218586F77420D232807CConditions
    {
        [JsonProperty("596b46d886f77457ca186189")]
        public string The596B46D886F77457Ca186189 { get; set; }

        [JsonProperty("596b46ec86f77457c7006f89")]
        public string The596B46Ec86F77457C7006F89 { get; set; }

        [JsonProperty("596b470c86f77457ca18618a")]
        public string The596B470C86F77457Ca18618A { get; set; }

        [JsonProperty("596b472686f77457c7006f8a")]
        public string The596B472686F77457C7006F8A { get; set; }

        [JsonProperty("5979e7a386f7743ec214c7a3")]
        public string The5979E7A386F7743Ec214C7A3 { get; set; }
    }

    public partial class The596B36C586F77450D6045Ad2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596B36C586F77450D6045Ad2Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596B36C586F77450D6045Ad2Conditions
    {
        [JsonProperty("597867e986f7741b265c6bd3")]
        public string The597867E986F7741B265C6Bd3 { get; set; }

        [JsonProperty("5ab8d44c86f7745b2325bd0c")]
        public string The5Ab8D44C86F7745B2325Bd0C { get; set; }
    }

    public partial class The596B43Fb86F77457Ca186186
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596B43Fb86F77457Ca186186Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596B43Fb86F77457Ca186186Conditions
    {
        [JsonProperty("596b44b686f77457cb50ecca")]
        public string The596B44B686F77457Cb50Ecca { get; set; }

        [JsonProperty("596b450986f7745a7e510b54")]
        public string The596B450986F7745A7E510B54 { get; set; }

        [JsonProperty("5a3fbab086f77421593d9bf0")]
        public string The5A3Fbab086F77421593D9Bf0 { get; set; }

        [JsonProperty("5a3fbabc86f774231d75afbe")]
        public string The5A3Fbabc86F774231D75Afbe { get; set; }
    }

    public partial class The596B455186F77457Cb50Eccb
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The596B455186F77457Cb50EccbConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The596B455186F77457Cb50EccbConditions
    {
        [JsonProperty("5c9b5e3f86f7744aab7329b5")]
        public string The5C9B5E3F86F7744Aab7329B5 { get; set; }
    }

    public partial class The5979Ed3886F77431307Dc512
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5979Ed3886F77431307Dc512Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5979Ed3886F77431307Dc512Conditions
    {
        [JsonProperty("5979ee2986f7743ec214c7a4")]
        public string The5979Ee2986F7743Ec214C7A4 { get; set; }

        [JsonProperty("5979ee4586f7743ec214c7a5")]
        public string The5979Ee4586F7743Ec214C7A5 { get; set; }

        [JsonProperty("59819f0986f7744e6d0b7520")]
        public string The59819F0986F7744E6D0B7520 { get; set; }
    }

    public partial class The5979Eee086F774311955E614
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5979Eee086F774311955E614Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5979Eee086F774311955E614Conditions
    {
        [JsonProperty("5979ef4586f77431307dc513")]
        public string The5979Ef4586F77431307Dc513 { get; set; }

        [JsonProperty("5979ef7986f77431307dc514")]
        public string The5979Ef7986F77431307Dc514 { get; set; }
    }

    public partial class The5979F8Bb86F7743Ec214C7A6
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5979F8Bb86F7743Ec214C7A6Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5979F8Bb86F7743Ec214C7A6Conditions
    {
        [JsonProperty("598f0c6386f7746c837802cc")]
        public string The598F0C6386F7746C837802Cc { get; set; }

        [JsonProperty("5b0e766b86f7746bfa618964")]
        public string The5B0E766B86F7746Bfa618964 { get; set; }
    }

    public partial class The5979F9Ba86F7740F6C3Fe9F2
    {
        [JsonProperty("conditions")]
        public The5979F9Ba86F7740F6C3Fe9F2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5979F9Ba86F7740F6C3Fe9F2Conditions
    {
        [JsonProperty("5979fc2686f77426d702a0f2")]
        public string The5979Fc2686F77426D702A0F2 { get; set; }

        [JsonProperty("5979fc5386f77426d702a0f3")]
        public string The5979Fc5386F77426D702A0F3 { get; set; }

        [JsonProperty("5979fc7e86f77426d702a0f4")]
        public string The5979Fc7E86F77426D702A0F4 { get; set; }

        [JsonProperty("5979fc9286f77426d702a0f5")]
        public string The5979Fc9286F77426D702A0F5 { get; set; }

        [JsonProperty("5a3fbbfd86f77459d52a16a8")]
        public string The5A3Fbbfd86F77459D52A16A8 { get; set; }
    }

    public partial class The597A0B2986F77426D66C0633
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The597A0B2986F77426D66C0633Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The597A0B2986F77426D66C0633Conditions
    {
        [JsonProperty("597a0bb486f77426d66c0634")]
        public string The597A0Bb486F77426D66C0634 { get; set; }

        [JsonProperty("597a0bdb86f7742717106d12")]
        public string The597A0Bdb86F7742717106D12 { get; set; }

        [JsonProperty("597a0be986f774273b74f673")]
        public string The597A0Be986F774273B74F673 { get; set; }

        [JsonProperty("597a0bf886f7742717106d13")]
        public string The597A0Bf886F7742717106D13 { get; set; }
    }

    public partial class The597A0E5786F77426D66C0636
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The597A0E5786F77426D66C0636Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The597A0E5786F77426D66C0636Conditions
    {
        [JsonProperty("597a15b386f774799e5cd152")]
        public string The597A15B386F774799E5Cd152 { get; set; }

        [JsonProperty("597a15c386f77405ba6887d2")]
        public string The597A15C386F77405Ba6887D2 { get; set; }
    }

    public partial class The597A0F5686F774273B74F676
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The597A0F5686F774273B74F676Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The597A0F5686F774273B74F676Conditions
    {
        [JsonProperty("59b242ea86f7741e6e0e7a86")]
        public string The59B242Ea86F7741E6E0E7A86 { get; set; }

        [JsonProperty("59b95de686f77418457056ef")]
        public string The59B95De686F77418457056Ef { get; set; }

        [JsonProperty("5a3fbc9586f77459d52a16c4")]
        public string The5A3Fbc9586F77459D52A16C4 { get; set; }
    }

    public partial class The597A160786F77477531D39D2
    {
        [JsonProperty("conditions")]
        public The597A160786F77477531D39D2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The597A160786F77477531D39D2Conditions
    {
        [JsonProperty("597a166d86f774779c70e8a4")]
        public string The597A166D86F774779C70E8A4 { get; set; }

        [JsonProperty("5998366886f77455853b2d9f")]
        public string The5998366886F77455853B2D9F { get; set; }

        [JsonProperty("5a3fc1f286f7744ccc15d643")]
        public string The5A3Fc1F286F7744Ccc15D643 { get; set; }
    }

    public partial class The597A171586F77405Ba6887D3
    {
        [JsonProperty("conditions")]
        public The597A171586F77405Ba6887D3Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The597A171586F77405Ba6887D3Conditions
    {
        [JsonProperty("597a178786f774799e5cd155")]
        public string The597A178786F774799E5Cd155 { get; set; }

        [JsonProperty("5998360886f77456936817f3")]
        public string The5998360886F77456936817F3 { get; set; }

        [JsonProperty("5a3fbec386f77413bd5fc20a")]
        public string The5A3Fbec386F77413Bd5Fc20A { get; set; }
    }

    public partial class The59C124D686F774189B3C843F
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59C124D686F774189B3C843FConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59C124D686F774189B3C843FConditions
    {
        [JsonProperty("59c128b986f77415037680df")]
        public string The59C128B986F77415037680Df { get; set; }

        [JsonProperty("59c128cc86f774189b3c84b5")]
        public string The59C128Cc86F774189B3C84B5 { get; set; }

        [JsonProperty("59c128d886f77414fe7f1a64")]
        public string The59C128D886F77414Fe7F1A64 { get; set; }

        [JsonProperty("59c128f386f774189b3c84bb")]
        public string The59C128F386F774189B3C84Bb { get; set; }

        [JsonProperty("5c92184386f7746afa2e7840")]
        public string The5C92184386F7746Afa2E7840 { get; set; }
    }

    public partial class The59C50A9E86F7745Fef66F4Ff
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59C50A9E86F7745Fef66F4FfConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59C50A9E86F7745Fef66F4FfConditions
    {
        [JsonProperty("59674d5186f00443b872d5f7")]
        public string The59674D5186F00443B872D5F7 { get; set; }
    }

    public partial class The59C50C8886F7745Fed3193Bf
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59C50C8886F7745Fed3193BfConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59C50C8886F7745Fed3193BfConditions
    {
        [JsonProperty("59c50f1686f77412ef2c01e7")]
        public string The59C50F1686F77412Ef2C01E7 { get; set; }

        [JsonProperty("59624d5386f77446b872d5f7")]
        public string The59624D5386F77446B872D5F7 { get; set; }

        [JsonProperty("5ca5e54186f774456930b9a3")]
        public string The5Ca5E54186F774456930B9A3 { get; set; }

        [JsonProperty("5cb5e2ff86f7746ef64c979b")]
        public string The5Cb5E2Ff86F7746Ef64C979B { get; set; }
    }

    public partial class The59C512Ad86F7741F0D09De9B
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59C512Ad86F7741F0D09De9BConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59C512Ad86F7741F0D09De9BConditions
    {
        [JsonProperty("59674d5186f77446b852d5f7")]
        public string The59674D5186F77446B852D5F7 { get; set; }
    }

    public partial class The59C9392986F7742F6923Add2
    {
        [JsonProperty("conditions")]
        public The59C9392986F7742F6923Add2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59C9392986F7742F6923Add2Conditions
    {
        [JsonProperty("59c93bdb86f7742a19140434")]
        public string The59C93Bdb86F7742A19140434 { get; set; }

        [JsonProperty("59c93c1986f7742a424eaa33")]
        public string The59C93C1986F7742A424Eaa33 { get; set; }

        [JsonProperty("59c93cbb86f7742a19140435")]
        public string The59C93Cbb86F7742A19140435 { get; set; }

        [JsonProperty("59c93cea86f7742a08623162")]
        public string The59C93Cea86F7742A08623162 { get; set; }

        [JsonProperty("59c93d4e86f774496b698953")]
        public string The59C93D4E86F774496B698953 { get; set; }

        [JsonProperty("59c93d8086f7742a19140436")]
        public string The59C93D8086F7742A19140436 { get; set; }

        [JsonProperty("59c93d9c86f7742f6923add3")]
        public string The59C93D9C86F7742F6923Add3 { get; set; }

        [JsonProperty("59c93dbf86f7742a424eaa34")]
        public string The59C93Dbf86F7742A424Eaa34 { get; set; }
    }

    public partial class The59C93E8E86F7742A406989C4
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59C93E8E86F7742A406989C4Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59C93E8E86F7742A406989C4Conditions
    {
        [JsonProperty("596a10d886f7741ddf11dbf0")]
        public string The596A10D886F7741Ddf11Dbf0 { get; set; }
    }

    public partial class The59Ca1A6286F774509A270942
    {
        [JsonProperty("conditions")]
        public The59Ca1A6286F774509A270942Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59Ca1A6286F774509A270942Conditions
    {
        [JsonProperty("59ca1b1b86f7741b067dba42")]
        public string The59Ca1B1B86F7741B067Dba42 { get; set; }

        [JsonProperty("59ca1b4f86f774509a270943")]
        public string The59Ca1B4F86F774509A270943 { get; set; }
    }

    public partial class The59Ca264786F77445A80Ed044
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59Ca264786F77445A80Ed044Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59Ca264786F77445A80Ed044Conditions
    {
        [JsonProperty("59ca27f786f77445aa0ddc14")]
        public string The59Ca27F786F77445Aa0Ddc14 { get; set; }

        [JsonProperty("59674d5986f77446b872d5f7")]
        public string The59674D5986F77446B872D5F7 { get; set; }

        [JsonProperty("59ca293c86f91445a80ed047")]
        public string The59Ca293C86F91445A80Ed047 { get; set; }

        [JsonProperty("59ca29ab86f77445ab431c86")]
        public string The59Ca29Ab86F77445Ab431C86 { get; set; }
    }

    public partial class The59Ca29Fb86F77445Ab465C87
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59Ca29Fb86F77445Ab465C87Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59Ca29Fb86F77445Ab465C87Conditions
    {
        [JsonProperty("59ca2c3086f77445aa0ddc15")]
        public string The59Ca2C3086F77445Aa0Ddc15 { get; set; }

        [JsonProperty("59ca2cbe86f7740fe95c3e52")]
        public string The59Ca2Cbe86F7740Fe95C3E52 { get; set; }

        [JsonProperty("59ca293c86f77445a80ed147")]
        public string The59Ca293C86F77445A80Ed147 { get; set; }

        [JsonProperty("59ca29ab86f77445ab133c86")]
        public string The59Ca29Ab86F77445Ab133C86 { get; set; }

        [JsonProperty("59ca2bdc86f77445a80ed148")]
        public string The59Ca2Bdc86F77445A80Ed148 { get; set; }

        [JsonProperty("59ca2c9e86f77428ea721232")]
        public string The59Ca2C9E86F77428Ea721232 { get; set; }

        [JsonProperty("5c922dde86f77438500a0fec")]
        public string The5C922Dde86F77438500A0Fec { get; set; }
    }

    public partial class The59Ca2Eb686F77445A80Ed049
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The59Ca2Eb686F77445A80Ed049Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59Ca2Eb686F77445A80Ed049Conditions
    {
        [JsonProperty("59ca2fba86f77445e4732b25")]
        public string The59Ca2Fba86F77445E4732B25 { get; set; }

        [JsonProperty("5b05468f86f774030379eb74")]
        public string The5B05468F86F774030379Eb74 { get; set; }

        [JsonProperty("5b0548e686f7740306753506")]
        public string The5B0548E686F7740306753506 { get; set; }

        [JsonProperty("5cb3393888a4505d02042061")]
        public string The5Cb3393888A4505D02042061 { get; set; }

        [JsonProperty("5cb3397c88a450159a723d79")]
        public string The5Cb3397C88A450159A723D79 { get; set; }
    }

    public partial class The59F9Da6786F774714230D751
    {
        [JsonProperty("conditions")]
        public The59F9Da6786F774714230D751Conditions Conditions { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The59F9Da6786F774714230D751Conditions
    {
    }

    public partial class The5A03153686F77442D90E2171
    {
        [JsonProperty("conditions")]
        public The5A03153686F77442D90E2171Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A03153686F77442D90E2171Conditions
    {
        [JsonProperty("5c9a17c686f7747dbe2da3c1")]
        public string The5C9A17C686F7747Dbe2Da3C1 { get; set; }
    }

    public partial class The5A03173786F77451Cb427172
    {
        [JsonProperty("conditions")]
        public The5A03173786F77451Cb427172Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A03173786F77451Cb427172Conditions
    {
        [JsonProperty("5a0317da86f77451cb427295")]
        public string The5A0317Da86F77451Cb427295 { get; set; }

        [JsonProperty("5a0325f286f7744384509230")]
        public string The5A0325F286F7744384509230 { get; set; }

        [JsonProperty("5a37d80986f774245c063b69")]
        public string The5A37D80986F774245C063B69 { get; set; }
    }

    public partial class The5A0327Ba86F77456B9154236
    {
        [JsonProperty("conditions")]
        public The5A0327Ba86F77456B9154236Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A0327Ba86F77456B9154236Conditions
    {
        [JsonProperty("5a03282286f77456b91542ef")]
        public string The5A03282286F77456B91542Ef { get; set; }

        [JsonProperty("5a03289686f7745dbc6c5063")]
        public string The5A03289686F7745Dbc6C5063 { get; set; }

        [JsonProperty("5a0328b086f77457a7099ea5")]
        public string The5A0328B086F77457A7099Ea5 { get; set; }

        [JsonProperty("5a0328cb86f77456b91543b8")]
        public string The5A0328Cb86F77456B91543B8 { get; set; }

        [JsonProperty("5a0328f586f774580168ced4")]
        public string The5A0328F586F774580168Ced4 { get; set; }

        [JsonProperty("5a03290586f774584d1594c4")]
        public string The5A03290586F774584D1594C4 { get; set; }

        [JsonProperty("5a280b3c86f7741b16366337")]
        public string The5A280B3C86F7741B16366337 { get; set; }

        [JsonProperty("5a280b5486f7741f751bfeea")]
        public string The5A280B5486F7741F751Bfeea { get; set; }
    }

    public partial class The5A03296886F774569778596A
    {
        [JsonProperty("conditions")]
        public The5A03296886F774569778596AConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A03296886F774569778596AConditions
    {
        [JsonProperty("5a3ba62786f7742c9d4f5ee9")]
        public string The5A3Ba62786F7742C9D4F5Ee9 { get; set; }

        [JsonProperty("5a3ba65f86f7743af1475f11")]
        public string The5A3Ba65F86F7743Af1475F11 { get; set; }

        [JsonProperty("5c94f65286f77455185027ee")]
        public string The5C94F65286F77455185027Ee { get; set; }
    }

    public partial class The5A0449D586F77474E66227B7
    {
        [JsonProperty("conditions")]
        public The5A0449D586F77474E66227B7Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A0449D586F77474E66227B7Conditions
    {
        [JsonProperty("5a044a6c86f7747370402d91")]
        public string The5A044A6C86F7747370402D91 { get; set; }

        [JsonProperty("5a280f8d86f774141b501756")]
        public string The5A280F8D86F774141B501756 { get; set; }
    }

    public partial class The5A27B75B86F7742E97191958
    {
        [JsonProperty("conditions")]
        public The5A27B75B86F7742E97191958Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27B75B86F7742E97191958Conditions
    {
        [JsonProperty("5a27d81a86f774472a6e0456")]
        public string The5A27D81A86F774472A6E0456 { get; set; }

        [JsonProperty("5a27d85286f77448d82084e7")]
        public string The5A27D85286F77448D82084E7 { get; set; }

        [JsonProperty("5a3ba11786f7742c9d4f5d29")]
        public string The5A3Ba11786F7742C9D4F5D29 { get; set; }

        [JsonProperty("5bcf241486f7746a4959344a")]
        public string The5Bcf241486F7746A4959344A { get; set; }

        [JsonProperty("5be40b2a88a45079e30e92b5")]
        public string The5Be40B2A88A45079E30E92B5 { get; set; }

        [JsonProperty("5c93794086f7740a13567867")]
        public string The5C93794086F7740A13567867 { get; set; }
    }

    public partial class The5A27B7A786F774579C3Eb376
    {
        [JsonProperty("conditions")]
        public The5A27B7A786F774579C3Eb376Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27B7A786F774579C3Eb376Conditions
    {
        [JsonProperty("5a27e73f86f7740fb275c94b")]
        public string The5A27E73F86F7740Fb275C94B { get; set; }

        [JsonProperty("5a27e75886f7740aef4a9157")]
        public string The5A27E75886F7740Aef4A9157 { get; set; }

        [JsonProperty("5a29653986f77406a3435b26")]
        public string The5A29653986F77406A3435B26 { get; set; }

        [JsonProperty("5c9394a986f7741228714be3")]
        public string The5C9394A986F7741228714Be3 { get; set; }
    }

    public partial class The5A27B7D686F77460D847E6A6
    {
        [JsonProperty("conditions")]
        public The5A27B7D686F77460D847E6A6Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27B7D686F77460D847E6A6Conditions
    {
        [JsonProperty("5a27fc8186f7746371546243")]
        public string The5A27Fc8186F7746371546243 { get; set; }

        [JsonProperty("5a27fc9686f774675744bb60")]
        public string The5A27Fc9686F774675744Bb60 { get; set; }

        [JsonProperty("5a37e8ae86f77415076b401d")]
        public string The5A37E8Ae86F77415076B401D { get; set; }

        [JsonProperty("5c939d0e86f774185203c4c3")]
        public string The5C939D0E86F774185203C4C3 { get; set; }
    }

    public partial class The5A27B80086F774429A5D7E20
    {
        [JsonProperty("conditions")]
        public The5A27B80086F774429A5D7E20Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27B80086F774429A5D7E20Conditions
    {
        [JsonProperty("5a27ffb186f774192932b3d5")]
        public string The5A27Ffb186F774192932B3D5 { get; set; }

        [JsonProperty("5a27ffc786f77415ca58ae47")]
        public string The5A27Ffc786F77415Ca58Ae47 { get; set; }

        [JsonProperty("5a294f1686f774340c7b7e4a")]
        public string The5A294F1686F774340C7B7E4A { get; set; }

        [JsonProperty("5a294f3386f77433e923f9cd")]
        public string The5A294F3386F77433E923F9Cd { get; set; }

        [JsonProperty("5a3ba34286f7744eb240406a")]
        public string The5A3Ba34286F7744Eb240406A { get; set; }

        [JsonProperty("5a3ba3b086f7745ab1081101")]
        public string The5A3Ba3B086F7745Ab1081101 { get; set; }
    }

    public partial class The5A27B87686F77460De0252A8
    {
        [JsonProperty("conditions")]
        public The5A27B87686F77460De0252A8Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27B87686F77460De0252A8Conditions
    {
        [JsonProperty("5a28017786f77452f6318b1b")]
        public string The5A28017786F77452F6318B1B { get; set; }

        [JsonProperty("5a2801f986f774531b679875")]
        public string The5A2801F986F774531B679875 { get; set; }

        [JsonProperty("5a28023f86f774528903dd1e")]
        public string The5A28023F86F774528903Dd1E { get; set; }

        [JsonProperty("5a3ba47986f7744df8667505")]
        public string The5A3Ba47986F7744Df8667505 { get; set; }

        [JsonProperty("5a3ba4ba86f7744df759b1e5")]
        public string The5A3Ba4Ba86F7744Df759B1E5 { get; set; }

        [JsonProperty("5c939f2186f774122b6e7854")]
        public string The5C939F2186F774122B6E7854 { get; set; }

        [JsonProperty("5c9a170386f77438c80164eb")]
        public string The5C9A170386F77438C80164Eb { get; set; }

        [JsonProperty("5cb5fd3d86f7746ef64ca33c")]
        public string The5Cb5Fd3D86F7746Ef64Ca33C { get; set; }
    }

    public partial class The5A27B9De86F77464E5044585
    {
        [JsonProperty("conditions")]
        public The5A27B9De86F77464E5044585Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27B9De86F77464E5044585Conditions
    {
        [JsonProperty("5a28051286f7740eb10bac04")]
        public string The5A28051286F7740Eb10Bac04 { get; set; }

        [JsonProperty("5a3ba51d86f7743af1475c3a")]
        public string The5A3Ba51D86F7743Af1475C3A { get; set; }
    }

    public partial class The5A27Ba1C86F77461Ea5A3C56
    {
        [JsonProperty("conditions")]
        public The5A27Ba1C86F77461Ea5A3C56Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Ba1C86F77461Ea5A3C56Conditions
    {
        [JsonProperty("5a2806b386f77420062f0fbd")]
        public string The5A2806B386F77420062F0Fbd { get; set; }

        [JsonProperty("5a2806e086f774291b084041")]
        public string The5A2806E086F774291B084041 { get; set; }

        [JsonProperty("5a2806f886f774513d3e69f5")]
        public string The5A2806F886F774513D3E69F5 { get; set; }
    }

    public partial class The5A27Ba9586F7741B543D8E85
    {
        [JsonProperty("conditions")]
        public The5A27Ba9586F7741B543D8E85Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Ba9586F7741B543D8E85Conditions
    {
        [JsonProperty("5a28127b86f7743808504ecc")]
        public string The5A28127B86F7743808504Ecc { get; set; }
    }

    public partial class The5A27Bafb86F7741C73584017
    {
        [JsonProperty("conditions")]
        public The5A27Bafb86F7741C73584017Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bafb86F7741C73584017Conditions
    {
        [JsonProperty("5a28151986f77466837984c9")]
        public string The5A28151986F77466837984C9 { get; set; }

        [JsonProperty("5a28152b86f7740ab40845fb")]
        public string The5A28152B86F7740Ab40845Fb { get; set; }

        [JsonProperty("5a28157486f77405822f36c1")]
        public string The5A28157486F77405822F36C1 { get; set; }

        [JsonProperty("5a28159686f77405710b1e65")]
        public string The5A28159686F77405710B1E65 { get; set; }

        [JsonProperty("5a2815c186f77405822f36ce")]
        public string The5A2815C186F77405822F36Ce { get; set; }

        [JsonProperty("5a2815d786f774725a5893a6")]
        public string The5A2815D786F774725A5893A6 { get; set; }

        [JsonProperty("5a28163686f7740ab4084611")]
        public string The5A28163686F7740Ab4084611 { get; set; }

        [JsonProperty("5a28164786f77405822f36d9")]
        public string The5A28164786F77405822F36D9 { get; set; }
    }

    public partial class The5A27Bb1E86F7741F27621B7E
    {
        [JsonProperty("conditions")]
        public The5A27Bb1E86F7741F27621B7EConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bb1E86F7741F27621B7EConditions
    {
        [JsonProperty("5a28183186f774398675d127")]
        public string The5A28183186F774398675D127 { get; set; }

        [JsonProperty("5a28184c86f774376e43772a")]
        public string The5A28184C86F774376E43772A { get; set; }
    }

    public partial class The5A27Bb3D86F77411Ea361A21
    {
        [JsonProperty("conditions")]
        public The5A27Bb3D86F77411Ea361A21Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bb3D86F77411Ea361A21Conditions
    {
        [JsonProperty("5a2819c886f77460ba564f38")]
        public string The5A2819C886F77460Ba564F38 { get; set; }

        [JsonProperty("5a2e966286f7742f6c4f27a6")]
        public string The5A2E966286F7742F6C4F27A6 { get; set; }

        [JsonProperty("5a3ba76486f7744d39436da2")]
        public string The5A3Ba76486F7744D39436Da2 { get; set; }
    }

    public partial class The5A27Bb5986F7741Dfb660900
    {
        [JsonProperty("conditions")]
        public The5A27Bb5986F7741Dfb660900Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bb5986F7741Dfb660900Conditions
    {
        [JsonProperty("5a37de5486f7741535394d69")]
        public string The5A37De5486F7741535394D69 { get; set; }

        [JsonProperty("5a3ba7db86f7744f0e568c9c")]
        public string The5A3Ba7Db86F7744F0E568C9C { get; set; }
    }

    public partial class The5A27Bb8386F7741C770D2D0A
    {
        [JsonProperty("conditions")]
        public The5A27Bb8386F7741C770D2D0AConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bb8386F7741C770D2D0AConditions
    {
        [JsonProperty("5c9de99286f7741ced54c902")]
        public string The5C9De99286F7741Ced54C902 { get; set; }
    }

    public partial class The5A27Bbf886F774333A418Eeb
    {
        [JsonProperty("conditions")]
        public The5A27Bbf886F774333A418EebConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bbf886F774333A418EebConditions
    {
        [JsonProperty("5a281efe86f7745bc42005cc")]
        public string The5A281Efe86F7745Bc42005Cc { get; set; }

        [JsonProperty("5a37dc0c86f77469da071ef2")]
        public string The5A37Dc0C86F77469Da071Ef2 { get; set; }

        [JsonProperty("5a3ba97386f77459df27d10e")]
        public string The5A3Ba97386F77459Df27D10E { get; set; }
    }

    public partial class The5A27Bc1586F7741F6D40Fa2F
    {
        [JsonProperty("conditions")]
        public The5A27Bc1586F7741F6D40Fa2FConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bc1586F7741F6D40Fa2FConditions
    {
        [JsonProperty("5a37db0c86f7745b8f4be68a")]
        public string The5A37Db0C86F7745B8F4Be68A { get; set; }

        [JsonProperty("5a3baa2586f7745b791b72fa")]
        public string The5A3Baa2586F7745B791B72Fa { get; set; }
    }

    public partial class The5A27Bc3686F7741C73584026
    {
        [JsonProperty("conditions")]
        public The5A27Bc3686F7741C73584026Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bc3686F7741C73584026Conditions
    {
        [JsonProperty("5a28221e86f7741d5b719624")]
        public string The5A28221E86F7741D5B719624 { get; set; }

        [JsonProperty("5a28223786f7741c7a0b5401")]
        public string The5A28223786F7741C7A0B5401 { get; set; }
    }

    public partial class The5A27Bc6986F7741C7358402B
    {
        [JsonProperty("conditions")]
        public The5A27Bc6986F7741C7358402BConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bc6986F7741C7358402BConditions
    {
        [JsonProperty("5a2822de86f7740a245249ce")]
        public string The5A2822De86F7740A245249Ce { get; set; }

        [JsonProperty("5a2e958d86f77416be092111")]
        public string The5A2E958D86F77416Be092111 { get; set; }
    }

    public partial class The5A27Bc8586F7741B543D8Ea4
    {
        [JsonProperty("conditions")]
        public The5A27Bc8586F7741B543D8Ea4Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27Bc8586F7741B543D8Ea4Conditions
    {
        [JsonProperty("5a28235e86f7741da250b438")]
        public string The5A28235E86F7741Da250B438 { get; set; }
    }

    public partial class The5A27C99A86F7747D2C6Bdd8E
    {
        [JsonProperty("conditions")]
        public The5A27C99A86F7747D2C6Bdd8EConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27C99A86F7747D2C6Bdd8EConditions
    {
        [JsonProperty("5a27cf8286f7747e0b237470")]
        public string The5A27Cf8286F7747E0B237470 { get; set; }

        [JsonProperty("5a27cfd586f7747e4b2ab23f")]
        public string The5A27Cfd586F7747E4B2Ab23F { get; set; }

        [JsonProperty("5a27d04686f7747e2b71be4f")]
        public string The5A27D04686F7747E2B71Be4F { get; set; }

        [JsonProperty("5a27d09c86f7747e0b23747a")]
        public string The5A27D09C86F7747E0B23747A { get; set; }

        [JsonProperty("5be0198686f774595412d9c4")]
        public string The5Be0198686F774595412D9C4 { get; set; }
    }

    public partial class The5A27D2Af86F7744E1115B323
    {
        [JsonProperty("conditions")]
        public The5A27D2Af86F7744E1115B323Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A27D2Af86F7744E1115B323Conditions
    {
        [JsonProperty("5a27d34586f7744e1115b327")]
        public string The5A27D34586F7744E1115B327 { get; set; }
    }

    public partial class The5A5642Ce86F77445C63C3419
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("conditions")]
        public The5A5642Ce86F77445C63C3419Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A5642Ce86F77445C63C3419Conditions
    {
        [JsonProperty("5a56489d86f7740cfe70eba2")]
        public string The5A56489D86F7740Cfe70Eba2 { get; set; }

        [JsonProperty("5db9e0bf60635026b067afa6")]
        public string The5Db9E0Bf60635026B067Afa6 { get; set; }

        [JsonProperty("5db9e0d3b1325a429a5d7d55")]
        public string The5Db9E0D3B1325A429A5D7D55 { get; set; }

        [JsonProperty("5db9e0e0c5624a3ce7239a88")]
        public string The5Db9E0E0C5624A3Ce7239A88 { get; set; }
    }

    public partial class The5A68661A86F774500F48Afb0
    {
        [JsonProperty("conditions")]
        public The5A68661A86F774500F48Afb0Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A68661A86F774500F48Afb0Conditions
    {
        [JsonProperty("5a6873bc86f7741f8d4589a3")]
        public string The5A6873Bc86F7741F8D4589A3 { get; set; }

        [JsonProperty("5a6873d786f7743ad1151d6e")]
        public string The5A6873D786F7743Ad1151D6E { get; set; }

        [JsonProperty("5a6873ec86f7743cc55d8622")]
        public string The5A6873Ec86F7743Cc55D8622 { get; set; }

        [JsonProperty("5a6874a186f77474f43809fd")]
        public string The5A6874A186F77474F43809Fd { get; set; }
    }

    public partial class The5A68663E86F774501078F78A
    {
        [JsonProperty("conditions")]
        public The5A68663E86F774501078F78AConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A68663E86F774501078F78AConditions
    {
        [JsonProperty("5a68760f86f7743cc55d8709")]
        public string The5A68760F86F7743Cc55D8709 { get; set; }

        [JsonProperty("5a68763786f77474c33a40a1")]
        public string The5A68763786F77474C33A40A1 { get; set; }

        [JsonProperty("5a68764c86f77474c4269f3c")]
        public string The5A68764C86F77474C4269F3C { get; set; }
    }

    public partial class The5A68665C86F774255929B4C7
    {
        [JsonProperty("conditions")]
        public The5A68665C86F774255929B4C7Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A68665C86F774255929B4C7Conditions
    {
        [JsonProperty("5a68770f86f774747d4b0d8b")]
        public string The5A68770F86F774747D4B0D8B { get; set; }

        [JsonProperty("5a68776786f774759f1f55f6")]
        public string The5A68776786F774759F1F55F6 { get; set; }

        [JsonProperty("5a68777586f774747d4b0d9e")]
        public string The5A68777586F774747D4B0D9E { get; set; }

        [JsonProperty("5a68778c86f77423391f38f0")]
        public string The5A68778C86F77423391F38F0 { get; set; }
    }

    public partial class The5A68667486F7742607157D28
    {
        [JsonProperty("conditions")]
        public The5A68667486F7742607157D28Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A68667486F7742607157D28Conditions
    {
        [JsonProperty("5a6878e886f7745e65687985")]
        public string The5A6878E886F7745E65687985 { get; set; }
    }

    public partial class The5A68669A86F774255929B4D4
    {
        [JsonProperty("conditions")]
        public The5A68669A86F774255929B4D4Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5A68669A86F774255929B4D4Conditions
    {
        [JsonProperty("5a6879be86f774284429b1bb")]
        public string The5A6879Be86F774284429B1Bb { get; set; }

        [JsonProperty("5a687a1c86f7745f2152168c")]
        public string The5A687A1C86F7745F2152168C { get; set; }
    }

    public partial class The5Ac23C6186F7741247042Bad
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac23C6186F7741247042BadConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac23C6186F7741247042BadConditions
    {
        [JsonProperty("5accd5e386f77463027e9397")]
        public string The5Accd5E386F77463027E9397 { get; set; }

        [JsonProperty("5acf375f86f7741bb8377ff7")]
        public string The5Acf375F86F7741Bb8377Ff7 { get; set; }
    }

    public partial class The5Ac2426C86F774138762Edfe
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac2426C86F774138762EdfeConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac2426C86F774138762EdfeConditions
    {
        [JsonProperty("5accd9b686f774112d7173d1")]
        public string The5Accd9B686F774112D7173D1 { get; set; }

        [JsonProperty("5acf37a186f7741843346d0c")]
        public string The5Acf37A186F7741843346D0C { get; set; }

        [JsonProperty("5acf37ad86f77418420befe6")]
        public string The5Acf37Ad86F77418420Befe6 { get; set; }
    }

    public partial class The5Ac2428686F77412450B42Bf
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac2428686F77412450B42BfConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac2428686F77412450B42BfConditions
    {
        [JsonProperty("5accde3686f7740cea1b7ec2")]
        public string The5Accde3686F7740Cea1B7Ec2 { get; set; }

        [JsonProperty("5acf37d486f7741841752ffc")]
        public string The5Acf37D486F7741841752Ffc { get; set; }

        [JsonProperty("5acf37df86f7741bb8377ffc")]
        public string The5Acf37Df86F7741Bb8377Ffc { get; set; }
    }

    public partial class The5Ac242Ab86F77412464F68B4
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac242Ab86F77412464F68B4Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac242Ab86F77412464F68B4Conditions
    {
        [JsonProperty("5acce08b86f7745f8521fa64")]
        public string The5Acce08B86F7745F8521Fa64 { get; set; }

        [JsonProperty("5acf381a86f7741ce21f9aee")]
        public string The5Acf381A86F7741Ce21F9Aee { get; set; }

        [JsonProperty("5acf382686f7741cdb2f7ef6")]
        public string The5Acf382686F7741Cdb2F7Ef6 { get; set; }
    }

    public partial class The5Ac244C486F77413E12Cf945
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac244C486F77413E12Cf945Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac244C486F77413E12Cf945Conditions
    {
        [JsonProperty("5acce11786f77411ed6fa6eb")]
        public string The5Acce11786F77411Ed6Fa6Eb { get; set; }

        [JsonProperty("5acf383686f7741bb8377fff")]
        public string The5Acf383686F7741Bb8377Fff { get; set; }

        [JsonProperty("5acf383d86f7741bb8378000")]
        public string The5Acf383D86F7741Bb8378000 { get; set; }
    }

    public partial class The5Ac244Eb86F7741356335Af1
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac244Eb86F7741356335Af1Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac244Eb86F7741356335Af1Conditions
    {
        [JsonProperty("5accdfdb86f77412265cbfc9")]
        public string The5Accdfdb86F77412265Cbfc9 { get; set; }

        [JsonProperty("5acf37fa86f7741844039008")]
        public string The5Acf37Fa86F7741844039008 { get; set; }

        [JsonProperty("5acf380186f7741844039009")]
        public string The5Acf380186F7741844039009 { get; set; }
    }

    public partial class The5Ac345Dc86F774288030817F
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac345Dc86F774288030817FConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac345Dc86F774288030817FConditions
    {
        [JsonProperty("5ac7a4ba86f77409f3423628")]
        public string The5Ac7A4Ba86F77409F3423628 { get; set; }

        [JsonProperty("5ac7a51a86f774738a4ffc96")]
        public string The5Ac7A51A86F774738A4Ffc96 { get; set; }

        [JsonProperty("5ac7a5d586f774383111ee63")]
        public string The5Ac7A5D586F774383111Ee63 { get; set; }

        [JsonProperty("5acf388786f7741cdb2f7ef9")]
        public string The5Acf388786F7741Cdb2F7Ef9 { get; set; }

        [JsonProperty("5acf390d86f774184403900f")]
        public string The5Acf390D86F774184403900F { get; set; }
    }

    public partial class The5Ac3460C86F7742880308185
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac3460C86F7742880308185Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac3460C86F7742880308185Conditions
    {
        [JsonProperty("5ac502a786f7740bde1b000c")]
        public string The5Ac502A786F7740Bde1B000C { get; set; }

        [JsonProperty("5ac5055a86f7745cae22b582")]
        public string The5Ac5055A86F7745Cae22B582 { get; set; }

        [JsonProperty("5ac505c386f7740be0424d19")]
        public string The5Ac505C386F7740Be0424D19 { get; set; }

        [JsonProperty("5ac505e186f7740bdf2ceabe")]
        public string The5Ac505E186F7740Bdf2Ceabe { get; set; }

        [JsonProperty("5ac5061386f77417e429ce7a")]
        public string The5Ac5061386F77417E429Ce7A { get; set; }

        [JsonProperty("5ac5062586f774587c327395")]
        public string The5Ac5062586F774587C327395 { get; set; }

        [JsonProperty("5acf3b0986f7741bb8378499")]
        public string The5Acf3B0986F7741Bb8378499 { get; set; }

        [JsonProperty("5acf3b1286f77418420bf36b")]
        public string The5Acf3B1286F77418420Bf36B { get; set; }
    }

    public partial class The5Ac3462B86F7741D6118B983
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac3462B86F7741D6118B983Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac3462B86F7741D6118B983Conditions
    {
        [JsonProperty("5ac6240786f77417204ca2b9")]
        public string The5Ac6240786F77417204Ca2B9 { get; set; }

        [JsonProperty("5ac6248586f77416781dd3a3")]
        public string The5Ac6248586F77416781Dd3A3 { get; set; }

        [JsonProperty("5ac624b286f77416781dd3ac")]
        public string The5Ac624B286F77416781Dd3Ac { get; set; }

        [JsonProperty("5acf3b2586f7741cdb2f7f8b")]
        public string The5Acf3B2586F7741Cdb2F7F8B { get; set; }

        [JsonProperty("5acf3b2a86f7741cdb2f7f8c")]
        public string The5Acf3B2A86F7741Cdb2F7F8C { get; set; }
    }

    public partial class The5Ac3464C86F7741D651D6877
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac3464C86F7741D651D6877Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac3464C86F7741D651D6877Conditions
    {
        [JsonProperty("5ac5081086f7740bde1b002f")]
        public string The5Ac5081086F7740Bde1B002F { get; set; }

        [JsonProperty("5ac5082586f77418804f7d4c")]
        public string The5Ac5082586F77418804F7D4C { get; set; }

        [JsonProperty("5ac5083d86f7740be2744eed")]
        public string The5Ac5083D86F7740Be2744Eed { get; set; }

        [JsonProperty("5ac5084d86f7740bde1b0031")]
        public string The5Ac5084D86F7740Bde1B0031 { get; set; }

        [JsonProperty("5acf3b3486f7741ce21f9b06")]
        public string The5Acf3B3486F7741Ce21F9B06 { get; set; }

        [JsonProperty("5acf3b3b86f7741ce21f9b08")]
        public string The5Acf3B3B86F7741Ce21F9B08 { get; set; }
    }

    public partial class The5Ac3467986F7741D6224Abc2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac3467986F7741D6224Abc2Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac3467986F7741D6224Abc2Conditions
    {
        [JsonProperty("5ac5e0fa86f77431c305d243")]
        public string The5Ac5E0Fa86F77431C305D243 { get; set; }

        [JsonProperty("5ac5e13586f7746074388f93")]
        public string The5Ac5E13586F7746074388F93 { get; set; }

        [JsonProperty("5ac5e18c86f7743ebd6c9575")]
        public string The5Ac5E18C86F7743Ebd6C9575 { get; set; }

        [JsonProperty("5acf3b6186f7741cdb2f7f8e")]
        public string The5Acf3B6186F7741Cdb2F7F8E { get; set; }

        [JsonProperty("5acf3b6986f77418440390b4")]
        public string The5Acf3B6986F77418440390B4 { get; set; }
    }

    public partial class The5Ac346A886F7744E1B083D67
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac346A886F7744E1B083D67Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac346A886F7744E1B083D67Conditions
    {
        [JsonProperty("5ac5e79986f7747398341847")]
        public string The5Ac5E79986F7747398341847 { get; set; }

        [JsonProperty("5ac5e88e86f7741c5804f9db")]
        public string The5Ac5E88E86F7741C5804F9Db { get; set; }

        [JsonProperty("5ac5e98886f77479bc6ca201")]
        public string The5Ac5E98886F77479Bc6Ca201 { get; set; }

        [JsonProperty("5ac5ea0586f774609f36280c")]
        public string The5Ac5Ea0586F774609F36280C { get; set; }

        [JsonProperty("5acf3b7186f774184175301d")]
        public string The5Acf3B7186F774184175301D { get; set; }

        [JsonProperty("5acf3b7886f77418420bf36f")]
        public string The5Acf3B7886F77418420Bf36F { get; set; }

        [JsonProperty("5cb6f81d86f7740e9d452683")]
        public string The5Cb6F81D86F7740E9D452683 { get; set; }

        [JsonProperty("5cb6f88d86f7747d215f09c1")]
        public string The5Cb6F88D86F7747D215F09C1 { get; set; }

        [JsonProperty("5cb6f8de86f7740e9d452685")]
        public string The5Cb6F8De86F7740E9D452685 { get; set; }

        [JsonProperty("5cb6f9c586f7740ace254c44")]
        public string The5Cb6F9C586F7740Ace254C44 { get; set; }
    }

    public partial class The5Ac346Cf86F7741D63233A02
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac346Cf86F7741D63233A02Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac346Cf86F7741D63233A02Conditions
    {
        [JsonProperty("5ac7a7bf86f774132252a524")]
        public string The5Ac7A7Bf86F774132252A524 { get; set; }

        [JsonProperty("5ac7a83b86f774665012340b")]
        public string The5Ac7A83B86F774665012340B { get; set; }

        [JsonProperty("5ac7a8d386f7741321499e3c")]
        public string The5Ac7A8D386F7741321499E3C { get; set; }

        [JsonProperty("5ac7a93286f774664f4cbd8c")]
        public string The5Ac7A93286F774664F4Cbd8C { get; set; }
    }

    public partial class The5Ac346E886F7741D6118B99B
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac346E886F7741D6118B99BConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac346E886F7741D6118B99BConditions
    {
        [JsonProperty("5ac5eb3286f7746e7a509a09")]
        public string The5Ac5Eb3286F7746E7A509A09 { get; set; }

        [JsonProperty("5acf3b9986f77418403493b5")]
        public string The5Acf3B9986F77418403493B5 { get; set; }

        [JsonProperty("5acf3ba186f7741ce21f9b0c")]
        public string The5Acf3Ba186F7741Ce21F9B0C { get; set; }
    }

    public partial class The5Ac3475486F7741D6224Abd3
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac3475486F7741D6224Abd3Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac3475486F7741D6224Abd3Conditions
    {
        [JsonProperty("5ac5ee9986f7746e7a509a26")]
        public string The5Ac5Ee9986F7746E7A509A26 { get; set; }

        [JsonProperty("5ac5eee986f77401fd341c9e")]
        public string The5Ac5Eee986F77401Fd341C9E { get; set; }

        [JsonProperty("5ac5ef2a86f7741c5804f9f5")]
        public string The5Ac5Ef2A86F7741C5804F9F5 { get; set; }

        [JsonProperty("5ac5ef5686f77416ca60f644")]
        public string The5Ac5Ef5686F77416Ca60F644 { get; set; }

        [JsonProperty("5ac5ef9886f7746e7a509a2d")]
        public string The5Ac5Ef9886F7746E7A509A2D { get; set; }

        [JsonProperty("5ac5eff886f7740f43322559")]
        public string The5Ac5Eff886F7740F43322559 { get; set; }

        [JsonProperty("5acf3c3086f77418d851688f")]
        public string The5Acf3C3086F77418D851688F { get; set; }

        [JsonProperty("5acf3c3d86f7741ce21f9b1a")]
        public string The5Acf3C3D86F7741Ce21F9B1A { get; set; }
    }

    public partial class The5Ac3477486F7741D651D6885
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5Ac3477486F7741D651D6885Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac3477486F7741D651D6885Conditions
    {
        [JsonProperty("5ac61a8a86f7743a8d663c77")]
        public string The5Ac61A8A86F7743A8D663C77 { get; set; }

        [JsonProperty("5ac61ab986f7746e352cec8c")]
        public string The5Ac61Ab986F7746E352Cec8C { get; set; }

        [JsonProperty("5ac61adf86f774741c1bf096")]
        public string The5Ac61Adf86F774741C1Bf096 { get; set; }

        [JsonProperty("5ac61b1486f7743a8f30fc84")]
        public string The5Ac61B1486F7743A8F30Fc84 { get; set; }

        [JsonProperty("5acf3bcb86f77418403493b7")]
        public string The5Acf3Bcb86F77418403493B7 { get; set; }

        [JsonProperty("5acf3bd286f7741bb83784a3")]
        public string The5Acf3Bd286F7741Bb83784A3 { get; set; }
    }

    public partial class The5Ac3479086F7742880308199
    {
        [JsonProperty("conditions")]
        public The5Ac3479086F7742880308199Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ac3479086F7742880308199Conditions
    {
        [JsonProperty("5acf3dd886f77418d85168f2")]
        public string The5Acf3Dd886F77418D85168F2 { get; set; }

        [JsonProperty("5acf3ddd86f77418420bf391")]
        public string The5Acf3Ddd86F77418420Bf391 { get; set; }

        [JsonProperty("5acf3df186f7741ce21f9b2b")]
        public string The5Acf3Df186F7741Ce21F9B2B { get; set; }

        [JsonProperty("5dbadfd186f77449467d1482")]
        public string The5Dbadfd186F77449467D1482 { get; set; }
    }

    public partial class The5Ae3267986F7742A413592Fe
    {
        [JsonProperty("conditions")]
        public The5Ae3267986F7742A413592FeConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae3267986F7742A413592FeConditions
    {
        [JsonProperty("5ae34b8b86f7741e5b1e5d48")]
        public string The5Ae34B8B86F7741E5B1E5D48 { get; set; }

        [JsonProperty("5af4132686f774174a49af96")]
        public string The5Af4132686F774174A49Af96 { get; set; }

        [JsonProperty("5af4134a86f7742574673cc5")]
        public string The5Af4134A86F7742574673Cc5 { get; set; }
    }

    public partial class The5Ae3270F86F77445Ba41D4Dd
    {
        [JsonProperty("conditions")]
        public The5Ae3270F86F77445Ba41D4DdConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae3270F86F77445Ba41D4DdConditions
    {
        [JsonProperty("5ae3550b86f7741cf44fc799")]
        public string The5Ae3550B86F7741Cf44Fc799 { get; set; }

        [JsonProperty("5af4136586f774551341dc75")]
        public string The5Af4136586F774551341Dc75 { get; set; }

        [JsonProperty("5af4139286f774522e34389b")]
        public string The5Af4139286F774522E34389B { get; set; }
    }

    public partial class The5Ae3277186F7745973054106
    {
        [JsonProperty("conditions")]
        public The5Ae3277186F7745973054106Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae3277186F7745973054106Conditions
    {
        [JsonProperty("5ae3570b86f7746efa6b4494")]
        public string The5Ae3570B86F7746Efa6B4494 { get; set; }

        [JsonProperty("5af413ae86f774522e3438a5")]
        public string The5Af413Ae86F774522E3438A5 { get; set; }

        [JsonProperty("5af413b686f774522c7a6791")]
        public string The5Af413B686F774522C7A6791 { get; set; }
    }

    public partial class The5Ae327C886F7745C7B3F2F3F
    {
        [JsonProperty("conditions")]
        public The5Ae327C886F7745C7B3F2F3FConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae327C886F7745C7B3F2F3FConditions
    {
        [JsonProperty("5ae445f386f7744e87761331")]
        public string The5Ae445F386F7744E87761331 { get; set; }

        [JsonProperty("5af413ce86f774522e3438ae")]
        public string The5Af413Ce86F774522E3438Ae { get; set; }

        [JsonProperty("5af413e486f774522e3438df")]
        public string The5Af413E486F774522E3438Df { get; set; }
    }

    public partial class The5Ae3280386F7742A41359364
    {
        [JsonProperty("conditions")]
        public The5Ae3280386F7742A41359364Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae3280386F7742A41359364Conditions
    {
        [JsonProperty("5ae4479686f7744f6c79b7b3")]
        public string The5Ae4479686F7744F6C79B7B3 { get; set; }

        [JsonProperty("5af413fa86f77407184494f3")]
        public string The5Af413Fa86F77407184494F3 { get; set; }

        [JsonProperty("5af4140186f774522d460775")]
        public string The5Af4140186F774522D460775 { get; set; }
    }

    public partial class The5Ae448A386F7744D3730Fff0
    {
        [JsonProperty("conditions")]
        public The5Ae448A386F7744D3730Fff0Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae448A386F7744D3730Fff0Conditions
    {
        [JsonProperty("5ae44c6886f7744f1a7eb2b8")]
        public string The5Ae44C6886F7744F1A7Eb2B8 { get; set; }

        [JsonProperty("5af414f286f774522f59b0d7")]
        public string The5Af414F286F774522F59B0D7 { get; set; }
    }

    public partial class The5Ae448Bf86F7744D733E55Ee
    {
        [JsonProperty("conditions")]
        public The5Ae448Bf86F7744D733E55EeConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae448Bf86F7744D733E55EeConditions
    {
        [JsonProperty("5ae44ecd86f77414a13c970e")]
        public string The5Ae44Ecd86F77414A13C970E { get; set; }

        [JsonProperty("5af4154186f7745c2674236d")]
        public string The5Af4154186F7745C2674236D { get; set; }
    }

    public partial class The5Ae448E586F7744Dcf0C2A67
    {
        [JsonProperty("conditions")]
        public The5Ae448E586F7744Dcf0C2A67Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae448E586F7744Dcf0C2A67Conditions
    {
        [JsonProperty("5ae4508386f7741250488337")]
        public string The5Ae4508386F7741250488337 { get; set; }

        [JsonProperty("5ae450db86f7741250488359")]
        public string The5Ae450Db86F7741250488359 { get; set; }

        [JsonProperty("5ae450ee86f7740f9307859d")]
        public string The5Ae450Ee86F7740F9307859D { get; set; }

        [JsonProperty("5ae4510786f7740fa614399f")]
        public string The5Ae4510786F7740Fa614399F { get; set; }

        [JsonProperty("5ae4511d86f7740ffc31ccb5")]
        public string The5Ae4511D86F7740Ffc31Ccb5 { get; set; }

        [JsonProperty("5ae4514986f7740e915d218c")]
        public string The5Ae4514986F7740E915D218C { get; set; }

        [JsonProperty("5af4155d86f7745b5e2aba63")]
        public string The5Af4155D86F7745B5E2Aba63 { get; set; }
    }

    public partial class The5Ae448F286F77448D73C0131
    {
        [JsonProperty("conditions")]
        public The5Ae448F286F77448D73C0131Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae448F286F77448D73C0131Conditions
    {
        [JsonProperty("5ae452c086f774336a397578")]
        public string The5Ae452C086F774336A397578 { get; set; }

        [JsonProperty("5ae452de86f77450595c4333")]
        public string The5Ae452De86F77450595C4333 { get; set; }

        [JsonProperty("5ae452fa86f774336a39758e")]
        public string The5Ae452Fa86F774336A39758E { get; set; }

        [JsonProperty("5ae4531986f774177033c3e6")]
        public string The5Ae4531986F774177033C3E6 { get; set; }

        [JsonProperty("5b50761b88a4507f45121125")]
        public string The5B50761B88A4507F45121125 { get; set; }
    }

    public partial class The5Ae4490786F7744Ca822Adcc
    {
        [JsonProperty("conditions")]
        public The5Ae4490786F7744Ca822AdccConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4490786F7744Ca822AdccConditions
    {
        [JsonProperty("5ae4543686f7742dc043c903")]
        public string The5Ae4543686F7742Dc043C903 { get; set; }

        [JsonProperty("5ae454a086f7742be909a81a")]
        public string The5Ae454A086F7742Be909A81A { get; set; }

        [JsonProperty("5af4157f86f7745f696ebd3d")]
        public string The5Af4157F86F7745F696Ebd3D { get; set; }
    }

    public partial class The5Ae4493486F7744Efa289417
    {
        [JsonProperty("conditions")]
        public The5Ae4493486F7744Efa289417Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4493486F7744Efa289417Conditions
    {
        [JsonProperty("5ae9b32486f7745bbc72275a")]
        public string The5Ae9B32486F7745Bbc72275A { get; set; }

        [JsonProperty("5ae9b34686f7743129512ccf")]
        public string The5Ae9B34686F7743129512Ccf { get; set; }

        [JsonProperty("5ae9b36c86f774307c29df04")]
        public string The5Ae9B36C86F774307C29Df04 { get; set; }

        [JsonProperty("5ae9b38a86f77432c81e2ce3")]
        public string The5Ae9B38A86F77432C81E2Ce3 { get; set; }

        [JsonProperty("5ae9b3b186f7745bbc722762")]
        public string The5Ae9B3B186F7745Bbc722762 { get; set; }

        [JsonProperty("5ae9b3c986f77432c81e2ce6")]
        public string The5Ae9B3C986F77432C81E2Ce6 { get; set; }

        [JsonProperty("5af415b286f77407184495dd")]
        public string The5Af415B286F77407184495Dd { get; set; }
    }

    public partial class The5Ae4493D86F7744B8E15Aa8F
    {
        [JsonProperty("conditions")]
        public The5Ae4493D86F7744B8E15Aa8FConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4493D86F7744B8E15Aa8FConditions
    {
        [JsonProperty("5ae9b5bd86f774307c29df37")]
        public string The5Ae9B5Bd86F774307C29Df37 { get; set; }

        [JsonProperty("5ae9b63286f774229110402d")]
        public string The5Ae9B63286F774229110402D { get; set; }

        [JsonProperty("5af415c386f7745c267423a7")]
        public string The5Af415C386F7745C267423A7 { get; set; }
    }

    public partial class The5Ae4495086F77443C122Bc40
    {
        [JsonProperty("conditions")]
        public The5Ae4495086F77443C122Bc40Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4495086F77443C122Bc40Conditions
    {
        [JsonProperty("5ae4559386f7742dc043c95e")]
        public string The5Ae4559386F7742Dc043C95E { get; set; }

        [JsonProperty("5ae455be86f7742dc043c969")]
        public string The5Ae455Be86F7742Dc043C969 { get; set; }

        [JsonProperty("5ae455fb86f7744dd8242380")]
        public string The5Ae455Fb86F7744Dd8242380 { get; set; }

        [JsonProperty("5ae4562086f774498b05e0dc")]
        public string The5Ae4562086F774498B05E0Dc { get; set; }

        [JsonProperty("5af415f486f7745bf73dad59")]
        public string The5Af415F486F7745Bf73Dad59 { get; set; }

        [JsonProperty("5af4201386f774267375038c")]
        public string The5Af4201386F774267375038C { get; set; }
    }

    public partial class The5Ae4495C86F7744E87761355
    {
        [JsonProperty("conditions")]
        public The5Ae4495C86F7744E87761355Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4495C86F7744E87761355Conditions
    {
        [JsonProperty("5ae9b77f86f77432c81e3074")]
        public string The5Ae9B77F86F77432C81E3074 { get; set; }

        [JsonProperty("5ae9b7c886f774307c29df56")]
        public string The5Ae9B7C886F774307C29Df56 { get; set; }

        [JsonProperty("5ae9b91386f77415a869b3f3")]
        public string The5Ae9B91386F77415A869B3F3 { get; set; }

        [JsonProperty("5ae9b93b86f7746e0026221a")]
        public string The5Ae9B93B86F7746E0026221A { get; set; }

        [JsonProperty("5af4165d86f7745bf73dad72")]
        public string The5Af4165D86F7745Bf73Dad72 { get; set; }
    }

    public partial class The5Ae4496986F774459E77Beb6
    {
        [JsonProperty("conditions")]
        public The5Ae4496986F774459E77Beb6Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4496986F774459E77Beb6Conditions
    {
        [JsonProperty("5ae9bb6986f77415a869b40b")]
        public string The5Ae9Bb6986F77415A869B40B { get; set; }

        [JsonProperty("5ae9bc6e86f7746e0026222c")]
        public string The5Ae9Bc6E86F7746E0026222C { get; set; }

        [JsonProperty("5ae9be7f86f7746c6337153d")]
        public string The5Ae9Be7F86F7746C6337153D { get; set; }

        [JsonProperty("5ae9bea886f77468ab400e64")]
        public string The5Ae9Bea886F77468Ab400E64 { get; set; }
    }

    public partial class The5Ae4497B86F7744Cf402Ed00
    {
        [JsonProperty("conditions")]
        public The5Ae4497B86F7744Cf402Ed00Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4497B86F7744Cf402Ed00Conditions
    {
        [JsonProperty("5ae45d7786f774178f237745")]
        public string The5Ae45D7786F774178F237745 { get; set; }

        [JsonProperty("5ae45d9386f774178f23774a")]
        public string The5Ae45D9386F774178F23774A { get; set; }

        [JsonProperty("5af079e486f77434693ad7f8")]
        public string The5Af079E486F77434693Ad7F8 { get; set; }

        [JsonProperty("5af07a0286f7747dba10d8ac")]
        public string The5Af07A0286F7747Dba10D8Ac { get; set; }

        [JsonProperty("5af4168d86f7745c267423dc")]
        public string The5Af4168D86F7745C267423Dc { get; set; }
    }

    public partial class The5Ae4498786F7744Bde357695
    {
        [JsonProperty("conditions")]
        public The5Ae4498786F7744Bde357695Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4498786F7744Bde357695Conditions
    {
        [JsonProperty("5ae9c0a686f774703201f143")]
        public string The5Ae9C0A686F774703201F143 { get; set; }

        [JsonProperty("5ae9c0c986f77468ab400f88")]
        public string The5Ae9C0C986F77468Ab400F88 { get; set; }

        [JsonProperty("5ae9c0e186f7746419683c5e")]
        public string The5Ae9C0E186F7746419683C5E { get; set; }

        [JsonProperty("5ae9c10686f774703201f146")]
        public string The5Ae9C10686F774703201F146 { get; set; }

        [JsonProperty("5af416f086f7745c524a375f")]
        public string The5Af416F086F7745C524A375F { get; set; }

        [JsonProperty("5af4192c86f774297e641027")]
        public string The5Af4192C86F774297E641027 { get; set; }
    }

    public partial class The5Ae4499A86F77449783815Db
    {
        [JsonProperty("conditions")]
        public The5Ae4499A86F77449783815DbConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae4499A86F77449783815DbConditions
    {
        [JsonProperty("5ae9c29386f77427153c7fb0")]
        public string The5Ae9C29386F77427153C7Fb0 { get; set; }

        [JsonProperty("5af4170e86f7745c267423e9")]
        public string The5Af4170E86F7745C267423E9 { get; set; }

        [JsonProperty("5af4171686f7741c8f21cb9e")]
        public string The5Af4171686F7741C8F21Cb9E { get; set; }
    }

    public partial class The5Ae449A586F7744Bde357696
    {
        [JsonProperty("conditions")]
        public The5Ae449A586F7744Bde357696Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae449A586F7744Bde357696Conditions
    {
        [JsonProperty("5ae9c38e86f7743515398707")]
        public string The5Ae9C38E86F7743515398707 { get; set; }

        [JsonProperty("5af4172f86f774059056f692")]
        public string The5Af4172F86F774059056F692 { get; set; }
    }

    public partial class The5Ae449B386F77446D8741719
    {
        [JsonProperty("conditions")]
        public The5Ae449B386F77446D8741719Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae449B386F77446D8741719Conditions
    {
        [JsonProperty("5ae9e0dd86f77443f2500fd4")]
        public string The5Ae9E0Dd86F77443F2500Fd4 { get; set; }

        [JsonProperty("5ae9e17c86f77440d37ce03c")]
        public string The5Ae9E17C86F77440D37Ce03C { get; set; }

        [JsonProperty("5ae9e1c786f77403fb3f9674")]
        public string The5Ae9E1C786F77403Fb3F9674 { get; set; }

        [JsonProperty("5ae9e2a286f7740de4152a0a")]
        public string The5Ae9E2A286F7740De4152A0A { get; set; }

        [JsonProperty("5ae9e2e386f7740de4152a0d")]
        public string The5Ae9E2E386F7740De4152A0D { get; set; }

        [JsonProperty("5af4177686f77406f92eee62")]
        public string The5Af4177686F77406F92Eee62 { get; set; }

        [JsonProperty("5af4178e86f77426757cb152")]
        public string The5Af4178E86F77426757Cb152 { get; set; }
    }

    public partial class The5Ae449C386F7744Bde357697
    {
        [JsonProperty("conditions")]
        public The5Ae449C386F7744Bde357697Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae449C386F7744Bde357697Conditions
    {
        [JsonProperty("5af417c086f7742a2712c3c2")]
        public string The5Af417C086F7742A2712C3C2 { get; set; }

        [JsonProperty("5af4196886f7742a2627a4be")]
        public string The5Af4196886F7742A2627A4Be { get; set; }

        [JsonProperty("5bb60cbc88a45011a8235cc5")]
        public string The5Bb60Cbc88A45011A8235Cc5 { get; set; }
    }

    public partial class The5Ae449D986F774453A54A7E1
    {
        [JsonProperty("conditions")]
        public The5Ae449D986F774453A54A7E1Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Ae449D986F774453A54A7E1Conditions
    {
        [JsonProperty("5ae9e55886f77445315f662a")]
        public string The5Ae9E55886F77445315F662A { get; set; }

        [JsonProperty("5ae9e58886f77423572433f5")]
        public string The5Ae9E58886F77423572433F5 { get; set; }

        [JsonProperty("5af417e386f77428ae313af3")]
        public string The5Af417E386F77428Ae313Af3 { get; set; }

        [JsonProperty("5af4181286f77428bb55edd9")]
        public string The5Af4181286F77428Bb55Edd9 { get; set; }

        [JsonProperty("5af4186c86f77428ae313afa")]
        public string The5Af4186C86F77428Ae313Afa { get; set; }
    }

    public partial class The5B47749F86F7746C5D6A5Fd4
    {
        [JsonProperty("conditions")]
        public The5B47749F86F7746C5D6A5Fd4Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B47749F86F7746C5D6A5Fd4Conditions
    {
        [JsonProperty("5b47796686f774374f4a8bb1")]
        public string The5B47796686F774374F4A8Bb1 { get; set; }

        [JsonProperty("5b4f082f86f7747a284dd609")]
        public string The5B4F082F86F7747A284Dd609 { get; set; }

        [JsonProperty("5b4f0cc186f7744def7f3389")]
        public string The5B4F0Cc186F7744Def7F3389 { get; set; }
    }

    public partial class The5B47799D86F7746C5D6A5Fd8
    {
        [JsonProperty("conditions")]
        public The5B47799D86F7746C5D6A5Fd8Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B47799D86F7746C5D6A5Fd8Conditions
    {
        [JsonProperty("5b477b3b86f77401da02e6c4")]
        public string The5B477B3B86F77401Da02E6C4 { get; set; }

        [JsonProperty("5b4f085586f7747a2910a9b2")]
        public string The5B4F085586F7747A2910A9B2 { get; set; }

        [JsonProperty("5b4f0d6086f7742c1f5a3c4d")]
        public string The5B4F0D6086F7742C1F5A3C4D { get; set; }
    }

    public partial class The5B477B6F86F7747290681823
    {
        [JsonProperty("conditions")]
        public The5B477B6F86F7747290681823Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B477B6F86F7747290681823Conditions
    {
        [JsonProperty("5b477f1486f7743009493232")]
        public string The5B477F1486F7743009493232 { get; set; }

        [JsonProperty("5b4f087886f77479806f2c61")]
        public string The5B4F087886F77479806F2C61 { get; set; }

        [JsonProperty("5b4f0cce86f774287331639a")]
        public string The5B4F0Cce86F774287331639A { get; set; }
    }

    public partial class The5B477F7686F7744D1B23C4D2
    {
        [JsonProperty("conditions")]
        public The5B477F7686F7744D1B23C4D2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B477F7686F7744D1B23C4D2Conditions
    {
        [JsonProperty("5b47824386f7744d190d8dd1")]
        public string The5B47824386F7744D190D8Dd1 { get; set; }

        [JsonProperty("5b4f094886f7747b127d9d7f")]
        public string The5B4F094886F7747B127D9D7F { get; set; }

        [JsonProperty("5b4f0d7186f77412bc326997")]
        public string The5B4F0D7186F77412Bc326997 { get; set; }
    }

    public partial class The5B47825886F77468074618D3
    {
        [JsonProperty("conditions")]
        public The5B47825886F77468074618D3Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B47825886F77468074618D3Conditions
    {
        [JsonProperty("5b4783ba86f7744d1c353185")]
        public string The5B4783Ba86F7744D1C353185 { get; set; }

        [JsonProperty("5b4f095b86f7747a2637c3f9")]
        public string The5B4F095B86F7747A2637C3F9 { get; set; }

        [JsonProperty("5b4f0ce686f77429c16dcb63")]
        public string The5B4F0Ce686F77429C16Dcb63 { get; set; }
    }

    public partial class The5B47876E86F7744D1C353205
    {
        [JsonProperty("conditions")]
        public The5B47876E86F7744D1C353205Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B47876E86F7744D1C353205Conditions
    {
        [JsonProperty("5b47884886f7744d1c35327d")]
        public string The5B47884886F7744D1C35327D { get; set; }

        [JsonProperty("5b47886986f7744d1a393e65")]
        public string The5B47886986F7744D1A393E65 { get; set; }

        [JsonProperty("5b4f09c786f77479806f2cf3")]
        public string The5B4F09C786F77479806F2Cf3 { get; set; }

        [JsonProperty("5b4f09f586f7744fba15b2dc")]
        public string The5B4F09F586F7744Fba15B2Dc { get; set; }

        [JsonProperty("5b4f0c7b86f77479ee584ab0")]
        public string The5B4F0C7B86F77479Ee584Ab0 { get; set; }
    }

    public partial class The5B47891F86F7744D1B23C571
    {
        [JsonProperty("conditions")]
        public The5B47891F86F7744D1B23C571Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B47891F86F7744D1B23C571Conditions
    {
        [JsonProperty("5b47899386f77470315db7f3")]
        public string The5B47899386F77470315Db7F3 { get; set; }

        [JsonProperty("5b4789b586f7744d190d8f43")]
        public string The5B4789B586F7744D190D8F43 { get; set; }

        [JsonProperty("5b4789df86f77468074619d7")]
        public string The5B4789Df86F77468074619D7 { get; set; }

        [JsonProperty("5b478a0986f7744d190d8f46")]
        public string The5B478A0986F7744D190D8F46 { get; set; }

        [JsonProperty("5b478a2186f77468074619da")]
        public string The5B478A2186F77468074619Da { get; set; }

        [JsonProperty("5b478a3786f77470315db7fa")]
        public string The5B478A3786F77470315Db7Fa { get; set; }

        [JsonProperty("5b478a6c86f7744d190d8f4d")]
        public string The5B478A6C86F7744D190D8F4D { get; set; }

        [JsonProperty("5b478a8486f7744d1c35328b")]
        public string The5B478A8486F7744D1C35328B { get; set; }

        [JsonProperty("5b4f0a4386f7744e1155e1ed")]
        public string The5B4F0A4386F7744E1155E1Ed { get; set; }

        [JsonProperty("5b4f0a5086f7744e3a6b328a")]
        public string The5B4F0A5086F7744E3A6B328A { get; set; }

        [JsonProperty("5b4f0c8786f77479806f3028")]
        public string The5B4F0C8786F77479806F3028 { get; set; }
    }

    public partial class The5B478B1886F7744D1B23C57D
    {
        [JsonProperty("conditions")]
        public The5B478B1886F7744D1B23C57DConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B478B1886F7744D1B23C57DConditions
    {
        [JsonProperty("5b478c4c86f7744d1a393fac")]
        public string The5B478C4C86F7744D1A393Fac { get; set; }

        [JsonProperty("5b478c7386f7744d1a393fb1")]
        public string The5B478C7386F7744D1A393Fb1 { get; set; }

        [JsonProperty("5b478cb586f7744d1a393fb5")]
        public string The5B478Cb586F7744D1A393Fb5 { get; set; }

        [JsonProperty("5b4f0a8086f7744e3a6b3290")]
        public string The5B4F0A8086F7744E3A6B3290 { get; set; }

        [JsonProperty("5b4f0c9086f77453572f5538")]
        public string The5B4F0C9086F77453572F5538 { get; set; }
    }

    public partial class The5B478D0F86F7744D190D91B5
    {
        [JsonProperty("conditions")]
        public The5B478D0F86F7744D190D91B5Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B478D0F86F7744D190D91B5Conditions
    {
        [JsonProperty("5b478d8986f774563c7a4809")]
        public string The5B478D8986F774563C7A4809 { get; set; }

        [JsonProperty("5b478daf86f7744d1c35339b")]
        public string The5B478Daf86F7744D1C35339B { get; set; }

        [JsonProperty("5b478dca86f7744d190d91c2")]
        public string The5B478Dca86F7744D190D91C2 { get; set; }

        [JsonProperty("5b478de086f7744d1c3533a1")]
        public string The5B478De086F7744D1C3533A1 { get; set; }

        [JsonProperty("5b4f0ac386f7747a2637c4c0")]
        public string The5B4F0Ac386F7747A2637C4C0 { get; set; }

        [JsonProperty("5b4f0c9d86f7744def7f3385")]
        public string The5B4F0C9D86F7744Def7F3385 { get; set; }
    }

    public partial class The5B478Eca86F7744642012254
    {
        [JsonProperty("conditions")]
        public The5B478Eca86F7744642012254Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B478Eca86F7744642012254Conditions
    {
        [JsonProperty("5b478f6886f774464201225a")]
        public string The5B478F6886F774464201225A { get; set; }

        [JsonProperty("5b478f8886f7744d1b23c622")]
        public string The5B478F8886F7744D1B23C622 { get; set; }

        [JsonProperty("5b4c826b86f7743cc87bcee4")]
        public string The5B4C826B86F7743Cc87Bcee4 { get; set; }

        [JsonProperty("5b4c82cd86f774170c6e4169")]
        public string The5B4C82Cd86F774170C6E4169 { get; set; }

        [JsonProperty("5b4c832686f77419603eb8f0")]
        public string The5B4C832686F77419603Eb8F0 { get; set; }

        [JsonProperty("5b4c836486f77417063a09dc")]
        public string The5B4C836486F77417063A09Dc { get; set; }

        [JsonProperty("5b4f0b8b86f7747a2910aaa4")]
        public string The5B4F0B8B86F7747A2910Aaa4 { get; set; }

        [JsonProperty("5b4f0c1486f7747a2637c513")]
        public string The5B4F0C1486F7747A2637C513 { get; set; }
    }

    public partial class The5B478Ff486F7744D184Ecbbf
    {
        [JsonProperty("conditions")]
        public The5B478Ff486F7744D184EcbbfConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B478Ff486F7744D184EcbbfConditions
    {
        [JsonProperty("5b47905886f7746807461fe2")]
        public string The5B47905886F7746807461Fe2 { get; set; }

        [JsonProperty("5b4790a886f774563c7a489f")]
        public string The5B4790A886F774563C7A489F { get; set; }

        [JsonProperty("5b4f0b1f86f7746c9e27e9ea")]
        public string The5B4F0B1F86F7746C9E27E9Ea { get; set; }

        [JsonProperty("5cb5ffd986f7746ef55de2c7")]
        public string The5Cb5Ffd986F7746Ef55De2C7 { get; set; }
    }

    public partial class The5B47926A86F7747Ccc057C15
    {
        [JsonProperty("conditions")]
        public The5B47926A86F7747Ccc057C15Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B47926A86F7747Ccc057C15Conditions
    {
        [JsonProperty("5b47932586f7747cc908b5dd")]
        public string The5B47932586F7747Cc908B5Dd { get; set; }

        [JsonProperty("5b47936686f77427fd044025")]
        public string The5B47936686F77427Fd044025 { get; set; }

        [JsonProperty("5b47938086f7747ccc057c22")]
        public string The5B47938086F7747Ccc057C22 { get; set; }

        [JsonProperty("5b4f0b6686f77479ee584a74")]
        public string The5B4F0B6686F77479Ee584A74 { get; set; }

        [JsonProperty("5b4f0c0986f77453572f54e0")]
        public string The5B4F0C0986F77453572F54E0 { get; set; }
    }

    public partial class The5B4794Cb86F774598100D5D4
    {
        [JsonProperty("conditions")]
        public The5B4794Cb86F774598100D5D4Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B4794Cb86F774598100D5D4Conditions
    {
        [JsonProperty("5b47952c86f774598100d5dc")]
        public string The5B47952C86F774598100D5Dc { get; set; }

        [JsonProperty("5b47958e86f774598100d5e2")]
        public string The5B47958E86F774598100D5E2 { get; set; }

        [JsonProperty("5b4795a586f774587a39506d")]
        public string The5B4795A586F774587A39506D { get; set; }

        [JsonProperty("5b4c742886f7745cef1d02f5")]
        public string The5B4C742886F7745Cef1D02F5 { get; set; }

        [JsonProperty("5b4c75a786f7747332534b52")]
        public string The5B4C75A786F7747332534B52 { get; set; }

        [JsonProperty("5b4c764786f7746f3b494ee0")]
        public string The5B4C764786F7746F3B494Ee0 { get; set; }

        [JsonProperty("5b4c769686f7746e535a5c0e")]
        public string The5B4C769686F7746E535A5C0E { get; set; }

        [JsonProperty("5b4c76d886f77471d31735a3")]
        public string The5B4C76D886F77471D31735A3 { get; set; }

        [JsonProperty("5b4c7aec86f77459732b4b08")]
        public string The5B4C7Aec86F77459732B4B08 { get; set; }

        [JsonProperty("5b4c8e6586f77474396a5400")]
        public string The5B4C8E6586F77474396A5400 { get; set; }

        [JsonProperty("5b4f0bca86f7744a6c2b8164")]
        public string The5B4F0Bca86F7744A6C2B8164 { get; set; }

        [JsonProperty("5b4f0bfa86f77453572f54dc")]
        public string The5B4F0Bfa86F77453572F54Dc { get; set; }
    }

    public partial class The5B4795Fb86F7745876267770
    {
        [JsonProperty("conditions")]
        public The5B4795Fb86F7745876267770Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5B4795Fb86F7745876267770Conditions
    {
        [JsonProperty("5b47968e86f7745877352c28")]
        public string The5B47968E86F7745877352C28 { get; set; }

        [JsonProperty("5b4796c086f7745877352c2c")]
        public string The5B4796C086F7745877352C2C { get; set; }

        [JsonProperty("5b47971086f774587877ad34")]
        public string The5B47971086F774587877Ad34 { get; set; }

        [JsonProperty("5b4f0ba486f7747a2637c4fb")]
        public string The5B4F0Ba486F7747A2637C4Fb { get; set; }

        [JsonProperty("5b4f0c5886f7747a2910aacd")]
        public string The5B4F0C5886F7747A2910Aacd { get; set; }

        [JsonProperty("5c923d3d86f774556e08d7a5")]
        public string The5C923D3D86F774556E08D7A5 { get; set; }
    }

    public partial class The5Bc4776586F774512D07Cf05
    {
        [JsonProperty("conditions")]
        public The5Bc4776586F774512D07Cf05Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Bc4776586F774512D07Cf05Conditions
    {
        [JsonProperty("5bc850d186f7747213700892")]
        public string The5Bc850D186F7747213700892 { get; set; }

        [JsonProperty("5bdac2f186f7743e152e8695")]
        public string The5Bdac2F186F7743E152E8695 { get; set; }
    }

    public partial class The5Bc479E586F7747F376C7Da3
    {
        [JsonProperty("conditions")]
        public The5Bc479E586F7747F376C7Da3Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Bc479E586F7747F376C7Da3Conditions
    {
        [JsonProperty("5bd983d886f7747ba73fc246")]
        public string The5Bd983D886F7747Ba73Fc246 { get; set; }

        [JsonProperty("5bd9842e86f7747baa07aba7")]
        public string The5Bd9842E86F7747Baa07Aba7 { get; set; }

        [JsonProperty("5bd9944f86f774035c4877f3")]
        public string The5Bd9944F86F774035C4877F3 { get; set; }

        [JsonProperty("5bdabf0586f7743e1809c555")]
        public string The5Bdabf0586F7743E1809C555 { get; set; }
    }

    public partial class The5Bc47Dbf86F7741Ee74E93B9
    {
        [JsonProperty("conditions")]
        public The5Bc47Dbf86F7741Ee74E93B9Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Bc47Dbf86F7741Ee74E93B9Conditions
    {
        [JsonProperty("5bc47e3e86f7741e6b2f3332")]
        public string The5Bc47E3E86F7741E6B2F3332 { get; set; }

        [JsonProperty("5bdabf1f86f7743e1809c556")]
        public string The5Bdabf1F86F7743E1809C556 { get; set; }
    }

    public partial class The5Bc480A686F7741Af0342E29
    {
        [JsonProperty("conditions")]
        public The5Bc480A686F7741Af0342E29Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Bc480A686F7741Af0342E29Conditions
    {
        [JsonProperty("5bc4813886f774226045cb9a")]
        public string The5Bc4813886F774226045Cb9A { get; set; }

        [JsonProperty("5bdabf3386f7743e171249ae")]
        public string The5Bdabf3386F7743E171249Ae { get; set; }
    }

    public partial class The5Bc4826C86F774106D22D88B
    {
        [JsonProperty("conditions")]
        public The5Bc4826C86F774106D22D88BConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Bc4826C86F774106D22D88BConditions
    {
        [JsonProperty("5bc84f7a86f774294c2f6862")]
        public string The5Bc84F7A86F774294C2F6862 { get; set; }

        [JsonProperty("5bdabf4486f7743e1665df6d")]
        public string The5Bdabf4486F7743E1665Df6D { get; set; }
    }

    public partial class The5Bc4836986F7740C0152911C
    {
        [JsonProperty("conditions")]
        public The5Bc4836986F7740C0152911CConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Bc4836986F7740C0152911CConditions
    {
        [JsonProperty("5bc483ba86f77415034ba8d0")]
        public string The5Bc483Ba86F77415034Ba8D0 { get; set; }

        [JsonProperty("5bdabf5386f7743e152e867c")]
        public string The5Bdabf5386F7743E152E867C { get; set; }
    }

    public partial class The5Bc4856986F77454C317Bea7
    {
        [JsonProperty("conditions")]
        public The5Bc4856986F77454C317Bea7Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Bc4856986F77454C317Bea7Conditions
    {
        [JsonProperty("5bc485b586f774726473a858")]
        public string The5Bc485B586F774726473A858 { get; set; }

        [JsonProperty("5bdabf6286f7743e171249af")]
        public string The5Bdabf6286F7743E171249Af { get; set; }
    }

    public partial class The5Bc4893C86F774626F5Ebf3E
    {
        [JsonProperty("conditions")]
        public The5Bc4893C86F774626F5Ebf3EConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Bc4893C86F774626F5Ebf3EConditions
    {
        [JsonProperty("5bc48aed86f77452c947ce67")]
        public string The5Bc48Aed86F77452C947Ce67 { get; set; }

        [JsonProperty("5bdabf7186f7743e152e867d")]
        public string The5Bdabf7186F7743E152E867D { get; set; }
    }

    public partial class The5C0Bbaa886F7746941031D82
    {
        [JsonProperty("conditions")]
        public The5C0Bbaa886F7746941031D82Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0Bbaa886F7746941031D82Conditions
    {
        [JsonProperty("5c0bc32986f7743e4d1002d2")]
        public string The5C0Bc32986F7743E4D1002D2 { get; set; }

        [JsonProperty("5c0bc43e86f7744794440ba5")]
        public string The5C0Bc43E86F7744794440Ba5 { get; set; }

        [JsonProperty("5c12320586f77437e44bcb15")]
        public string The5C12320586F77437E44Bcb15 { get; set; }

        [JsonProperty("5c1233ac86f77406fa13baea")]
        public string The5C1233Ac86F77406Fa13Baea { get; set; }

        [JsonProperty("5c17b96486f774331c793f28")]
        public string The5C17B96486F774331C793F28 { get; set; }

        [JsonProperty("5c1fa91586f7740de474cb36")]
        public string The5C1Fa91586F7740De474Cb36 { get; set; }

        [JsonProperty("5c50481c86f77410650e0521")]
        public string The5C50481C86F77410650E0521 { get; set; }
    }

    public partial class The5C0Bc91486F7746Ab41857A2
    {
        [JsonProperty("conditions")]
        public The5C0Bc91486F7746Ab41857A2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0Bc91486F7746Ab41857A2Conditions
    {
        [JsonProperty("5c0bc95086f7746e784f39ec")]
        public string The5C0Bc95086F7746E784F39Ec { get; set; }

        [JsonProperty("5c0bcc9c86f7746fe16dbba9")]
        public string The5C0Bcc9C86F7746Fe16Dbba9 { get; set; }

        [JsonProperty("5c1ea18b86f77461d75caa21")]
        public string The5C1Ea18B86F77461D75Caa21 { get; set; }

        [JsonProperty("5c1fa99086f77407e903a5fa")]
        public string The5C1Fa99086F77407E903A5Fa { get; set; }
    }

    public partial class The5C0Bd01E86F7747Cdd799E56
    {
        [JsonProperty("conditions")]
        public The5C0Bd01E86F7747Cdd799E56Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0Bd01E86F7747Cdd799E56Conditions
    {
        [JsonProperty("5c1242fa86f7742aa04fed52")]
        public string The5C1242Fa86F7742Aa04Fed52 { get; set; }

        [JsonProperty("5c17d05e86f77430a64c6c66")]
        public string The5C17D05E86F77430A64C6C66 { get; set; }

        [JsonProperty("5c20cd8f86f774337d77b7ef")]
        public string The5C20Cd8F86F774337D77B7Ef { get; set; }
    }

    public partial class The5C0Bd94186F7747A727F09B2
    {
        [JsonProperty("conditions")]
        public The5C0Bd94186F7747A727F09B2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0Bd94186F7747A727F09B2Conditions
    {
        [JsonProperty("5c1b765d86f77413193fa4f2")]
        public string The5C1B765D86F77413193Fa4F2 { get; set; }

        [JsonProperty("5c1fabb986f77431f74f0de6")]
        public string The5C1Fabb986F77431F74F0De6 { get; set; }

        [JsonProperty("5c1fabd686f77410894b63f8")]
        public string The5C1Fabd686F77410894B63F8 { get; set; }
    }

    public partial class The5C0Bdb5286F774166E38Eed4
    {
        [JsonProperty("conditions")]
        public The5C0Bdb5286F774166E38Eed4Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0Bdb5286F774166E38Eed4Conditions
    {
        [JsonProperty("5c0bdbb586f774166e38eed5")]
        public string The5C0Bdbb586F774166E38Eed5 { get; set; }

        [JsonProperty("5c1faac086f7740ebd348c76")]
        public string The5C1Faac086F7740Ebd348C76 { get; set; }

        [JsonProperty("5c1faac986f77410894b63f5")]
        public string The5C1Faac986F77410894B63F5 { get; set; }
    }

    public partial class The5C0Bde0986F77479Cf22C2F8
    {
        [JsonProperty("conditions")]
        public The5C0Bde0986F77479Cf22C2F8Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0Bde0986F77479Cf22C2F8Conditions
    {
        [JsonProperty("5c0bdf2c86f7746f016734a8")]
        public string The5C0Bdf2C86F7746F016734A8 { get; set; }

        [JsonProperty("5c137b8886f7747ae3220ff4")]
        public string The5C137B8886F7747Ae3220Ff4 { get; set; }

        [JsonProperty("5c137ef386f7747ae10a821e")]
        public string The5C137Ef386F7747Ae10A821E { get; set; }

        [JsonProperty("5c137f5286f7747ae267d8a3")]
        public string The5C137F5286F7747Ae267D8A3 { get; set; }

        [JsonProperty("5c20007986f7743c7b263515")]
        public string The5C20007986F7743C7B263515 { get; set; }

        [JsonProperty("5c20009b86f7742b3c0a8fd9")]
        public string The5C20009B86F7742B3C0A8Fd9 { get; set; }
    }

    public partial class The5C0Be13186F7746F016734Aa
    {
        [JsonProperty("conditions")]
        public The5C0Be13186F7746F016734AaConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0Be13186F7746F016734AaConditions
    {
        [JsonProperty("5c0be2b486f7747bcb347d58")]
        public string The5C0Be2B486F7747Bcb347D58 { get; set; }

        [JsonProperty("5c1fb5f086f7744a184fb3c5")]
        public string The5C1Fb5F086F7744A184Fb3C5 { get; set; }

        [JsonProperty("5c1fb5f986f7744a1929a527")]
        public string The5C1Fb5F986F7744A1929A527 { get; set; }
    }

    public partial class The5C0Be5Fc86F774467A116593
    {
        [JsonProperty("conditions")]
        public The5C0Be5Fc86F774467A116593Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0Be5Fc86F774467A116593Conditions
    {
        [JsonProperty("5c0be66c86f7744523489ab2")]
        public string The5C0Be66C86F7744523489Ab2 { get; set; }

        [JsonProperty("5c0be69086f7743c9c1ecf43")]
        public string The5C0Be69086F7743C9C1Ecf43 { get; set; }

        [JsonProperty("5c1fd1ae86f7742b3b47f064")]
        public string The5C1Fd1Ae86F7742B3B47F064 { get; set; }

        [JsonProperty("5c1fd1b586f7742b3a651f74")]
        public string The5C1Fd1B586F7742B3A651F74 { get; set; }
    }

    public partial class The5C0D0D5086F774363760Aef2
    {
        [JsonProperty("conditions")]
        public The5C0D0D5086F774363760Aef2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0D0D5086F774363760Aef2Conditions
    {
        [JsonProperty("5c0d0dfd86f7747f482a89a5")]
        public string The5C0D0Dfd86F7747F482A89A5 { get; set; }

        [JsonProperty("5c1fd5e586f7743c7b261f79")]
        public string The5C1Fd5E586F7743C7B261F79 { get; set; }

        [JsonProperty("5c1fd5f586f7742b391bf138")]
        public string The5C1Fd5F586F7742B391Bf138 { get; set; }
    }

    public partial class The5C0D0F1886F77457B8210226
    {
        [JsonProperty("conditions")]
        public The5C0D0F1886F77457B8210226Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0D0F1886F77457B8210226Conditions
    {
        [JsonProperty("5c138c4486f7743b056e2943")]
        public string The5C138C4486F7743B056E2943 { get; set; }

        [JsonProperty("5c138d4286f774276a6504aa")]
        public string The5C138D4286F774276A6504Aa { get; set; }

        [JsonProperty("5c1fd61486f7742b391bf139")]
        public string The5C1Fd61486F7742B391Bf139 { get; set; }

        [JsonProperty("5c1fd61e86f7742b38529146")]
        public string The5C1Fd61E86F7742B38529146 { get; set; }
    }

    public partial class The5C0D190Cd09282029F5390D8
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5C0D190Cd09282029F5390D8Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0D190Cd09282029F5390D8Conditions
    {
        [JsonProperty("5c1b760686f77412780211a3")]
        public string The5C1B760686F77412780211A3 { get; set; }

        [JsonProperty("5c1fab3986f7740ebd348c7a")]
        public string The5C1Fab3986F7740Ebd348C7A { get; set; }

        [JsonProperty("5c1fab4186f77431f74f0de5")]
        public string The5C1Fab4186F77431F74F0De5 { get; set; }
    }

    public partial class The5C0D1C4Cd0928202A02A6F5C
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5C0D1C4Cd0928202A02A6F5CConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0D1C4Cd0928202A02A6F5CConditions
    {
        [JsonProperty("5c1b778286f774294438b536")]
        public string The5C1B778286F774294438B536 { get; set; }

        [JsonProperty("5c1fd52e86f7742b391bf099")]
        public string The5C1Fd52E86F7742B391Bf099 { get; set; }

        [JsonProperty("5c1fd53a86f7742b3c0a7b7a")]
        public string The5C1Fd53A86F7742B3C0A7B7A { get; set; }
    }

    public partial class The5C0D4C12D09282029F539173
    {
        [JsonProperty("conditions")]
        public The5C0D4C12D09282029F539173Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0D4C12D09282029F539173Conditions
    {
        [JsonProperty("5c1b713486f77413bc250406")]
        public string The5C1B713486F77413Bc250406 { get; set; }

        [JsonProperty("5c1b713986f77470d8650910")]
        public string The5C1B713986F77470D8650910 { get; set; }

        [JsonProperty("5c1b713f86f774719c22e8a0")]
        public string The5C1B713F86F774719C22E8A0 { get; set; }

        [JsonProperty("5c1fd66286f7743c7b261f7b")]
        public string The5C1Fd66286F7743C7B261F7B { get; set; }

        [JsonProperty("5c20ce1786f77453c56d6397")]
        public string The5C20Ce1786F77453C56D6397 { get; set; }

        [JsonProperty("5c20ce2c86f774337f427599")]
        public string The5C20Ce2C86F774337F427599 { get; set; }
    }

    public partial class The5C0D4E61D09282029F53920E
    {
        [JsonProperty("conditions")]
        public The5C0D4E61D09282029F53920EConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C0D4E61D09282029F53920EConditions
    {
        [JsonProperty("5c13979886f774251443c1a6")]
        public string The5C13979886F774251443C1A6 { get; set; }

        [JsonProperty("5c13982286f774365a69cc4d")]
        public string The5C13982286F774365A69Cc4D { get; set; }

        [JsonProperty("5c13989886f7747878361a50")]
        public string The5C13989886F7747878361A50 { get; set; }

        [JsonProperty("5c0d4f46d09282029f539216")]
        public string The5C0D4F46D09282029F539216 { get; set; }

        [JsonProperty("5c1931e686f7747ce71bcbea")]
        public string The5C1931E686F7747Ce71Bcbea { get; set; }

        [JsonProperty("5c0e6876d09282029e2fffe0")]
        public string The5C0E6876D09282029E2Fffe0 { get; set; }

        [JsonProperty("5c0e687ad0928202b25db840")]
        public string The5C0E687Ad0928202B25Db840 { get; set; }

        [JsonProperty("5d0a0e2286f7743a1a74d63b")]
        public string The5D0A0E2286F7743A1A74D63B { get; set; }

        [JsonProperty("5d0a111586f7743a1b0d87b1")]
        public string The5D0A111586F7743A1B0D87B1 { get; set; }

        [JsonProperty("5dc984ae4b68b15f4825cea5")]
        public string The5Dc984Ae4B68B15F4825Cea5 { get; set; }
    }

    public partial class The5C10F94386F774227172C572
    {
        [JsonProperty("conditions")]
        public The5C10F94386F774227172C572Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C10F94386F774227172C572Conditions
    {
        [JsonProperty("5c10f94386f774227172c574")]
        public string The5C10F94386F774227172C574 { get; set; }

        [JsonProperty("5c10f94386f774227172c575")]
        public string The5C10F94386F774227172C575 { get; set; }

        [JsonProperty("5c10f94386f774227172c576")]
        public string The5C10F94386F774227172C576 { get; set; }

        [JsonProperty("5c10f94386f774227172c577")]
        public string The5C10F94386F774227172C577 { get; set; }

        [JsonProperty("5c1fb27e86f7744a160dda8c")]
        public string The5C1Fb27E86F7744A160Dda8C { get; set; }

        [JsonProperty("5c1fcf9486f7742b3b47e370")]
        public string The5C1Fcf9486F7742B3B47E370 { get; set; }
    }

    public partial class The5C1128E386F7746565181106
    {
        [JsonProperty("conditions")]
        public The5C1128E386F7746565181106Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C1128E386F7746565181106Conditions
    {
        [JsonProperty("5c1129ed86f7746569440e88")]
        public string The5C1129Ed86F7746569440E88 { get; set; }

        [JsonProperty("5c112a1b86f774656777d1ae")]
        public string The5C112A1B86F774656777D1Ae { get; set; }

        [JsonProperty("5c1fb45b86f7744a1a275659")]
        public string The5C1Fb45B86F7744A1A275659 { get; set; }

        [JsonProperty("5c1fb46386f7744a184fb3c2")]
        public string The5C1Fb46386F7744A184Fb3C2 { get; set; }

        [JsonProperty("5ca719ef86f7740a78020783")]
        public string The5Ca719Ef86F7740A78020783 { get; set; }

        [JsonProperty("5ca71a1e86f7740f5a5b88a2")]
        public string The5Ca71A1E86F7740F5A5B88A2 { get; set; }
    }

    public partial class The5C112D7E86F7740D6F647486
    {
        [JsonProperty("conditions")]
        public The5C112D7E86F7740D6F647486Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C112D7E86F7740D6F647486Conditions
    {
        [JsonProperty("5c112dc486f77465686bff38")]
        public string The5C112Dc486F77465686Bff38 { get; set; }

        [JsonProperty("5c1fd15f86f7742b3c0a7b78")]
        public string The5C1Fd15F86F7742B3C0A7B78 { get; set; }

        [JsonProperty("5c1fd17786f7742b3b47f063")]
        public string The5C1Fd17786F7742B3B47F063 { get; set; }
    }

    public partial class The5C1141F386F77430Ff393792
    {
        [JsonProperty("conditions")]
        public The5C1141F386F77430Ff393792Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C1141F386F77430Ff393792Conditions
    {
        [JsonProperty("5c11427386f77430ff393793")]
        public string The5C11427386F77430Ff393793 { get; set; }

        [JsonProperty("5c122c5f86f77437e44bcb0e")]
        public string The5C122C5F86F77437E44Bcb0E { get; set; }

        [JsonProperty("5c1fd03686f7742b3c0a6a9f")]
        public string The5C1Fd03686F7742B3C0A6A9F { get; set; }

        [JsonProperty("5c1fd04886f7742b3b47e8a2")]
        public string The5C1Fd04886F7742B3B47E8A2 { get; set; }

        [JsonProperty("5ca7254e86f7740d424a2043")]
        public string The5Ca7254E86F7740D424A2043 { get; set; }

        [JsonProperty("5ca7258986f7740d424a2044")]
        public string The5Ca7258986F7740D424A2044 { get; set; }
    }

    public partial class The5C1234C286F77406Fa13Baeb
    {
        [JsonProperty("conditions")]
        public The5C1234C286F77406Fa13BaebConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C1234C286F77406Fa13BaebConditions
    {
        [JsonProperty("5c1fa9c986f7740de474cb3d")]
        public string The5C1Fa9C986F7740De474Cb3D { get; set; }

        [JsonProperty("5c1faa0d86f77410894b63ef")]
        public string The5C1Faa0D86F77410894B63Ef { get; set; }

        [JsonProperty("5c1faa1986f7740ebd348c71")]
        public string The5C1Faa1986F7740Ebd348C71 { get; set; }
    }

    public partial class The5C12452C86F7744B83469073
    {
        [JsonProperty("conditions")]
        public The5C12452C86F7744B83469073Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C12452C86F7744B83469073Conditions
    {
        [JsonProperty("5c12470d86f77465ae27a8c0")]
        public string The5C12470D86F77465Ae27A8C0 { get; set; }

        [JsonProperty("5c1247f386f77452db1d2b03")]
        public string The5C1247F386F77452Db1D2B03 { get; set; }

        [JsonProperty("5c12484586f7744b83469074")]
        public string The5C12484586F7744B83469074 { get; set; }

        [JsonProperty("5c12487386f7742a60324299")]
        public string The5C12487386F7742A60324299 { get; set; }

        [JsonProperty("5c12489886f77452db1d2b05")]
        public string The5C12489886F77452Db1D2B05 { get; set; }

        [JsonProperty("5c1248ef86f77428266184c2")]
        public string The5C1248Ef86F77428266184C2 { get; set; }

        [JsonProperty("5c1fab8686f77410894b63f7")]
        public string The5C1Fab8686F77410894B63F7 { get; set; }

        [JsonProperty("5c1fab9286f77407e903a60d")]
        public string The5C1Fab9286F77407E903A60D { get; set; }
    }

    public partial class The5C139Eb686F7747878361A6F
    {
        [JsonProperty("conditions")]
        public The5C139Eb686F7747878361A6FConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5C139Eb686F7747878361A6FConditions
    {
        [JsonProperty("5c139eb686f7747878361a72")]
        public string The5C139Eb686F7747878361A72 { get; set; }

        [JsonProperty("5c139eb686f7747878361a73")]
        public string The5C139Eb686F7747878361A73 { get; set; }

        [JsonProperty("5c1fcf3786f7742b3b47e36f")]
        public string The5C1Fcf3786F7742B3B47E36F { get; set; }

        [JsonProperty("5c1fcf4086f7742b38527bde")]
        public string The5C1Fcf4086F7742B38527Bde { get; set; }
    }

    public partial class The5C51Aac186F77432Ea65C552
    {
        [JsonProperty("conditions")]
        public Dictionary<string, string> Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D2495A886F77425Cd51E403
    {
        [JsonProperty("conditions")]
        public The5D2495A886F77425Cd51E403Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D2495A886F77425Cd51E403Conditions
    {
        [JsonProperty("5d2496fb86f77425ce7f1254")]
        public string The5D2496Fb86F77425Ce7F1254 { get; set; }

        [JsonProperty("5d249a6e86f774791546e952")]
        public string The5D249A6E86F774791546E952 { get; set; }

        [JsonProperty("5d249aa286f77475e8376399")]
        public string The5D249Aa286F77475E8376399 { get; set; }

        [JsonProperty("5d7fc0f386f77440373c4d78")]
        public string The5D7Fc0F386F77440373C4D78 { get; set; }

        [JsonProperty("5d7fc0fb86f77440351becb3")]
        public string The5D7Fc0Fb86F77440351Becb3 { get; set; }
    }

    public partial class The5D24B81486F77439C92D6Ba8
    {
        [JsonProperty("conditions")]
        public The5D24B81486F77439C92D6Ba8Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D24B81486F77439C92D6Ba8Conditions
    {
        [JsonProperty("5d24ba7886f77439c92d6baa")]
        public string The5D24Ba7886F77439C92D6Baa { get; set; }

        [JsonProperty("5d24bb4886f77439c92d6bad")]
        public string The5D24Bb4886F77439C92D6Bad { get; set; }

        [JsonProperty("5d24bb7286f7741f7956be74")]
        public string The5D24Bb7286F7741F7956Be74 { get; set; }

        [JsonProperty("5d76276186f774454c5360bc")]
        public string The5D76276186F774454C5360Bc { get; set; }

        [JsonProperty("5d77d51c86f7742fa65b6608")]
        public string The5D77D51C86F7742Fa65B6608 { get; set; }
    }

    public partial class The5D25Aed386F77442734D25D2
    {
        [JsonProperty("conditions")]
        public The5D25Aed386F77442734D25D2Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25Aed386F77442734D25D2Conditions
    {
        [JsonProperty("5d25af3c86f77443ff46b9e7")]
        public string The5D25Af3C86F77443Ff46B9E7 { get; set; }

        [JsonProperty("5d76302d86f774454d58840e")]
        public string The5D76302D86F774454D58840E { get; set; }

        [JsonProperty("5d77d4a386f7745041358b56")]
        public string The5D77D4A386F7745041358B56 { get; set; }
    }

    public partial class The5D25B6Be86F77444001E1B89
    {
        [JsonProperty("conditions")]
        public The5D25B6Be86F77444001E1B89Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25B6Be86F77444001E1B89Conditions
    {
        [JsonProperty("5d25beca86f77409dd5cdbb3")]
        public string The5D25Beca86F77409Dd5Cdbb3 { get; set; }

        [JsonProperty("5d25beeb86f77443fe45765f")]
        public string The5D25Beeb86F77443Fe45765F { get; set; }

        [JsonProperty("5d2deedc86f77459121c3118")]
        public string The5D2Deedc86F77459121C3118 { get; set; }

        [JsonProperty("5d2defc586f774591510e6b9")]
        public string The5D2Defc586F774591510E6B9 { get; set; }

        [JsonProperty("5d76307886f774454c5360c1")]
        public string The5D76307886F774454C5360C1 { get; set; }

        [JsonProperty("5d77d13e86f77461b27a237a")]
        public string The5D77D13E86F77461B27A237A { get; set; }
    }

    public partial class The5D25Bfd086F77442734D3007
    {
        [JsonProperty("conditions")]
        public The5D25Bfd086F77442734D3007Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25Bfd086F77442734D3007Conditions
    {
        [JsonProperty("5d25c5a186f77443fe457661")]
        public string The5D25C5A186F77443Fe457661 { get; set; }

        [JsonProperty("5d9f035086f7741cac4a9713")]
        public string The5D9F035086F7741Cac4A9713 { get; set; }

        [JsonProperty("5dadc98786f7744b0c681e8e")]
        public string The5Dadc98786F7744B0C681E8E { get; set; }

        [JsonProperty("5dadc99686f7744b0f1b1d2a")]
        public string The5Dadc99686F7744B0F1B1D2A { get; set; }
    }

    public partial class The5D25C81B86F77443E625Dd71
    {
        [JsonProperty("conditions")]
        public The5D25C81B86F77443E625Dd71Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25C81B86F77443E625Dd71Conditions
    {
        [JsonProperty("5d25c8c986f77443e47ad47a")]
        public string The5D25C8C986F77443E47Ad47A { get; set; }

        [JsonProperty("5d7630e286f774452173421a")]
        public string The5D7630E286F774452173421A { get; set; }

        [JsonProperty("5d77d0f286f7742fa65b6604")]
        public string The5D77D0F286F7742Fa65B6604 { get; set; }
    }

    public partial class The5D25Cf2686F77443E75488D4
    {
        [JsonProperty("conditions")]
        public The5D25Cf2686F77443E75488D4Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25Cf2686F77443E75488D4Conditions
    {
        [JsonProperty("5d25d09286f77444001e284c")]
        public string The5D25D09286F77444001E284C { get; set; }

        [JsonProperty("5d25d0d186f7740a22515975")]
        public string The5D25D0D186F7740A22515975 { get; set; }

        [JsonProperty("5d9c940886f7742cd41c59c0")]
        public string The5D9C940886F7742Cd41C59C0 { get; set; }

        [JsonProperty("5d9c941f86f7743554286958")]
        public string The5D9C941F86F7743554286958 { get; set; }
    }

    public partial class The5D25D2C186F77443E35162E5
    {
        [JsonProperty("conditions")]
        public The5D25D2C186F77443E35162E5Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25D2C186F77443E35162E5Conditions
    {
        [JsonProperty("5d25d4e786f77442734d335d")]
        public string The5D25D4E786F77442734D335D { get; set; }

        [JsonProperty("5d76322786f774454e50d062")]
        public string The5D76322786F774454E50D062 { get; set; }

        [JsonProperty("5d84afb986f77414e20063ea")]
        public string The5D84Afb986F77414E20063Ea { get; set; }
    }

    public partial class The5D25Dae186F77443E55D2F78
    {
        [JsonProperty("conditions")]
        public The5D25Dae186F77443E55D2F78Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25Dae186F77443E55D2F78Conditions
    {
        [JsonProperty("5d25dc2286f77443e7549028")]
        public string The5D25Dc2286F77443E7549028 { get; set; }

        [JsonProperty("5d76332c86f774454e50d063")]
        public string The5D76332C86F774454E50D063 { get; set; }

        [JsonProperty("5d77cdc286f7742fa65b6603")]
        public string The5D77Cdc286F7742Fa65B6603 { get; set; }
    }

    public partial class The5D25E29D86F7740A22516326
    {
        [JsonProperty("conditions")]
        public The5D25E29D86F7740A22516326Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E29D86F7740A22516326Conditions
    {
        [JsonProperty("5d25fd8386f77443fe457cae")]
        public string The5D25Fd8386F77443Fe457Cae { get; set; }

        [JsonProperty("5d77cd9d86f7742fa857dd73")]
        public string The5D77Cd9D86F7742Fa857Dd73 { get; set; }

        [JsonProperty("5d77cda786f774319c488837")]
        public string The5D77Cda786F774319C488837 { get; set; }
    }

    public partial class The5D25E2A986F77409Dd5Cdf2A
    {
        [JsonProperty("conditions")]
        public The5D25E2A986F77409Dd5Cdf2AConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E2A986F77409Dd5Cdf2AConditions
    {
        [JsonProperty("5d2605ef86f77469ef0f7622")]
        public string The5D2605Ef86F77469Ef0F7622 { get; set; }

        [JsonProperty("5d76336486f7744527181847")]
        public string The5D76336486F7744527181847 { get; set; }

        [JsonProperty("5d77cd3d86f7742fa732bf15")]
        public string The5D77Cd3D86F7742Fa732Bf15 { get; set; }
    }

    public partial class The5D25E2B486F77409De05Bba0
    {
        [JsonProperty("conditions")]
        public The5D25E2B486F77409De05Bba0Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E2B486F77409De05Bba0Conditions
    {
        [JsonProperty("5d26143c86f77469ef0f894c")]
        public string The5D26143C86F77469Ef0F894C { get; set; }

        [JsonProperty("5d763d7c86f774452073df77")]
        public string The5D763D7C86F774452073Df77 { get; set; }

        [JsonProperty("5d77cc4886f7742fa732bf14")]
        public string The5D77Cc4886F7742Fa732Bf14 { get; set; }
    }

    public partial class The5D25E2C386F77443E7549029
    {
        [JsonProperty("conditions")]
        public The5D25E2C386F77443E7549029Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E2C386F77443E7549029Conditions
    {
        [JsonProperty("5d26fd8886f77469f0445745")]
        public string The5D26Fd8886F77469F0445745 { get; set; }

        [JsonProperty("5d2710e686f7742e9019a6b2")]
        public string The5D2710E686F7742E9019A6B2 { get; set; }

        [JsonProperty("5d66741c86f7744a2e70f039")]
        public string The5D66741C86F7744A2E70F039 { get; set; }

        [JsonProperty("5d77689686f7742fa857dd34")]
        public string The5D77689686F7742Fa857Dd34 { get; set; }

        [JsonProperty("5d77c96386f7742fa901bcc7")]
        public string The5D77C96386F7742Fa901Bcc7 { get; set; }
    }

    public partial class The5D25E2Cc86F77443E47Ae019
    {
        [JsonProperty("conditions")]
        public The5D25E2Cc86F77443E47Ae019Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E2Cc86F77443E47Ae019Conditions
    {
        [JsonProperty("5d2701b586f77469f1599fe2")]
        public string The5D2701B586F77469F1599Fe2 { get; set; }

        [JsonProperty("5d7768bf86f774319c488824")]
        public string The5D7768Bf86F774319C488824 { get; set; }

        [JsonProperty("5d77c8df86f7742fa65b6602")]
        public string The5D77C8Df86F7742Fa65B6602 { get; set; }
    }

    public partial class The5D25E2D886F77442734D335E
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5D25E2D886F77442734D335EConditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E2D886F77442734D335EConditions
    {
        [JsonProperty("5d307fc886f77447f15f5b23")]
        public string The5D307Fc886F77447F15F5B23 { get; set; }

        [JsonProperty("5d77695b86f7742fa901bc75")]
        public string The5D77695B86F7742Fa901Bc75 { get; set; }

        [JsonProperty("5d77c84d86f7742fa901bcc6")]
        public string The5D77C84D86F7742Fa901Bcc6 { get; set; }
    }

    public partial class The5D25E2E286F77444001E2E48
    {
        [JsonProperty("conditions")]
        public The5D25E2E286F77444001E2E48Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E2E286F77444001E2E48Conditions
    {
        [JsonProperty("5d2719b186f7740701348573")]
        public string The5D2719B186F7740701348573 { get; set; }

        [JsonProperty("5d271a3486f774483c7bdb12")]
        public string The5D271A3486F774483C7Bdb12 { get; set; }

        [JsonProperty("5d667a8e86f774131e206b46")]
        public string The5D667A8E86F774131E206B46 { get; set; }

        [JsonProperty("5d776b1986f77461b27a2354")]
        public string The5D776B1986F77461B27A2354 { get; set; }

        [JsonProperty("5d77c80b86f7742fa65b6601")]
        public string The5D77C80B86F7742Fa65B6601 { get; set; }
    }

    public partial class The5D25E2Ee86F77443E35162Ea
    {
        [JsonProperty("conditions")]
        public The5D25E2Ee86F77443E35162EaConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E2Ee86F77443E35162EaConditions
    {
        [JsonProperty("5d27276886f7740701348578")]
        public string The5D27276886F7740701348578 { get; set; }

        [JsonProperty("5d272a0b86f7745ba2701532")]
        public string The5D272A0B86F7745Ba2701532 { get; set; }

        [JsonProperty("5d2f464e498f71c8886f7656")]
        public string The5D2F464E498F71C8886F7656 { get; set; }

        [JsonProperty("5d77c65786f7742fa901bcc5")]
        public string The5D77C65786F7742Fa901Bcc5 { get; set; }

        [JsonProperty("5d77c66586f7742fa732bf13")]
        public string The5D77C66586F7742Fa732Bf13 { get; set; }
    }

    public partial class The5D25E43786F7740A212217Fa
    {
        [JsonProperty("conditions")]
        public The5D25E43786F7740A212217FaConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E43786F7740A212217FaConditions
    {
        [JsonProperty("5d272bd386f77446085fa4f9")]
        public string The5D272Bd386F77446085Fa4F9 { get; set; }

        [JsonProperty("5d776ef786f7742fa5005cb5")]
        public string The5D776Ef786F7742Fa5005Cb5 { get; set; }

        [JsonProperty("5d77a48286f77461b27a236b")]
        public string The5D77A48286F77461B27A236B { get; set; }
    }

    public partial class The5D25E44386F77409453Bce7B
    {
        [JsonProperty("conditions")]
        public The5D25E44386F77409453Bce7BConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E44386F77409453Bce7BConditions
    {
        [JsonProperty("5d2733c586f7741dea4f3072")]
        public string The5D2733C586F7741Dea4F3072 { get; set; }

        [JsonProperty("5d77710186f774319c488825")]
        public string The5D77710186F774319C488825 { get; set; }

        [JsonProperty("5d77a45386f774319c488836")]
        public string The5D77A45386F774319C488836 { get; set; }
    }

    public partial class The5D25E44F86F77443E625E385
    {
        [JsonProperty("conditions")]
        public The5D25E44F86F77443E625E385Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E44F86F77443E625E385Conditions
    {
        [JsonProperty("5d27369586f774457411b264")]
        public string The5D27369586F774457411B264 { get; set; }

        [JsonProperty("5d777e3a86f7742fa857dd36")]
        public string The5D777E3A86F7742Fa857Dd36 { get; set; }

        [JsonProperty("5d777eb086f7742fa732bf05")]
        public string The5D777Eb086F7742Fa732Bf05 { get; set; }
    }

    public partial class The5D25E45E86F77408251C4Bfa
    {
        [JsonProperty("conditions")]
        public The5D25E45E86F77408251C4BfaConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E45E86F77408251C4BfaConditions
    {
        [JsonProperty("5d273a4d86f774457411b266")]
        public string The5D273A4D86F774457411B266 { get; set; }

        [JsonProperty("5d777f5d86f7742fa901bc77")]
        public string The5D777F5D86F7742Fa901Bc77 { get; set; }

        [JsonProperty("5d777ffd86f774319c488827")]
        public string The5D777Ffd86F774319C488827 { get; set; }

        [JsonProperty("5d77a3b286f7745041358b44")]
        public string The5D77A3B286F7745041358B44 { get; set; }
    }

    public partial class The5D25E46E86F77409453Bce7C
    {
        [JsonProperty("conditions")]
        public The5D25E46E86F77409453Bce7CConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E46E86F77409453Bce7CConditions
    {
        [JsonProperty("5d27446f86f77475a86565a3")]
        public string The5D27446F86F77475A86565A3 { get; set; }

        [JsonProperty("5d7782c686f7742fa732bf07")]
        public string The5D7782C686F7742Fa732Bf07 { get; set; }

        [JsonProperty("5d7782f886f7742fa65b65f5")]
        public string The5D7782F886F7742Fa65B65F5 { get; set; }

        [JsonProperty("5d77830086f7745041358b35")]
        public string The5D77830086F7745041358B35 { get; set; }

        [JsonProperty("5d77a38e86f7745041358b43")]
        public string The5D77A38E86F7745041358B43 { get; set; }
    }

    public partial class The5D25E48186F77443E625E386
    {
        [JsonProperty("conditions")]
        public The5D25E48186F77443E625E386Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E48186F77443E625E386Conditions
    {
        [JsonProperty("5d357b6c86f774588d4d7e25")]
        public string The5D357B6C86F774588D4D7E25 { get; set; }

        [JsonProperty("5d357b9586f7745b422d653f")]
        public string The5D357B9586F7745B422D653F { get; set; }

        [JsonProperty("5d357bb786f774588d4d7e27")]
        public string The5D357Bb786F774588D4D7E27 { get; set; }

        [JsonProperty("5d7784cc86f7742fa5005cba")]
        public string The5D7784Cc86F7742Fa5005Cba { get; set; }

        [JsonProperty("5d77854786f7745041358b36")]
        public string The5D77854786F7745041358B36 { get; set; }

        [JsonProperty("5d77a36086f77461b27a236a")]
        public string The5D77A36086F77461B27A236A { get; set; }
    }

    public partial class The5D25E48D86F77408251C4Bfb
    {
        [JsonProperty("conditions")]
        public The5D25E48D86F77408251C4BfbConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E48D86F77408251C4BfbConditions
    {
        [JsonProperty("5d27491686f77475aa5cf5b9")]
        public string The5D27491686F77475Aa5Cf5B9 { get; set; }

        [JsonProperty("5d6949e786f774238a38d9e0")]
        public string The5D6949E786F774238A38D9E0 { get; set; }

        [JsonProperty("5d77a27d86f774319c488835")]
        public string The5D77A27D86F774319C488835 { get; set; }

        [JsonProperty("5d77a29b86f7742fa65b6600")]
        public string The5D77A29B86F7742Fa65B6600 { get; set; }
    }

    public partial class The5D25E4Ad86F77443E625E387
    {
        [JsonProperty("conditions")]
        public The5D25E4Ad86F77443E625E387Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E4Ad86F77443E625E387Conditions
    {
        [JsonProperty("5d27522686f774304e316405")]
        public string The5D27522686F774304E316405 { get; set; }

        [JsonProperty("5d357e0e86f7745b3f307c56")]
        public string The5D357E0E86F7745B3F307C56 { get; set; }

        [JsonProperty("5d357e8786f7745b5e66a51a")]
        public string The5D357E8786F7745B5E66A51A { get; set; }

        [JsonProperty("5d778e6c86f77461b27a235d")]
        public string The5D778E6C86F77461B27A235D { get; set; }

        [JsonProperty("5d778e7c86f7742fa901bc7c")]
        public string The5D778E7C86F7742Fa901Bc7C { get; set; }

        [JsonProperty("5d77a24986f7742fa65b65ff")]
        public string The5D77A24986F7742Fa65B65Ff { get; set; }
    }

    public partial class The5D25E4B786F77408251C4Bfc
    {
        [JsonProperty("conditions")]
        public The5D25E4B786F77408251C4BfcConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E4B786F77408251C4BfcConditions
    {
        [JsonProperty("5d2f375186f7745916404955")]
        public string The5D2F375186F7745916404955 { get; set; }

        [JsonProperty("5d778ebb86f7742fa732bf09")]
        public string The5D778Ebb86F7742Fa732Bf09 { get; set; }

        [JsonProperty("5d778ec586f7745041358b37")]
        public string The5D778Ec586F7745041358B37 { get; set; }

        [JsonProperty("5d778f7d86f7742fa65b65f9")]
        public string The5D778F7D86F7742Fa65B65F9 { get; set; }

        [JsonProperty("5d8a09d386f77410b4225d13")]
        public string The5D8A09D386F77410B4225D13 { get; set; }
    }

    public partial class The5D25E4Ca86F77409Dd5Cdf2C
    {
        [JsonProperty("conditions")]
        public The5D25E4Ca86F77409Dd5Cdf2CConditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E4Ca86F77409Dd5Cdf2CConditions
    {
        [JsonProperty("5d66920c86f774368d281afe")]
        public string The5D66920C86F774368D281Afe { get; set; }

        [JsonProperty("5d7793fa86f7742fa901bc80")]
        public string The5D7793Fa86F7742Fa901Bc80 { get; set; }

        [JsonProperty("5d77940986f7742fa732bf0a")]
        public string The5D77940986F7742Fa732Bf0A { get; set; }
    }

    public partial class The5D25E4D586F77443E625E388
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5D25E4D586F77443E625E388Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D25E4D586F77443E625E388Conditions
    {
        [JsonProperty("5d77a16486f77461b27a2369")]
        public string The5D77A16486F77461B27A2369 { get; set; }

        [JsonProperty("5d77a17386f7742fa901bcc2")]
        public string The5D77A17386F7742Fa901Bcc2 { get; set; }

        [JsonProperty("5d8a05d086f77410b4225d10")]
        public string The5D8A05D086F77410B4225D10 { get; set; }
    }

    public partial class The5D4Bec3486F7743Cac246665
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("conditions")]
        public The5D4Bec3486F7743Cac246665Conditions Conditions { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D4Bec3486F7743Cac246665Conditions
    {
        [JsonProperty("5d4bfe4b86f7744a9d4fe032")]
        public string The5D4Bfe4B86F7744A9D4Fe032 { get; set; }

        [JsonProperty("5d4bfe7c86f7744a9c66b316")]
        public string The5D4Bfe7C86F7744A9C66B316 { get; set; }

        [JsonProperty("5d4c020a86f77449c463ced6")]
        public string The5D4C020A86F77449C463Ced6 { get; set; }

        [JsonProperty("5d4c028c86f774389001e027")]
        public string The5D4C028C86F774389001E027 { get; set; }

        [JsonProperty("5d761f6886f7744521734218")]
        public string The5D761F6886F7744521734218 { get; set; }

        [JsonProperty("5d77db2186f7745041358b57")]
        public string The5D77Db2186F7745041358B57 { get; set; }
    }

    public partial class The5D6Fb2C086F77449Da599C24
    {
        [JsonProperty("conditions")]
        public The5D6Fb2C086F77449Da599C24Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D6Fb2C086F77449Da599C24Conditions
    {
        [JsonProperty("5d6fb8a886f77449db3db8b6")]
        public string The5D6Fb8A886F77449Db3Db8B6 { get; set; }

        [JsonProperty("5d77c61786f7742fa732bf12")]
        public string The5D77C61786F7742Fa732Bf12 { get; set; }
    }

    public partial class The5D6Fbc2886F77449D825F9D3
    {
        [JsonProperty("conditions")]
        public The5D6Fbc2886F77449D825F9D3Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5D6Fbc2886F77449D825F9D3Conditions
    {
        [JsonProperty("5d6fbf0f86f77449d97f738e")]
        public string The5D6Fbf0F86F77449D97F738E { get; set; }

        [JsonProperty("5d77c55886f7742fa901bcc4")]
        public string The5D77C55886F7742Fa901Bcc4 { get; set; }
    }

    public partial class The5Dc53Acb86F77469C740C893
    {
        [JsonProperty("conditions")]
        public The5Dc53Acb86F77469C740C893Conditions Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("successMessageText")]
        public string SuccessMessageText { get; set; }

        [JsonProperty("failMessageText")]
        public string FailMessageText { get; set; }

        [JsonProperty("startedMessageText")]
        public string StartedMessageText { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class The5Dc53Acb86F77469C740C893Conditions
    {
        [JsonProperty("5dc53fd386f77469c87589a3")]
        public string The5Dc53Fd386F77469C87589A3 { get; set; }

        [JsonProperty("5dc541ad86f7741416111d02")]
        public string The5Dc541Ad86F7741416111D02 { get; set; }

        [JsonProperty("5dc541c386f77469c87589a6")]
        public string The5Dc541C386F77469C87589A6 { get; set; }
    }

    public partial class Season
    {
        [JsonProperty("5be3dd9c88a4504fbc1670a5")]
        public string The5Be3Dd9C88A4504Fbc1670A5 { get; set; }

        [JsonProperty("5c0559d388a450481c1f62b8")]
        public string The5C0559D388A450481C1F62B8 { get; set; }

        [JsonProperty("5c5171df88a4505c2d656cd9")]
        public string The5C5171Df88A4505C2D656Cd9 { get; set; }

        [JsonProperty("5ce3ff7d88a4501de86aa707")]
        public string The5Ce3Ff7D88A4501De86Aa707 { get; set; }
    }

    public partial class Template
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ShortName")]
        public string ShortName { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("casingName")]
        public string CasingName { get; set; }

        [JsonProperty("RigLayoutName")]
        public string RigLayoutName { get; set; }

        [JsonProperty("FoldedSlot")]
        public string FoldedSlot { get; set; }
    }

    public partial class Trading
    {
        [JsonProperty("FullName")]
        public string FullName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("Nickname")]
        public string Nickname { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EFTBot.Data.Models.RequestModels.Profile
{
    public class Settings
    {
        public string Role { get; set; }
        public string BotDifficulty { get; set; }
        public int Experience { get; set; }
    }

    public class Info
    {
        public string Nickname { get; set; }
        public string LowerNickname { get; set; }
        public string Side { get; set; }
        public string Voice { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int RegistrationDate { get; set; }
        public string GameVersion { get; set; }
        public int AccountType { get; set; }
        public object MemberCategory { get; set; }
        public bool lockedMoveCommands { get; set; }
        public int SavageLockTime { get; set; }
        public int LastTimePlayedAsSavage { get; set; }
        public Settings Settings { get; set; }
        public bool NeedWipe { get; set; }
        public bool GlobalWipe { get; set; }
        public int NicknameChangeDate { get; set; }
        public List<object> Bans { get; set; }
    }

    public class Customization
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Feet { get; set; }
        public string Hands { get; set; }
    }

    public class Hydration
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class Energy
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class Health2
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class Head
    {
        public Health2 Health { get; set; }
    }

    public class Health3
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class Chest
    {
        public Health3 Health { get; set; }
    }

    public class Health4
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class Stomach
    {
        public Health4 Health { get; set; }
    }

    public class Health5
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class LeftArm
    {
        public Health5 Health { get; set; }
    }

    public class Health6
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class RightArm
    {
        public Health6 Health { get; set; }
    }

    public class Health7
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class LeftLeg
    {
        public Health7 Health { get; set; }
    }

    public class Health8
    {
        public float Current { get; set; }
        public float Maximum { get; set; }
    }

    public class RightLeg
    {
        public Health8 Health { get; set; }
    }

    public class BodyParts
    {
        public Head Head { get; set; }
        public Chest Chest { get; set; }
        public Stomach Stomach { get; set; }
        public LeftArm LeftArm { get; set; }
        public RightArm RightArm { get; set; }
        public LeftLeg LeftLeg { get; set; }
        public RightLeg RightLeg { get; set; }
    }

    public class Health
    {
        public Hydration Hydration { get; set; }
        public Energy Energy { get; set; }
        public BodyParts BodyParts { get; set; }
        public int UpdateTime { get; set; }
    }

    public class Repairable
    {
        public double MaxDurability { get; set; }
        public double Durability { get; set; }
    }

    public class Key
    {
        public int NumberOfUsages { get; set; }
    }

    public class Resource
    {
        public int Value { get; set; }
    }

    public class Dogtag
    {
        public string Nickname { get; set; }
        public string Side { get; set; }
        public int Level { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public string KillerName { get; set; }
        public string WeaponName { get; set; }
    }

    public class MedKit
    {
        public int HpResource { get; set; }
    }

    public class Togglable
    {
        public bool On { get; set; }
    }

    public class FaceShield
    {
        public int Hits { get; set; }
        public int HitSeed { get; set; }
    }

    public class FireModes
    {
        public string FireMode { get; set; }
    }

    public class Light
    {
        public bool IsActive { get; set; }
        public int SelectedMode { get; set; }
    }

    public class Sight
    {
        public int SelectedSightMode { get; set; }
    }

    public class Tag
    {
        public int Color { get; set; }
        public string Name { get; set; }
    }

    public class Upd
    {
        public Repairable Repairable { get; set; }
        public Key Key { get; set; }
        public int? StackObjectsCount { get; set; }
        public Resource Resource { get; set; }
        public Dogtag Dogtag { get; set; }
        public MedKit MedKit { get; set; }
        public Togglable Togglable { get; set; }
        public FaceShield FaceShield { get; set; }
        public bool? SpawnedInSession { get; set; }
        public FireModes FireMode { get; set; }
        public Light Light { get; set; }
        public Sight Sight { get; set; }
        public Tag Tag { get; set; }
    }

    public class Location
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("r")]
        public int R { get; set; }

        [JsonProperty("isSearched")]
        public bool IsSearched { get; set; }

        public override bool Equals(object obj)
        {
            var locTwo = obj as Location;
            if (locTwo == null) return false;
            return X == locTwo.X &&
                   Y == locTwo.Y &&
                   R == locTwo.R;
        }

        public override string ToString() => $"{X}, {Y}, {R}";
    }

    public class PlayerItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_tpl")]
        public string ItemTypeId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("slotId")]
        public string SlotId { get; set; }

        [JsonProperty("upd")]
        public Upd Upd { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }

    public class FastPanel
    {
    }

    public class Inventory
    {
        [JsonProperty("items")]
        public List<PlayerItem> Items { get; set; }

        [JsonProperty("equipment")]
        public string Equipment { get; set; }

        [JsonProperty("stash")]
        public string Stash { get; set; }

        [JsonProperty("questRaidItems")]
        public string QuestRaidItems { get; set; }

        [JsonProperty("questStashItems")]
        public string QuestStashItems { get; set; }

        [JsonProperty("fastPanel")]
        public FastPanel FastPanel { get; set; }
    }

    public class Common
    {
        public string Id { get; set; }
        public double Progress { get; set; }
        public int PointsEarnedDuringSession { get; set; }
        public int LastAccess { get; set; }
    }

    public class Mastering
    {
        public string Id { get; set; }
        public int Progress { get; set; }
    }

    public class Skills
    {
        public List<Common> Common { get; set; }
        public List<Mastering> Mastering { get; set; }
        public int Points { get; set; }
    }

    public class Item2
    {
        public List<string> Key { get; set; }
        public int Value { get; set; }
    }

    public class SessionCounters
    {
        public List<Item2> Items { get; set; }
    }

    public class Item3
    {
        public List<string> Key { get; set; }
        public int Value { get; set; }
    }

    public class OverallCounters
    {
        public List<Item3> Items { get; set; }
    }

    public class Aggressor
    {
        public string Name { get; set; }
        public string Side { get; set; }
        public string BodyPart { get; set; }
        public string HeadSegment { get; set; }
        public string WeaponName { get; set; }
        public string Category { get; set; }
    }

    public class Stats
    {
        public SessionCounters SessionCounters { get; set; }
        public OverallCounters OverallCounters { get; set; }
        public double SessionExperienceMult { get; set; }
        public int ExperienceBonusMult { get; set; }
        public int TotalSessionExperience { get; set; }
        public int LastSessionDate { get; set; }
        public Aggressor Aggressor { get; set; }
        public List<object> DroppedItems { get; set; }
        public List<object> FoundInRaidItems { get; set; }
        public List<object> Victims { get; set; }
        public List<object> CarriedQuestItems { get; set; }
        public int TotalInGameTime { get; set; }
        public string SurvivorClass { get; set; }
    }

    public class ConditionCounters
    {
        public List<object> Counters { get; set; }
    }

    public class Production
    {
    }

    public class Area
    {
        public int type { get; set; }
        public int level { get; set; }
        public bool active { get; set; }
        public bool passiveBonusesEnabled { get; set; }
        public int completeTime { get; set; }
        public bool constructing { get; set; }
        public List<object> slots { get; set; }
    }

    public class Hideout
    {
        public Production Production { get; set; }
        public List<Area> Areas { get; set; }
    }

    public class ProfileNotes
    {
        public List<object> PNotes { get; set; }
    }

    public class TraderStandings
    {
    }

    public class RagfairInfo
    {
        public double rating { get; set; }
        public bool isRatingGrowing { get; set; }
        public List<object> offers { get; set; }
    }

    public class PlayerProfile
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        public int aid { get; set; }
        public string savage { get; set; }
        public Info Info { get; set; }
        public Customization Customization { get; set; }
        public Health Health { get; set; }
        public Inventory Inventory { get; set; }
        public Skills Skills { get; set; }
        public Stats Stats { get; set; }
        //public Encyclopedia Encyclopedia { get; set; }
        public ConditionCounters ConditionCounters { get; set; }
        //public BackendCounters BackendCounters { get; set; }
        public List<object> InsuredItems { get; set; }
        public Hideout Hideout { get; set; }
        public List<object> Bonuses { get; set; }
        public ProfileNotes Notes { get; set; }
        public List<object> Quests { get; set; }
        public TraderStandings TraderStandings { get; set; }
        public RagfairInfo RagfairInfo { get; set; }
        public List<object> WishList { get; set; }
    }

    public class RootObject
    {
        public int err { get; set; }
        public object errmsg { get; set; }
        public List<PlayerProfile> data { get; set; }
    }
}

using System.Collections.Generic;

namespace CODBO4.Models
{
    public class ProfileBlackout
    {
        public class User
        {
            public int id { get; set; }
            public string username { get; set; }
            public string platform { get; set; }
            public string title { get; set; }
        }

        public class Cache
        {
            public int time { get; set; }
            public int expire { get; set; }
            public int interval { get; set; }
        }

        public class BlackoutExtra
        {
            public int top5placementteam { get; set; }
            public int top10placementteam { get; set; }
            public int top15placementteam { get; set; }
            public int top5placementsolo { get; set; }
            public int top25placementsolo { get; set; }
            public int vehicleescapes { get; set; }
            public int vehiclescavengerair { get; set; }
            public int vehiclescavengerland { get; set; }
            public int vehiclescavengerwater { get; set; }
            public int vehiclesdestroyed { get; set; }
            public int vehicleusedall { get; set; }
            public int vehiclelockexits { get; set; }
            public int vehiclessestroyedoccupied { get; set; }
            public int vehicledamageoccupied { get; set; }
            public int killsvehicledriver { get; set; }
            public int vehicledamage { get; set; }
            public int winswithoutkills { get; set; }
            public int mostkillsinagame { get; set; }
            public int distancetraveledwingsuit { get; set; }
            public int distancetraveledwingsuitmiles { get; set; }
            public int distancetraveledvehicleland { get; set; }
            public int distancetraveledvehiclelandmiles { get; set; }
            public int distancetraveledvehicleair { get; set; }
            public int distancetraveledvehicleairmiles { get; set; }
            public int distancetraveledvehiclewater { get; set; }
            public int distancetraveledvehiclewatermiles { get; set; }
            public int itemspickedup { get; set; }
            public int itemsdropped { get; set; }
            public int killsrevenge { get; set; }
        }

        public class Stats
        {
            public BlackoutExtra blackoutExtra { get; set; }
            public int highestkillgame { get; set; }
            public int highestekiagame { get; set; }
            public int highesttotalshots { get; set; }
            public int level { get; set; }
            public int maxlevel { get; set; }
            public int prestige { get; set; }
            public int prestigeid { get; set; }
            public int maxprestige { get; set; }
            public int levelxpgained { get; set; }
            public int levelxpremainder { get; set; }
            public int kills { get; set; }
            public int killsconfirmed { get; set; }
            public int deaths { get; set; }
            public int gamesplayed { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public int melee { get; set; }
            public int hits { get; set; }
            public int misses { get; set; }
            public int rankxp { get; set; }
            public int careerscore { get; set; }
            public int totalheals { get; set; }
            public int ekia { get; set; }
            public int longestkillstreak { get; set; }
            public int curwinstreak { get; set; }
            public int totalshots { get; set; }
            public int teamkills { get; set; }
            public int suicides { get; set; }
            public int offends { get; set; }
            public int killsdenied { get; set; }
            public int captures { get; set; }
            public int defends { get; set; }
            public int revives { get; set; }
            public int timeplayed { get; set; }
            public string weapondata { get; set; }
            public string gamemodedata { get; set; }
            public string mapdata { get; set; }
        }

        public class Match
        {
            public string identifier { get; set; }
            public int kills { get; set; }
            public int ekia { get; set; }
            public int deaths { get; set; }
            public int gamesplayed { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public int rankxp { get; set; }
            public int time { get; set; }
            public string format { get; set; }
        }

        public class Lastmatch
        {
            public string identifier { get; set; }
            public int kills { get; set; }
            public int ekia { get; set; }
            public int deaths { get; set; }
            public int gamesplayed { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public int rankxp { get; set; }
            public int time { get; set; }
            public string format { get; set; }
        }

        public string identifier { get; set; }
        public string type { get; set; }
        public User user { get; set; }
        public Cache cache { get; set; }
        public Stats stats { get; set; }
        public IList<Match> matches { get; set; }
        public Lastmatch lastmatch { get; set; }
        public IList<object> gamemodedata { get; set; }
        public IList<object> mapdata { get; set; }
        public IList<object> weapondata { get; set; }
    }
}

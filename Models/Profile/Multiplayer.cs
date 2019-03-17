namespace CODBO4.Models.Profile
{
    public class Multiplayer
    {
        public class User : Blackout.User
        {
            public string avatar { get; set; }
        }

        public class Stats
        {
            public int highestkillgame { get; set; }
            public int highestekiagame { get; set; }
            public int highesttotalshots { get; set; }
            public int level { get; set; }
            public int maxlevel { get; set; }
            public int prestige { get; set; }
            public int prestigeid { get; set; }
            public int maxprestige { get; set; }
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
            public int timeplayed { get; set; }
            public string weapondata { get; set; }
            public string gamemodedata { get; set; }
            public string mapdata { get; set; }
        }

        public class Match : Common.Match
        {
            public int totalshots { get; set; }
            public int captures { get; set; }
            public int defends { get; set; }
            public int careerscore { get; set; }
            public int timeplayed { get; set; }
        }

        public string identifier { get; set; }
        public User user { get; set; }
        public Common.Cache cache { get; set; }
        public Stats stats { get; set; }
        public Match[] matches { get; set; }
        public Match lastmatch { get; set; }
        public object[] gamemodedata { get; set; }
        public object[] mapdata { get; set; }
        public object[] weapondata { get; set; }
    }
}

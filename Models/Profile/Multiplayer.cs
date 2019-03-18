namespace CODBO4.Models.Profile
{
    public class Multiplayer
    {
        public class UserInfo : Blackout.User
        {
            public string Avatar { get; set; }
        }

        public class StatsInfo
        {
            public int HighestKillGame { get; set; }
            public int HighestEkiaGame { get; set; }
            public int HighestTotalShots { get; set; }
            public int Level { get; set; }
            public int MaxLevel { get; set; }
            public int Prestige { get; set; }
            public int PrestigeId { get; set; }
            public int MaxPrestige { get; set; }
            public int Kills { get; set; }
            public int KillsConfirmed { get; set; }
            public int Deaths { get; set; }
            public int GamesPlayed { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Melee { get; set; }
            public int Hits { get; set; }
            public int Misses { get; set; }
            public int RankXp { get; set; }
            public int CareerScore { get; set; }
            public int TotalHeals { get; set; }
            public int Ekia { get; set; }
            public int LongestKillstreak { get; set; }
            public int CurWinStreak { get; set; }
            public int TotalShots { get; set; }
            public int TeamKills { get; set; }
            public int Suicides { get; set; }
            public int Offends { get; set; }
            public int KillsDenied { get; set; }
            public int Captures { get; set; }
            public int Defends { get; set; }
            public int TimePlayed { get; set; }
            public string WeaponData { get; set; }
            public string GameModeData { get; set; }
            public string MapData { get; set; }
        }

        public class Match : Common.Match
        {
            public int TotalShots { get; set; }
            public int Captures { get; set; }
            public int Defends { get; set; }
            public int CareerScore { get; set; }
            public int TimePlayed { get; set; }
        }

        public string Identifier { get; set; }
        public UserInfo User { get; set; }
        public Common.Cache Cache { get; set; }
        public StatsInfo Stats { get; set; }
        public Match[] Matches { get; set; }
        public Match LastMatch { get; set; }
        public object[] GameModeData { get; set; }
        public object[] MapData { get; set; }
        public object[] WeaponData { get; set; }
    }
}

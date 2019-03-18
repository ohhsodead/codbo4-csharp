namespace CODBO4.Models.Common
{
    public class MatchInfo
    {
        public int MatchDuration { get; set; }
        public string MatchType { get; set; }
        public string MatchMapId { get; set; }
        public string MatchMode { get; set; }
    }

    public class TeamScore
    {
        public int Team1 { get; set; }
        public int Team2 { get; set; }
    }

    public class Teams
    {
        public TeamScore TeamScore { get; set; }
        public int WinningTeam { get; set; }
    }

    public class Stats
    {
        public int Kills { get; set; }
        public int Assists { get; set; }
        public int Deaths { get; set; }
        public int Headshots { get; set; }
        public int ShotsFired { get; set; }
        public int ShotsLanded { get; set; }
        public int ShotsMissed { get; set; }
    }

    public class PlayerEntry : Stats
    {
        public int Uid { get; set; }
        public int Prestige { get; set; }
        public int Rank { get; set; }
        public int Team { get; set; }
        public int Position { get; set; }
        public int Ekia { get; set; }
        public int HighestKillStreak { get; set; }
    }

    public class Entry
    {
        public string Mid { get; set; }
        public int UtcStart { get; set; }
        public int UtcEnd { get; set; }
        public MatchInfo MatchInfo { get; set; }
        public Teams Teams { get; set; }
        public PlayerEntry[] PlayerEntries { get; set; }
    }

    public class Cache
    {
        public int Time { get; set; }
        public int Expire { get; set; }
        public int Interval { get; set; }
    }

    public abstract class Match
    {
        public string Identifier { get; set; }
        public int Kills { get; set; }
        public int Ekia { get; set; }
        public int Deaths { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Time { get; set; }
        public string Format { get; set; }
    }

    public abstract class Matches
    {
        public bool Success { get; set; }
        public string Game { get; set; }
        public string Platform { get; set; }
    }
}

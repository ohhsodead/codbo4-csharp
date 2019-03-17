namespace CODBO4.Models.Common
{
    public class MatchInfo
    {
        public int matchDuration { get; set; }
        public string matchType { get; set; }
        public string matchMapId { get; set; }
        public string matchMode { get; set; }
    }

    public class TeamScore
    {
        public int team1 { get; set; }
        public int team2 { get; set; }
    }

    public class Teams
    {
        public TeamScore teamScore { get; set; }
        public int winningTeam { get; set; }
    }

    public class Stats
    {
        public int kills { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int headshots { get; set; }
        public int shotsFired { get; set; }
        public int shotsLanded { get; set; }
        public int shotsMissed { get; set; }
    }

    public class PlayerEntry : Stats
    {
        public int uid { get; set; }
        public int prestige { get; set; }
        public int rank { get; set; }
        public int team { get; set; }
        public int position { get; set; }
        public int ekia { get; set; }
        public int highestKillStreak { get; set; }
    }

    public class Entry
    {
        public string mid { get; set; }
        public int utcStart { get; set; }
        public int utcEnd { get; set; }
        public MatchInfo matchInfo { get; set; }
        public Teams teams { get; set; }
        public PlayerEntry[] playerEntries { get; set; }
    }

    public class Cache
    {
        public int time { get; set; }
        public int expire { get; set; }
        public int interval { get; set; }
    }

    public abstract class Match
    {
        public string identifier { get; set; }
        public int kills { get; set; }
        public int ekia { get; set; }
        public int deaths { get; set; }
        public int gamesplayed { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int time { get; set; }
        public string format { get; set; }
    }

    public abstract class Matches
    {
        public bool success { get; set; }
        public string game { get; set; }
        public string platform { get; set; }
    }
}

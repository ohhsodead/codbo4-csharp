using System.Collections.Generic;

namespace CODBO4.Models
{
    public class Match
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

        public class PlayerEntry
        {
            public int uid { get; set; }
            public int prestige { get; set; }
            public int rank { get; set; }
            public int team { get; set; }
            public int position { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int ekia { get; set; }
            public int highestKillStreak { get; set; }
            public int assists { get; set; }
            public int headshots { get; set; }
            public int shotsFired { get; set; }
            public int shotsLanded { get; set; }
            public int shotsMissed { get; set; }
        }

        public class Entry
        {
            public string mid { get; set; }
            public int utcStart { get; set; }
            public int utcEnd { get; set; }
            public MatchInfo matchInfo { get; set; }
            public Teams teams { get; set; }
            public IList<PlayerEntry> playerEntries { get; set; }
        }

        public bool success { get; set; }
        public string game { get; set; }
        public string platform { get; set; }
        public IList<Entry> entry { get; set; }
    }
}

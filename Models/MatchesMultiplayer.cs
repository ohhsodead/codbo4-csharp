using System.Collections.Generic;

namespace CODBO4.Models
{
    public class MatchesMultiplayer
    {
        public class TeamScore
        {
            public int team1 { get; set; }
            public int team2 { get; set; }
        }

        public class Teams
        {
            public int winningTeam { get; set; }
            public int playerTeam { get; set; }
            public int playerPosition { get; set; }
            public TeamScore teamScore { get; set; }
        }

        public class Stats
        {
            public int kills { get; set; }
            public int ekia { get; set; }
            public int assists { get; set; }
            public int deaths { get; set; }
            public int highestKillStreak { get; set; }
            public int headshots { get; set; }
            public int shotsFired { get; set; }
            public int shotsLanded { get; set; }
            public int shotsMissed { get; set; }
        }

        public class Entry
        {
            public string identifier { get; set; }
            public string gameMode { get; set; }
            public string gameModeName { get; set; }
            public string map { get; set; }
            public string mapName { get; set; }
            public string mapImage { get; set; }
            public int matchStart { get; set; }
            public int matchEnd { get; set; }
            public int matchWon { get; set; }
            public int CTS { get; set; }
            public Teams teams { get; set; }
            public Stats stats { get; set; }
            public string formatForSite { get; set; }
            public bool privateMatch { get; set; }
        }

        public bool success { get; set; }
        public int uid { get; set; }
        public string username { get; set; }
        public string platform { get; set; }
        public string game { get; set; }
        public string type { get; set; }
        public int matchesCount { get; set; }
        public IList<Entry> entries { get; set; }
    }
}

namespace CODBO4.Models.Match
{
    public class Blackout : Profile.User
    {
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
            public Common.Stats stats { get; set; }
            public string formatForSite { get; set; }
            public bool privateMatch { get; set; }
        }

        public bool success { get; set; }
        public string type { get; set; }
        public int matchesCount { get; set; }
        public Entry[] entries { get; set; }
    }
}

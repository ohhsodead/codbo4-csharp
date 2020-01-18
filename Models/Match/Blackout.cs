namespace CODBO4.Models.Match
{
    public class Blackout : Profile.User
    {
        public class Entry
        {
            public string Identifier { get; set; }
            public string GameMode { get; set; }
            public string GameModeName { get; set; }
            public string Map { get; set; }
            public string MapName { get; set; }
            public string MapImage { get; set; }
            public int MatchStart { get; set; }
            public int MatchEnd { get; set; }
            public int MatchWon { get; set; }
            public int Cts { get; set; }
            public Common.Stats Stats { get; set; }
            public string FormatForSite { get; set; }
            public bool PrivateMatch { get; set; }
        }

        public bool Success { get; set; }
        public string Type { get; set; }
        public int MatchesCount { get; set; }
        public Entry[] Entries { get; set; }
    }
}

namespace CODBO4.Models
{
    public class Leaderboards
    {
        public class Level
        {
            public int id { get; set; }
            public string image { get; set; }
        }

        public class Prestige
        {
            public int id { get; set; }
            public string image { get; set; }
        }

        public class Entry
        {
            public string username { get; set; }
            public string platform { get; set; }
            public Level level { get; set; }
            public Prestige prestige { get; set; }
            public int kills { get; set; }
            public int deaths { get; set; }
            public int ekia { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public int gamesplayed { get; set; }
            public int timeplayed { get; set; }
        }

        public int rows { get; set; }
        public string platform { get; set; }
        public string scope { get; set; }
        public Entry[] entries { get; set; }
    }
}

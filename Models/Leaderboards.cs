namespace CODBO4.Models
{
    public class Leaderboards
    {
        public class Level
        {
            public int Id { get; set; }
            public string Image { get; set; }
        }

        public class Prestige : Level
        {
        }

        public class Entry
        {
            public string Username { get; set; }
            public string Platform { get; set; }
            public Level Level { get; set; }
            public Prestige Prestige { get; set; }
            public int Kills { get; set; }
            public int Deaths { get; set; }
            public int Ekia { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int GamesPlayed { get; set; }
            public int TimePlayed { get; set; }
        }

        public int Rows { get; set; }
        public string Platform { get; set; }
        public string Scope { get; set; }
        public Entry[] Entries { get; set; }
    }
}

namespace CODBO4.Models.Match
{
    public class Multiplayer : Blackout
    {
        public class Teams : Common.Teams
        {
            public int PlayerTeam { get; set; }
            public int PlayerPosition { get; set; }
        }

        public class Stats : Common.Stats
        {
            public int Ekia { get; set; }
            public int HighestKillStreak { get; set; }
        }

        public new class Entry : Blackout.Entry
        {
            public Teams Teams { get; set; }
            public new Stats Stats { get; set; }
        }

        public new Entry[] Entries { get; set; }
    }
}

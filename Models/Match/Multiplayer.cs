namespace CODBO4.Models.Match
{
    public class Multiplayer : Blackout
    {
        public class Teams : Common.Teams
        {
            public int playerTeam { get; set; }
            public int playerPosition { get; set; }
        }

        public class Stats : Common.Stats
        {
            public int ekia { get; set; }
            public int highestKillStreak { get; set; }
        }

        public new class Entry : Blackout.Entry
        {
            public Teams teams { get; set; }
            public new Stats stats { get; set; }
        }

        public new Entry[] entries { get; set; }
    }
}

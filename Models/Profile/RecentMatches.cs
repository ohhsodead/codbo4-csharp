namespace CODBO4.Models.Match
{
    public class RecentMatches : Common.Matches
    {
        public int rows { get; set; }
        public Common.Entry[] entries { get; set; }
    }
}

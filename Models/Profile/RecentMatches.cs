namespace CODBO4.Models.Match
{
    public class RecentMatches : Common.Matches
    {
        public int Rows { get; set; }
        public Common.Entry[] Entries { get; set; }
    }
}

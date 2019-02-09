using System.ComponentModel;

namespace CODBO4.Enums
{
    public enum Scope
    {
        [Description("kills")]
        Kills,

        [Description("deaths")]
        Deaths,

        [Description("ekia")]
        Ekia,

        [Description("wins")]
        Wins,

        [Description("losses")]
        Losses,

        [Description("gamesplayed")]
        GamesPlayed,

        [Description("timeplayed")]
        TimePlayed
    }
}

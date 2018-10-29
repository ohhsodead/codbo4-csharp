using System.ComponentModel;

namespace CODBO4
{
	public enum Platform
	{
		[Description("psn")]
		PS4,

		[Description("xbl")]
		XboxOne,

		[Description("steam")]
		PC,

        [Description("bnet")]
        BattleNet
    }
}
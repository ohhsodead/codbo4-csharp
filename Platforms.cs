using System.ComponentModel;

namespace CODBO4
{
	public enum Platform
	{
		[Description("psn")]
		PS4,

		[Description("xb1")]
		XboxOne,

		[Description("steam")]
		PC,

        [Description("bnet")]
        BattleNet
    }
}
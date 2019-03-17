namespace CODBO4.Models.Profile
{
    public class Blackout : Multiplayer
    {
        public new class User
        {
            public int id { get; set; }
            public string username { get; set; }
            public string platform { get; set; }
            public string title { get; set; }
        }

        public class BlackoutExtra
        {
            public int top5placementteam { get; set; }
            public int top10placementteam { get; set; }
            public int top15placementteam { get; set; }
            public int top5placementsolo { get; set; }
            public int top25placementsolo { get; set; }
            public int vehicleescapes { get; set; }
            public int vehiclescavengerair { get; set; }
            public int vehiclescavengerland { get; set; }
            public int vehiclescavengerwater { get; set; }
            public int vehiclesdestroyed { get; set; }
            public int vehicleusedall { get; set; }
            public int vehiclelockexits { get; set; }
            public int vehiclessestroyedoccupied { get; set; }
            public int vehicledamageoccupied { get; set; }
            public int killsvehicledriver { get; set; }
            public int vehicledamage { get; set; }
            public int winswithoutkills { get; set; }
            public int mostkillsinagame { get; set; }
            public int distancetraveledwingsuit { get; set; }
            public int distancetraveledwingsuitmiles { get; set; }
            public int distancetraveledvehicleland { get; set; }
            public int distancetraveledvehiclelandmiles { get; set; }
            public int distancetraveledvehicleair { get; set; }
            public int distancetraveledvehicleairmiles { get; set; }
            public int distancetraveledvehiclewater { get; set; }
            public int distancetraveledvehiclewatermiles { get; set; }
            public int itemspickedup { get; set; }
            public int itemsdropped { get; set; }
            public int killsrevenge { get; set; }
        }

        public new class Stats : Multiplayer.Stats
        {
            public BlackoutExtra blackoutExtra { get; set; }
            public int levelxpgained { get; set; }
            public int levelxpremainder { get; set; }
            public int revives { get; set; }
        }

        public new class Match : Common.Match
        {
            public int rankxp { get; set; }
        }

        public string type { get; set; }
    }
}

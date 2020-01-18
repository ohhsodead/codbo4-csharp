namespace CODBO4.Models.Profile
{
    public class Blackout : Multiplayer
    {
        public new class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Platform { get; set; }
            public string Title { get; set; }
        }

        public class BlackoutExtra
        {
            public int Top5PlacementTeam { get; set; }
            public int Top10PlacementTeam { get; set; }
            public int Top15PlacementTeam { get; set; }
            public int Top5PlacementSolo { get; set; }
            public int Top25PlacementSolo { get; set; }
            public int VehicleEscapes { get; set; }
            public int VehicleScavengerAir { get; set; }
            public int VehicleScavengerLand { get; set; }
            public int VehicleScavengerWater { get; set; }
            public int VehiclesDestroyed { get; set; }
            public int VehicleUsedAll { get; set; }
            public int VehicleLockExits { get; set; }
            public int VehiclesSestroyedOccupied { get; set; }
            public int VehicleDamageOccupied { get; set; }
            public int KillsVehicleDriver { get; set; }
            public int VehicleDamage { get; set; }
            public int WinsWithoutKills { get; set; }
            public int MostKillsInAGame { get; set; }
            public int DistanceTraveledWingsuit { get; set; }
            public int DistanceTraveledWingsuitMiles { get; set; }
            public int DistanceTraveledVehicleLand { get; set; }
            public int DistanceTraveledVehicleLandMiles { get; set; }
            public int DistanceTraveledVehicleAir { get; set; }
            public int DistanceTraveledVehicleAirMiles { get; set; }
            public int DistanceTraveledVehicleWater { get; set; }
            public int DistanceTraveledVehicleWaterMiles { get; set; }
            public int ItemsPickedUp { get; set; }
            public int ItemsDropped { get; set; }
            public int KillsRevenge { get; set; }
        }

        public new class Stats : Multiplayer.StatsInfo
        {
            public BlackoutExtra BlackoutExtra { get; set; }
            public int LevelXpGained { get; set; }
            public int LevelXpRemainder { get; set; }
            public int Revives { get; set; }
        }

        public new class Match : Common.Match
        {
            public int RankXp { get; set; }
        }

        public string Type { get; set; }
    }
}

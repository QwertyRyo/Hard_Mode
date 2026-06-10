using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

/*
- possible spawn locations for qrf
2907.796 110.0468 -1444.781 - first spawn dir 2.5834 272.0554 1.2375
2843.651 106.4847 -1417.385
2868.581 107.8498 -1423.585

2332.59 53.8328 -730.5155
2356.578 56.0576 -731.1284
2372.19 57.3358 -723.3718 - second spawn dir 3.5814 171.9519 355.1928


*/

//add IsMobile = true if you want them to be mobile

namespace Hard_Mode
{
    public static class GT03_abrams_alley
    {
        public static List<SpawnEntry> Spawns() => new List<SpawnEntry>
        {

            //TEST REMOVE LATER T72M1 BREAKS MOD WITH PIL
            /*      
              new SpawnEntry
            {
                PrefabName = "T72M1",
                Position = new Vector3(-820.0128f, 71.0977f, -500.6957f),
                Rotation = Quaternion.Euler(0.3356f, 119.966f, 8.1891f),
                Allegiance = Faction.Red,
                DisplayName = "T-72M1 1 Modded"
            },*/
            new SpawnEntry
            {
                PrefabName = "T64B",
                Position = new Vector3(2332.59f, 53.8328f, -730.5155f),
                Rotation = Quaternion.Euler(3.5814f, 171.9519f, 355.1928f),
                Allegiance = Faction.Red,
                DisplayName = "T-64B 1 Modded",
                IsMobile = true,
                MobileDelay = 180f
            },

new SpawnEntry
            {
                PrefabName = "T64B",
                Position = new Vector3(2356.578f, 56.0576f, -731.1284f),
                Rotation = Quaternion.Euler(2.5834f, 272.0554f, 1.2375f),
                Allegiance = Faction.Red,
                DisplayName = "T-64B 2 Modded",
                IsMobile = true,
                MobileDelay = 185f
            },

new SpawnEntry
            {
                PrefabName = "T64B",
                Position = new Vector3(2372.19f, 57.3358f, -723.3718f),
                Rotation = Quaternion.Euler(2.5834f, 272.0554f, 1.2375f),
                Allegiance = Faction.Red,
                DisplayName = "T-64B 3 Modded",
                IsMobile = true,
                MobileDelay = 190f
            },

new SpawnEntry
            {
                PrefabName = "T64A81",
                Position = new Vector3(2907.796f, 110.0468f, -1444.781f),
                Rotation = Quaternion.Euler(2.5834f, 272.0554f, 1.2375f),
                Allegiance = Faction.Red,
                DisplayName = "T-64A81 1 Modded",
                IsMobile = true,
                MobileDelay = 75f
            },
            new SpawnEntry
            {
                PrefabName = "T64A81",
                Position = new Vector3(2843.651f, 106.4847f, -1417.385f),
                Rotation = Quaternion.Euler(2.5834f, 272.0554f, 1.2375f),
                Allegiance = Faction.Red,
                DisplayName = "T-64A81 2 Modded",
                IsMobile = true,
                MobileDelay = 85f
            },
            new SpawnEntry
            {
                PrefabName = "T64A81",
                Position = new Vector3(2868.581f, 107.8498f, -1423.585f),
                Rotation = Quaternion.Euler(2.5834f, 272.0554f, 1.2375f),
                Allegiance = Faction.Red,
                DisplayName = "T-64A81 3 Modded",
                IsMobile = true,
                MobileDelay = 90f
            },
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(2039.431f, 82.4362f, -1950.396f),
                Rotation = Quaternion.Euler(0f, 270f, 0f),
                Allegiance = Faction.Red,
                DisplayName = "T-80B 1 Modded",
            }
            ,
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(1586.989f, 37.2426f, -820.2175f),
                Rotation = Quaternion.Euler(359.6815f, 203.3798f, 359.7273f),
                Allegiance = Faction.Red,
                DisplayName = "T-80B 2 Modded"
            },
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(1559.244f, 36.9282f, -811.1731f),
                Rotation = Quaternion.Euler(358.7519f, 191.9604f, 0.0392f),
                Allegiance = Faction.Red,
                DisplayName = "T-80B 3 Modded"
            },
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(1442.101f, 54.0921f, -2247.204f),
                Rotation = Quaternion.Euler(0.0002f, 278.9434f, -0.0001f),
                Allegiance = Faction.Red,
                DisplayName = "T-80B 4 Modded"
            },
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(1442.854f, 57.3884f, -2219.696f),
                Rotation = Quaternion.Euler(0.0002f, 278.9434f, 9.8545f),
                Allegiance = Faction.Red,
                DisplayName = "T-80B 5 Modded"
            },
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(979.5067f, 81.6688f, -1582.236f),
                Rotation = Quaternion.Euler(5.7237f, 157.6201f, 0.7074f),
                Allegiance = Faction.Red,
                DisplayName = "T-80B 6 Modded"
            },
            new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(1928.377f, 51.0288f, -1121.505f),
                Rotation = Quaternion.Euler(354.9498f, 228.0831f, 355.9422f),
                Allegiance = Faction.Red,
                DisplayName = "BMP-2 1M"
            },
            new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(1941.994f, 51.4077f, -1135.152f),
                Rotation = Quaternion.Euler(356.4658f, 226.0959f, 359.8655f),
                Allegiance = Faction.Red,
                DisplayName = "BMP-2 2M"
            },
            new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(1887.6f, 47.7749f, -1104.829f),
                Rotation = Quaternion.Euler(0.4542f, 231.8899f, 353.8273f),
                Allegiance = Faction.Red,
                DisplayName = "BMP-2 3M"
            }
        };
    }
}

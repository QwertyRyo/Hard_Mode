using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;



namespace Hard_Mode
{
    public static class GT03_Native_Narrative
    {
        public static List<SpawnEntry> Spawns() => new List<SpawnEntry>
        {
            // BMP2 (mobile)
            new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(361.0704f, 71.769f, -872.898f),
                Rotation = Quaternion.Euler(358.9492f, 303.2581f, 353.0758f),
                Allegiance = Faction.Red,
                DisplayName = "BMP2 1 modded",
                IsMobile = true,
                MobileDelay = 1f
            },
            new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(340.4702f, 68.8581f, -795.9889f),
                Rotation = Quaternion.Euler(4.0184f, 322.8899f, 356.4481f),
                Allegiance = Faction.Red,
                DisplayName = "BMP2 2 modded",
                IsMobile = true,
                MobileDelay = 1f
            },
            new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(350.8745f, 65.0375f, -716.4872f),
                Rotation = Quaternion.Euler(358.8984f, 256.5652f, 0.5351f),
                Allegiance = Faction.Red,
                DisplayName = "BMP2 3 modded",
                IsMobile = true,
                MobileDelay = 1f
            },
            // T-80B
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(-54.8609f, 58.9886f, -88.4771f),
                Rotation = Quaternion.Euler(359.7977f, 206.0417f, 1.7039f),
                Allegiance = Faction.Red,
                DisplayName = "T80B 1 modded"
            },
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(-81.4427f, 59.3404f, -73.1453f),
                Rotation = Quaternion.Euler(0.1106f, 203.855f, 0.5538f),
                Allegiance = Faction.Red,
                DisplayName = "T80B 2 modded"
            },
            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(-108.3182f, 59.3164f, -56.5929f),
                Rotation = Quaternion.Euler(359.4356f, 217.1324f, 359.3103f),
                Allegiance = Faction.Red,
                DisplayName = "T80B 3 modded"
            },
            // T-64B81 (mobile)
            new SpawnEntry
            {
                PrefabName = "T64B81",
                Position = new Vector3(-890.0929f, 66.5168f, -72.1139f),
                Rotation = Quaternion.Euler(359.3495f, 118.2596f, 349.6341f),
                Allegiance = Faction.Red,
                DisplayName = "T64B81 1 modded",
                IsMobile = true,
                MobileDelay = 75f
            },
            new SpawnEntry
            {
                PrefabName = "T64B81",
                Position = new Vector3(-916.3257f, 64.2639f, -70.7257f),
                Rotation = Quaternion.Euler(6.7047f, 164.6782f, 353.844f),
                Allegiance = Faction.Red,
                DisplayName = "T64B81 2 modded",
                IsMobile = true,
                MobileDelay = 75f
            },
            new SpawnEntry
            {
                PrefabName = "T64B81",
                Position = new Vector3(-953.0626f, 59.2455f, -102.53f),
                Rotation = Quaternion.Euler(5.4181f, 227.3133f, 1.3368f),
                Allegiance = Faction.Red,
                DisplayName = "T64B81 3 modded",
                IsMobile = true,
                MobileDelay = 75f
            },
            // T62
            new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(-1533.573f, 84.5138f, -792.1396f),
                Rotation = Quaternion.Euler(357.4426f, 145.7047f, 0.4637f),
                Allegiance = Faction.Red,
                DisplayName = "T62 1 modded"
            },
            new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(-1558.125f, 84.3927f, -805.3282f),
                Rotation = Quaternion.Euler(357.4426f, 145.7047f, 0.4637f),
                Allegiance = Faction.Red,
                DisplayName = "T62 2 modded"
            },
            new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(-1637.58f, 86.5626f, -1039.556f),
                Rotation = Quaternion.Euler(7.8097f, 122.7131f, 2.0172f),
                Allegiance = Faction.Red,
                DisplayName = "T62 3 modded"
            },
            // STATIC_9K111
            new SpawnEntry
            {
                PrefabName = "STATIC_9K111",
                Position = new Vector3(-1551.318f, 86.2348f, -851.1439f),
                Rotation = Quaternion.Euler(357.4426f, 145.7047f, 0.4637f),
                Allegiance = Faction.Red,
                DisplayName = "STATIC_9K111 1 modded"
            },
            new SpawnEntry
            {
                PrefabName = "STATIC_9K111",
                Position = new Vector3(-1645.982f, 87.7615f, -1020.472f),
                Rotation = Quaternion.Euler(3.4375f, 135.2184f, 0.2108f),
                Allegiance = Faction.Red,
                DisplayName = "STATIC_9K111 2 modded"
            },
        };
    }
}

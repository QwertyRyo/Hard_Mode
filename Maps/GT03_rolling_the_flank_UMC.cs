using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

//1207.453 29.3617 388.6167 - 358.2837 174.4235 359.981
//1214.816 28.4707 411.1635
//1199.933 27.3523 443.1486

namespace Hard_Mode
{
    public static class GT03_rolling_the_flank_UMC
    {
        public static List<SpawnEntry> Spawns() => new List<SpawnEntry>
        {
            new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(1200.626f, 33.8719f, 1589.905f),
                Rotation = Quaternion.Euler(0.3667f, 144.7331f, 4.0118f),
                Allegiance = Faction.Red,
                DisplayName = "T-55A 1 Modded"
            },
            new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(1155.905f, 36.2585f, 1568.858f),
                Rotation = Quaternion.Euler(0.3667f, 144.7331f, 4.0118f),
                Allegiance = Faction.Red,
                DisplayName = "T-55A 2 Modded"
            },
            new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(1126.62f, 37.0697f, 1562.913f),
                Rotation = Quaternion.Euler(0.2407f, 161.0471f, 1.1921f),
                Allegiance = Faction.Red,
                DisplayName = "T-55A 3 Modded"
            },
                        new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(3641.8f, 89.5743f, 2015.851f),
                Rotation = Quaternion.Euler(0.2407f, 161.0471f, 1.1921f),
                Allegiance = Faction.Red,
                DisplayName = "T-55A 4 Modded",
                IsMobile = true,
                MobileDelay = 150f
            },
                        new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(3564.669f, 105.984f, 2122.998f),
                Rotation = Quaternion.Euler(0.2407f, 161.0471f, 1.1921f),
                Allegiance = Faction.Red,
                DisplayName = "T-55A 5 Modded",
                IsMobile = true,
                MobileDelay = 150f
            },
                        new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(3424.388f, 117.5088f, 2184.106f),
                Rotation = Quaternion.Euler(8.1341f, 184.5084f, 0.0587f),
                Allegiance = Faction.Red,
                DisplayName = "T-55A 6 Modded",
                IsMobile = true,
                MobileDelay = 150f
            },
                                    new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(1391.298f, 84.9829f, 2735.522f),
                Rotation = Quaternion.Euler(1.8555f, 294.8187f, 1.9975f),
                Allegiance = Faction.Red,
                DisplayName = "Bmp2 1m",
                IsMobile = true,
                MobileDelay = 90f
            },
                                    new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(1406.792f, 84.5577f, 2735.522f),
                Rotation = Quaternion.Euler(8.1341f, 184.5084f, 0.0587f),
                Allegiance = Faction.Red,
                DisplayName = "Bmp2 2m",
                IsMobile = true,
                MobileDelay = 100f
            },
                                    new SpawnEntry
            {
                PrefabName = "BMP2",
                Position = new Vector3(1429.437f, 83.6513f, 2735.593f),
                Rotation = Quaternion.Euler(8.1341f, 184.5084f, 0.0587f),
                Allegiance = Faction.Red,
                DisplayName = "bmp2 3m",
                IsMobile = true,
                MobileDelay = 105f
            },

            new SpawnEntry
            {
                PrefabName = "STATIC_9K111",
                Position = new Vector3(1174.907f, 40.11f, 1292.952f),
                Rotation = Quaternion.Euler(3.1929f, 134.1651f, 358.9799f),
                Allegiance = Faction.Red,
                DisplayName = "9k111 1m",
            },
            new SpawnEntry
            {
                PrefabName = "STATIC_SPG9_TRENCH",
                Position = new Vector3(1301.773f, 36.3189f, 1311.37f),
                Rotation = Quaternion.Euler(2.1374f, 141.1194f, 2.902f),
                Allegiance = Faction.Red,
                DisplayName = "spg9 1m",
            },
            new SpawnEntry
            {
                PrefabName = "STATIC_SPG9",
                Position = new Vector3(1515.455f, 19.5061f, 1384.379f),
                Rotation = Quaternion.Euler(358.2837f, 174.4235f, 359.981f),
                Allegiance = Faction.Red,
                DisplayName = "spg9 2m",
            },
            new SpawnEntry
            {
                PrefabName = "BMP1",
                Position = new Vector3(1561.001f, 20.4574f, 1559.018f),
                Rotation = Quaternion.Euler(357.1143f, 117.348f, 357.4764f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1 1m"
                
            },
            new SpawnEntry
            {
                PrefabName = "BMP1",
                Position = new Vector3(1681.898f, 21.6839f, 2009.459f),
                Rotation = Quaternion.Euler(0.3404f, 134.9271f, 359.3566f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1 2m"
            },
            new SpawnEntry
            {
                PrefabName = "BMP1",
                Position = new Vector3(1750.023f, 24.1471f, 2032.25f),
                Rotation = Quaternion.Euler(0.2981f, 137.9268f, 357.422f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1 3m"
            },
            new SpawnEntry
            {
                PrefabName = "BTR60PB",
                Position = new Vector3(2341.087f, 35.3437f, 1826.75f),
                Rotation = Quaternion.Euler(3.5791f, 186.141f, 358.7774f),
                Allegiance = Faction.Red,
                DisplayName = "btr60pb 1m"
            },
            
            new SpawnEntry
            {
                PrefabName = "STATIC_9K111",
                Position = new Vector3(2345.321f, 33.196f, 1784.445f),
                Rotation = Quaternion.Euler(3.1451f, 203.137f, 3.3449f),
                Allegiance = Faction.Red,
                DisplayName = "STATIC_9K111 1 modded"
            },

            new SpawnEntry
            {
                PrefabName = "BMP1P",
                Position = new Vector3(3002.151f, 56.4781f, 1180.95f),
                Rotation = Quaternion.Euler(0.0372f, 350.0106f, 358.5063f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1p 1m",
                                IsMobile = true,
                MobileDelay = 80f


            },
                        new SpawnEntry
            {
                PrefabName = "BMP1P",
                Position = new Vector3(2980.319f, 57.322f, 1176.812f),
                Rotation = Quaternion.Euler(5.8198f, 358.4138f, 358.182f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1p 2m",
                                IsMobile = true,
                MobileDelay = 80f

            },
                        new SpawnEntry
            {
                PrefabName = "BMP1P",
                Position = new Vector3(2887.826f, 57.4922f, 1239.182f),
                Rotation = Quaternion.Euler(5.8198f, 358.4138f, 358.182f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1p 3m",
                                IsMobile = true,
                MobileDelay = 80f

            }
        };
    }
}

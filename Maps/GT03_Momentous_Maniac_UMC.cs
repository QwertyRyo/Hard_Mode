using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

//1207.453 29.3617 388.6167 - 358.2837 174.4235 359.981
//1214.816 28.4707 411.1635
//1199.933 27.3523 443.1486

namespace Hard_Mode
{
    public static class GT03_Momentous_Maniac_UMC
    {
        public static List<SpawnEntry> Spawns() => new List<SpawnEntry>
        {
            new SpawnEntry
            {
                PrefabName = "T72M1",
                Position = new Vector3(3421.257f, 56.4234f, 65.4855f),
                Rotation = Quaternion.Euler(2.0089f, 221.4633f, 3.0592f),
                Allegiance = Faction.Red,
                DisplayName = "T72m1 1m",
                IsMobile = true,
                MobileDelay = 240f
            },
            new SpawnEntry
            {
                PrefabName = "T72M1",
                Position = new Vector3(3430.257f, 56.4234f, 69.4855f),
                Rotation = Quaternion.Euler(359.5134f, 116.482f, 359.4353f),
                Allegiance = Faction.Red,
                DisplayName = "T72m1 2m",
                IsMobile = true,
                MobileDelay = 260f
            },
            new SpawnEntry
            {
                PrefabName = "T72M1",
                Position = new Vector3(3529.394f, 51.5605f, -36.5307f),
                Rotation = Quaternion.Euler(0.3667f, 144.7331f, 4.0118f),
                Allegiance = Faction.Red,
                DisplayName = "T-72m1 3m",
                IsMobile = true,
                MobileDelay = 250f
            },
            new SpawnEntry
            {
                PrefabName = "BTR60PB",
                Position = new Vector3(2053.345f, 54.3406f, -727.1251f),
                Rotation = Quaternion.Euler(355.5145f, 163.0987f, 358.382f),
                Allegiance = Faction.Red,
                DisplayName = "btr60 1m"
            },
                        new SpawnEntry
            {
                PrefabName = "STATIC_9K111",
                Position = new Vector3(2035.061f, 53.5439f, -729.6592f),
                Rotation = Quaternion.Euler(356.6351f, 152.7546f, 358.707f),
                Allegiance = Faction.Red,
                DisplayName = "9k111 1m",
                
            },
                        new SpawnEntry
            {
                PrefabName = "BTR60PB",
                Position = new Vector3(2131.893f, 56.792f, -744.1356f),
                Rotation = Quaternion.Euler(359.4364f, 193.0421f, 2.3898f),
                Allegiance = Faction.Red,
                DisplayName = "btr60 2m",
                
            },
                        new SpawnEntry
            {
                PrefabName = "BMP1",
                Position = new Vector3(1396.073f, 39.4238f, -639.0127f),
                Rotation = Quaternion.Euler(1.4366f, 103.8522f, 359.6438f),
                Allegiance = Faction.Red,
                DisplayName = "BMP1 1m",
               
            },
                                    new SpawnEntry
            {
                PrefabName = "BMP1",
                Position = new Vector3(1444.911f, 39.5996f, -810.8534f),
                Rotation = Quaternion.Euler(0.3594f, 154.4102f, 1.4296f),
                Allegiance = Faction.Red,
                DisplayName = "Bmp1 2m",

            },
                                    new SpawnEntry
            {
                PrefabName = "BMP1",
                Position = new Vector3(1556.455f, 37.1623f, -817.2308f),
                Rotation = Quaternion.Euler(358.4441f, 148.0999f, 1.7668f),
                Allegiance = Faction.Red,
                DisplayName = "Bmp1 3m",
            },
                                                new SpawnEntry
            {
                PrefabName = "STATIC_SPG9",
                Position = new Vector3(2654.22f, 71.4052f, -947.2917f),
                Rotation = Quaternion.Euler(2.2412f, 232.4563f, 357.2803f),
                Allegiance = Faction.Red,
                DisplayName = "spg9 1m",
            },
                                                            new SpawnEntry
            {
                PrefabName = "STATIC_SPG9",
                Position = new Vector3(2317.31f, 59.5325f, -856.7718f),
                Rotation = Quaternion.Euler(358.6856f, 184.2706f, 359.4358f),
                Allegiance = Faction.Red,
                DisplayName = "spg9 2m",
            },
                   new SpawnEntry
            {
                PrefabName = "STATIC_SPG9",
                Position = new Vector3(2030.64f, 44.2425f, -948.0392f),
                Rotation = Quaternion.Euler(0.785f, 175.7241f, 359.7835f),
                Allegiance = Faction.Red,
                DisplayName = "spg9 3m",
            },


                                    new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(810.1666f, 93.1484f, -1213.364f),
                Rotation = Quaternion.Euler(6.5417f, 84.7059f, 359.9877f),
                Allegiance = Faction.Red,
                DisplayName = "t55a 1m",
                IsMobile = true,
                MobileDelay = 45f
            },

                         new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(798.6627f, 94.6086f, -1222.823f),
                Rotation = Quaternion.Euler(7.0884f, 49.0582f, 0.4184f),
                Allegiance = Faction.Red,
                DisplayName = "t55a 2m",
                IsMobile = true,
                MobileDelay = 55f
            },
                                                new SpawnEntry
            {
                PrefabName = "T55A",
                Position = new Vector3(777.6943f, 97.1393f, -1241.59f),
                Rotation = Quaternion.Euler(5.123f, 50.3976f, 355.4881f),
                Allegiance = Faction.Red,
                DisplayName = "t55a 3m",
                IsMobile = true,
                MobileDelay = 65f
            },

            new SpawnEntry
            {
                PrefabName = "BMP1P",
                Position = new Vector3(748.7177f, 100.2351f, -1266.374f),
                Rotation = Quaternion.Euler(3.708f, 44.0021f, 354.2748f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1p 1m",
                                IsMobile = true,
                MobileDelay = 90f


            },
                        new SpawnEntry
            {
                PrefabName = "BMP1P",
                Position = new Vector3(741.0982f, 100.6492f, -1274.583f),
                Rotation = Quaternion.Euler(0.4635f, 43.7677f, 359.9705f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1p 2m",
                                IsMobile = true,
                MobileDelay = 100f

            },
                        new SpawnEntry
            {
                PrefabName = "BMP1P",
                Position = new Vector3(730.8933f, 101.5679f, -1285.264f),
                Rotation = Quaternion.Euler(4.3721f, 44.1834f, 357.9875f),
                Allegiance = Faction.Red,
                DisplayName = "bmp1p 3m",
                                IsMobile = true,
                MobileDelay = 110f

            },
                                    new SpawnEntry
            {
                PrefabName = "BTR60PB",
                Position = new Vector3(1578.197f, 34.6646f, -749.9519f),
                Rotation = Quaternion.Euler(0.6814f, 88.3166f, 1.1515f),
                Allegiance = Faction.Red,
                DisplayName = "btr60pb 3m",
                                

            },
        };
    }
}

using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode
{
    public static class GT03_Longer_Road_V2
    {
        public static List<SpawnEntry> Spawns() => new List<SpawnEntry>
        {
                       new SpawnEntry
            {
                PrefabName = "BMP1_SA",
                Position = new Vector3(1546.262f, 33.9994f, -724.1384f),
                Rotation = Quaternion.Euler(2.0444f, 0.5236f, 359.2838f),
                
                Allegiance = Faction.Red,
                DisplayName = "bmp1 1 Modded"
            },

                                   new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(            731.0938f, 39.0427f, -345.1816f),
                Rotation = Quaternion.Euler(1.0737f, 78.7237f, 0.54f),
                
                Allegiance = Faction.Red,
                DisplayName = "t62 1 Modded",
                IsMobile = true,
                MobileDelay = 60f
            },
                                               new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(            -221.6774f, 56.6162f, -42.3237f),
                Rotation = Quaternion.Euler(1.0737f, 78.7237f, 0.54f),
                
                Allegiance = Faction.Red,
                DisplayName = "t62 2 Modded",
                IsMobile = true,
                MobileDelay = 60f
            },
                                               new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(            43.5359f, 65.1012f, -713.5657f),
                Rotation = Quaternion.Euler(356.9766f, 127.0541f, 2.3531f),
                
                Allegiance = Faction.Red,
                DisplayName = "t62 3 Modded",
                IsMobile = true,
                MobileDelay = 60f
            },

                                                           new SpawnEntry
            {
                PrefabName = "BMP1_SA",
                Position = new Vector3(            -410.9733f, 99.1293f, -1205.909f),
                Rotation = Quaternion.Euler(3.8819f, 12.8624f, 3.6529f),
                
                Allegiance = Faction.Red,
                DisplayName = "bmp1 2 Modded",

            },

            
                                                           new SpawnEntry
            {
                PrefabName = "BMP1_SA",
                Position = new Vector3(            -348.0143f, 99.5376f, -1190.618f),
                Rotation = Quaternion.Euler(1.4336f, 73.0738f, 4.9722f),
                
                Allegiance = Faction.Red,
                DisplayName = "bmp1 3 Modded",

            },
    new SpawnEntry
            {
                PrefabName = "STATIC_SPG9",
                Position = new Vector3(            -1355.402f, 84.4086f, -790.8589f),
                Rotation = Quaternion.Euler(1.0278f, 79.1672f, 2.4102f),
                
                Allegiance = Faction.Red,
                DisplayName = "SPG9 1 Modded",

            },

            //Pursuit team 1


new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(                        2469.265f, 88.3125f, -3677.63f),
                Rotation = Quaternion.Euler(356.196f, 28.6657f, 359.0735f),
                
                Allegiance = Faction.Red,
                DisplayName = "t62 4 Modded",
                IsMobile = true,
                MobileDelay = 420f
            },

            new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(                        2531.518f, 92.4569f, -3642.662f),
                Rotation = Quaternion.Euler(357.3508f, 20.9741f, 3.0674f),
                
                Allegiance = Faction.Red,
                DisplayName = "t62 5 Modded",
                IsMobile = true,
                MobileDelay = 440f
            },

                        new SpawnEntry
            {
                PrefabName = "T62",
                Position = new Vector3(                        2448.81f, 79.963f, -3798.296f),
                Rotation = Quaternion.Euler(359.6128f, 279.3977f, 5.3518f),
                
                Allegiance = Faction.Red,
                DisplayName = "t62 5 Modded",
                IsMobile = true,
                MobileDelay = 460f
            },

        //team 2
        

new SpawnEntry
            {
                PrefabName = "T64A",
                Position = new Vector3(                        777.1586f, 109.654f, -3209.705f),
                Rotation = Quaternion.Euler(3.7273f, 340.3127f, 4.8728f),
                
                Allegiance = Faction.Red,
                DisplayName = "t64a 1 Modded",
                IsMobile = true,
                MobileDelay = 600f
            },

            new SpawnEntry
            {
                PrefabName = "T64A",
                Position = new Vector3(                        681.6788f, 102.498f, -3235.941f),
                Rotation = Quaternion.Euler(1.8164f, 351.4805f, 8.453f),
                
                Allegiance = Faction.Red,
                DisplayName = "t64a 2 Modded",
                IsMobile = true,
                MobileDelay = 620f
            },

                        new SpawnEntry
            {
                PrefabName = "T64A",
                Position = new Vector3(                        552.5037f, 80.2259f, -3208.299f),
                Rotation = Quaternion.Euler(5.2884f, 339.9305f, 16.1165f),
                
                Allegiance = Faction.Red,
                DisplayName = "t64a 3 Modded",
                IsMobile = true,
                MobileDelay = 630f
            },

            //team 3
            
new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                        -1491.345f, 171.3992f, -2814.935f),
                Rotation = Quaternion.Euler(4.7137f, 59.4903f, 359.5444f),
                
                Allegiance = Faction.Red,
                DisplayName = "T80B 1 Modded",
                IsMobile = true,
                MobileDelay = 720f
            },

            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                        -1983.588f, 190.4315f, -2931.034f),
                Rotation = Quaternion.Euler(3.1455f, 300.9969f, 357.0538f),
                
                Allegiance = Faction.Red,
                DisplayName = "T80B 2 Modded",
                IsMobile = true,
                MobileDelay = 720f
            },

                        new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                        -2342.52f, 187.0835f, -2667.359f),
                Rotation = Quaternion.Euler(0.2286f, 301.3373f, 354.6017f),
                
                Allegiance = Faction.Red,
                DisplayName = "t80b 3 Modded",
                IsMobile = true,
                MobileDelay = 720f
            },

            //team 4

new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                    -2793.866f, 244.8482f, -3266.999f),
                Rotation = Quaternion.Euler(2.5264f, 40.6314f, 0.3003f),
                
                Allegiance = Faction.Red,
                DisplayName = "T80B 4 Modded",
                IsMobile = true,
                MobileDelay = 780f
            },

            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                       -2329.585f, 219.243f, -3447.318f),
                Rotation = Quaternion.Euler(357.7002f, 269.1134f, 4.1966f),
                
                Allegiance = Faction.Red,
                DisplayName = "T80B 5 Modded",
                IsMobile = true,
                MobileDelay = 780f
            },

                        new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                        -3191.23f, 241.6527f, -3330.606f),
                Rotation = Quaternion.Euler(0.7498f, 20.106f, 2.3337f),
                Allegiance = Faction.Red,
                DisplayName = "t80b 6 Modded",
                IsMobile = true,
                MobileDelay = 780f
            },

            //team 5

new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                    -1380.407f, 183.36f, 1428.517f),
                Rotation = Quaternion.Euler(1.4449f, 260.3009f, 0.4456f),
                
                Allegiance = Faction.Red,
                DisplayName = "T80B 7 Modded",
                IsMobile = true,
                MobileDelay = 880f
            },

            new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                       -1745.781f, 151.1145f, 1283.23f),
                Rotation = Quaternion.Euler(359.9695f, 158.8173f, 353.4525f),
                
                Allegiance = Faction.Red,
                DisplayName = "T80B 5 Modded",
                IsMobile = true,
                MobileDelay = 880f
            },

                        new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(                        -1836.437f, 124.7649f, 1001.202f),
                Rotation = Quaternion.Euler(6.6831f, 231.2092f, 357.6663f),
                Allegiance = Faction.Red,
                DisplayName = "t80b 6 Modded",
                IsMobile = true,
                MobileDelay = 880f
            },



        };
    }
}

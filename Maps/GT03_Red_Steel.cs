using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;




namespace Hard_Mode
{
    public static class GT03_Red_Steel
    {
        public static List<SpawnEntry> Spawns() => new List<SpawnEntry>
        {

                        //static risep

                        new SpawnEntry
            {
                PrefabName = "M60A1RISEP77",
                Position = new Vector3(2192.515f, 64.0909f, 948.8812f),
                Rotation = Quaternion.Euler(0.9296f, 295.0555f, 356.3766f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A1RISEP77 modded 3",

            },
            new SpawnEntry
            {
                PrefabName = "M60A1RISEP77",
                Position = new Vector3(2006.856f, 51.198f, 791.0704f),
                Rotation = Quaternion.Euler(359.7024f, 278.665f, 0.8737f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A1RISEP77 modded 4",

            },

                        new SpawnEntry
            {
                PrefabName = "M60A1RISEP77",
                Position = new Vector3(1351.689f, 20.1591f, 1800.164f),
                Rotation = Quaternion.Euler(357.8857f, 263.9698f, 1.074f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A1RISEP77 modded 5",

            },


                        new SpawnEntry
            {
                PrefabName = "M1",
                Position = new Vector3(2091.569f, 34.8865f, 1808.214f),
                Rotation = Quaternion.Euler(4.5822f, 270.1992f, 3.235f),
                Allegiance = Faction.Blue,
                DisplayName = "M1 1 modded"
            },
            new SpawnEntry
            {
                PrefabName = "M1",
                Position = new Vector3(2081.488f, 36.7519f, 1835.452f),
                Rotation = Quaternion.Euler(4.5822f, 270.1992f, 3.235f),
                Allegiance = Faction.Blue,
                DisplayName = "M1 2 modded"
            },
                        new SpawnEntry
            {
                PrefabName = "M1",
                Position = new Vector3(            3390.599f, 81.9303f, 1176.209f),
                Rotation = Quaternion.Euler(357.1997f, 290.5291f, 358.4641f),
                Allegiance = Faction.Blue,
                DisplayName = "M1 3 modded"
            },
                        new SpawnEntry
            {
                PrefabName = "M1",
                Position = new Vector3(3388.552f, 81.3956f, 1154.465f),
                Rotation = Quaternion.Euler(356.2521f, 289.9987f, 0.1284f),
                Allegiance = Faction.Blue,
                DisplayName = "M1 4 modded"
            },



            new SpawnEntry
            {
                PrefabName = "M113",
                Position = new Vector3(-558.1257f, 139.2697f, 2639.333f),
                Rotation = Quaternion.Euler(359.8752f, 227.1584f, -0.0018f),
                Allegiance = Faction.Blue,
                DisplayName = "m113 1 modded",
                IsMobile = true,
                MobileDelay = 1f
            },
                        new SpawnEntry
            {
                PrefabName = "STATIC_TOW",
                Position = new Vector3(-489.759f, 121.5155f, 2145.79f),
                Rotation = Quaternion.Euler(355.5914f, 280.6098f, 357.5567f),
                Allegiance = Faction.Blue,
                DisplayName = "tow 1 modded",
            },

                                    new SpawnEntry
            {
                PrefabName = "STATIC_TOW",
                Position = new Vector3(-604.5432f, 132.677f, 2033.984f),
                Rotation = Quaternion.Euler(1.4234f, 348.5427f, 352.971f),
                Allegiance = Faction.Blue,
                DisplayName = "tow 2 modded",
            },
            new SpawnEntry
            {
                PrefabName = "STATIC_TOW",
                Position = new Vector3(            1544.65f, 20.4542f, 1324.03f),
                Rotation = Quaternion.Euler(0.8307f, 340.8623f, 0.7819f),
                Allegiance = Faction.Blue,
                DisplayName = "tow 3 modded",
            },
            new SpawnEntry
            {
                PrefabName = "STATIC_TOW",
                Position = new Vector3(1789.73f, 30.7308f, 1525.758f),
                Rotation = Quaternion.Euler(2.1989f, 303.0813f, 358.1893f),
                Allegiance = Faction.Blue,
                DisplayName = "tow 4 modded",
            },


            new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(-404.7998f, 110.6994f, 2209.163f),
                Rotation = Quaternion.Euler(0.5325f, 291.7017f, 359.3226f),
                Allegiance = Faction.Blue,
                DisplayName = "m2 1 modded",
            },
            new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(-747.9953f, 144.3499f, 2144.392f),
                Rotation = Quaternion.Euler(3.7729f, 3.4279f, 350.5393f),
                Allegiance = Faction.Blue,
                DisplayName = "m2 2 modded",
            },
                        new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(383.5068f, 74.6031f, 1583.644f),
                Rotation = Quaternion.Euler(358.8722f, 120.8494f, 0.2231f),
                Allegiance = Faction.Blue,
                DisplayName = "m2 3 modded",
            },
                        new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(882.7095f, 46.142f, 1342.761f),
                Rotation = Quaternion.Euler(356.2057f, 324.1671f, 0.2561f),
                Allegiance = Faction.Blue,
                DisplayName = "m2 4 modded",
            },

                                    new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(1495.235f, 21.1226f, 1265.797f),
                Rotation = Quaternion.Euler(2.68f, 338.3917f, 0.1327f),
                Allegiance = Faction.Blue,
                DisplayName = "M2 Bradley modded 5"
            },

                                    new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(1489.624f, 20.8869f, 1317.493f),
                Rotation = Quaternion.Euler(0.8895f, 293.5813f, 359.4731f),
                Allegiance = Faction.Blue,
                DisplayName = "M2 Bradley modded 6"
            },




            //first wave
            new SpawnEntry
            {
                PrefabName = "M60A3TTS",
                Position = new Vector3(-381.2915f, 121.0032f, 2036.348f),
                Rotation = Quaternion.Euler(358.348f, 268.5575f, 358.6966f),
                Allegiance = Faction.Blue,
                DisplayName = "a3tts 1 modded",
                IsMobile = true,
                MobileDelay = 10f
            },

                        new SpawnEntry
            {
                PrefabName = "M60A3TTS",
                Position = new Vector3(-431.4513f, 122.4171f, 2041.448f),
                Rotation = Quaternion.Euler(359.899f, 296.3955f, 355.9671f),
                Allegiance = Faction.Blue,
                DisplayName = "a3tts 2 modded",
                                IsMobile = true,
                MobileDelay = 1f

            },

            //2nd

            new SpawnEntry
            {
                PrefabName = "M60A3",
                Position = new Vector3(2949.086f, 69.8291f, 2100.22f),
                Rotation = Quaternion.Euler(10.1306f, 240.5066f, 5.6681f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A3 1 modded",
                IsMobile = true,
                MobileDelay = 30f
            },
            new SpawnEntry
            {
                PrefabName = "M60A3",
                Position = new Vector3(2939.472f, 80.9195f, 2184.822f),
                Rotation = Quaternion.Euler(3.9684f, 220.4742f, 359.0484f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A3 2 modded",
                IsMobile = true,
                MobileDelay = 40f
            },

            //3rd
            new SpawnEntry
            {
                PrefabName = "M60A3",
                Position = new Vector3(3016.61f, 87.1789f, 2238.984f),
                Rotation = Quaternion.Euler(4.9799f, 231.3912f, 0.1256f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A3 3 modded",
                IsMobile = true,
                MobileDelay = 120f
            },
            new SpawnEntry
            {
                PrefabName = "M60A3",
                Position = new Vector3(3058.937f, 81.8871f, 2209.399f),
                Rotation = Quaternion.Euler(5.2434f, 206.1564f, 7.5278f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A3 4 modded",
                IsMobile = true,
                MobileDelay = 130f
            },

                        new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(830.1946f, 13.3174f, 2677.554f),
                Rotation = Quaternion.Euler(1.1279f, 301.266f, 2.0776f),
                Allegiance = Faction.Blue,
                DisplayName = "M2BRADLEY modded 1",
                IsMobile = true,
                MobileDelay = 80f
            },
            new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(878.1855f, 13.9952f, 2644.256f),
                Rotation = Quaternion.Euler(0.5155f, 38.6991f, 0.8764f),
                Allegiance = Faction.Blue,
                DisplayName = "M2BRADLEY modded 2",
                IsMobile = true,
                MobileDelay = 100f
            },
        };
    }
}

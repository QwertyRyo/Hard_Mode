using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;




namespace Hard_Mode
{
    public static class GT03_gunnery_duel
    {
        public static List<SpawnEntry> Spawns() => new List<SpawnEntry>
        {
            new SpawnEntry
            {
                PrefabName = "M60A1RISEP77",
                Position = new Vector3(2698.883f, 71.886f, 337.1955f),
                Rotation = Quaternion.Euler(1.1279f, 301.266f, 2.0776f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A1RISEP77 modded 1",
                IsMobile = true,
                MobileDelay = 60f
            },
            new SpawnEntry
            {
                PrefabName = "M60A1RISEP77",
                Position = new Vector3(2658.973f, 70.308f, 319.4669f),
                Rotation = Quaternion.Euler(358.2438f, 45.6876f, 357.2197f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A1RISEP77 modded 2",
                IsMobile = true,
                MobileDelay = 70f
            },
            new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(1826.964f, 56.7487f, 664.0788f),
                Rotation = Quaternion.Euler(4.4814f, 319.6179f, 0.7306f),
                Allegiance = Faction.Blue,
                DisplayName = "M2 Bradley modded 1"
            },
            new SpawnEntry
            {
                PrefabName = "M2BRADLEY",
                Position = new Vector3(1851.589f, 57.494f, 673.0618f),
                Rotation = Quaternion.Euler(4.4814f, 319.6179f, 0.7306f),
                Allegiance = Faction.Blue,
                DisplayName = "M2 Bradley modded 2"
            },



            // STATIC_TOW
            new SpawnEntry
            {
                PrefabName = "STATIC_TOW",
                Position = new Vector3(1421.623f, 28.3211f, 1287.737f),
                Rotation = Quaternion.Euler(353.3597f, 325.8318f, 357.1405f),
                Allegiance = Faction.Blue,
                DisplayName = "STATIC_TOW modded 1"
            },
            new SpawnEntry
            {
                PrefabName = "STATIC_TOW",
                Position = new Vector3(1459.077f, 21.2225f, 1355.646f),
                Rotation = Quaternion.Euler(0.8883f, 325.425f, 352.9652f),
                Allegiance = Faction.Blue,
                DisplayName = "STATIC_TOW modded 2"
            },
            new SpawnEntry
            {
                PrefabName = "STATIC_TOW",
                Position = new Vector3(2101.508f, 39.2387f, 1928.109f),
                Rotation = Quaternion.Euler(358.6686f, 259.8372f, 357.6032f),
                Allegiance = Faction.Blue,
                DisplayName = "STATIC_TOW 3 modded"
            },

           

            // M1
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
            


            // m60a3 (mobile)
            new SpawnEntry
            {
                PrefabName = "M60A3",
                Position = new Vector3(2949.086f, 69.8291f, 2100.22f),
                Rotation = Quaternion.Euler(10.1306f, 240.5066f, 5.6681f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A3 1 modded",
                IsMobile = true,
                MobileDelay = 120f
            },
            new SpawnEntry
            {
                PrefabName = "M60A3",
                Position = new Vector3(2939.472f, 80.9195f, 2184.822f),
                Rotation = Quaternion.Euler(3.9684f, 220.4742f, 359.0484f),
                Allegiance = Faction.Blue,
                DisplayName = "M60A3 2 modded",
                IsMobile = true,
                MobileDelay = 120f
            },
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
                MobileDelay = 120f
            },
        };
    }
}

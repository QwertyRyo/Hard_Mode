using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_cheap_tricks {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      // M60A1RISEP77

      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(2698.883f, 71.886f, 337.1955f),
                       Rotation = Quaternion.Euler(1.1279f, 301.266f, 2.0776f),
                       Allegiance = Faction.Red, DisplayName = "BMP1P modded 1",
                       IsMobile = true, MobileDelay = 60f },
      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(2658.973f, 70.308f, 319.4669f),
                       Rotation = Quaternion.Euler(358.2438f, 45.6876f,
                                                   357.2197f),
                       Allegiance = Faction.Red, DisplayName = "BMP1P modded 2",
                       IsMobile = true, MobileDelay = 75f },
      new SpawnEntry { PrefabName = "BMP1",
                       Position = new Vector3(1826.964f, 56.7487f, 664.0788f),
                       Rotation = Quaternion.Euler(4.4814f, 319.6179f, 0.7306f),
                       Allegiance = Faction.Red,
                       DisplayName = "bmp1 modded 1" },
      new SpawnEntry { PrefabName = "BMP1",
                       Position = new Vector3(1851.589f, 57.494f, 673.0618f),
                       Rotation = Quaternion.Euler(4.4814f, 319.6179f, 0.7306f),
                       Allegiance = Faction.Red,
                       DisplayName = "bmp1 modded 2" },
      new SpawnEntry {
        PrefabName = "BMP1",
        Position = new Vector3(1292.931f, 22.1175f, 1866.705f),
        Rotation = Quaternion.Euler(358.9122f, 280.7318f, 359.0114f),
        Allegiance = Faction.Red, DisplayName = "bmp1 modded 3"
      },
      // STATIC_TOW
      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(1421.623f, 28.3211f, 1287.737f),
        Rotation = Quaternion.Euler(353.3597f, 325.8318f, 357.1405f),
        Allegiance = Faction.Red, DisplayName = "STATIC_9K111 modded 1"
      },
      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(1459.077f, 21.2225f, 1355.646f),
        Rotation = Quaternion.Euler(0.8883f, 325.425f, 352.9652f),
        Allegiance = Faction.Red, DisplayName = "STATIC_9K111 modded 2"
      },
      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(2101.508f, 39.2387f, 1928.109f),
        Rotation = Quaternion.Euler(358.6686f, 259.8372f, 357.6032f),
        Allegiance = Faction.Red, DisplayName = "SPG9 1 modded"
      },
      // M1
      new SpawnEntry { PrefabName = "T72M1",
                       Position = new Vector3(2091.569f, 34.8865f, 1808.214f),
                       Rotation = Quaternion.Euler(4.5822f, 270.1992f, 3.235f),
                       Allegiance = Faction.Red,
                       DisplayName = "t72m1 1 modded" },
      new SpawnEntry { PrefabName = "T72m1",
                       Position = new Vector3(2081.488f, 36.7519f, 1835.452f),
                       Rotation = Quaternion.Euler(4.5822f, 270.1992f, 3.235f),
                       Allegiance = Faction.Red,
                       DisplayName = "t72m1 2 modded" },
      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(2949.086f, 69.8291f, 2100.22f),
                       Rotation = Quaternion.Euler(10.1306f, 240.5066f,
                                                   5.6681f),
                       Allegiance = Faction.Red, DisplayName = "t55a 1 modded",
                       IsMobile = true, MobileDelay = 115f },
      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(2939.472f, 80.9195f, 2184.822f),
                       Rotation = Quaternion.Euler(3.9684f, 220.4742f,
                                                   359.0484f),
                       Allegiance = Faction.Red, DisplayName = "t55a 2 modded",
                       IsMobile = true, MobileDelay = 120f },
      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(3016.61f, 87.1789f, 2238.984f),
                       Rotation = Quaternion.Euler(4.9799f, 231.3912f, 0.1256f),
                       Allegiance = Faction.Red, DisplayName = "t55a 3 modded",
                       IsMobile = true, MobileDelay = 125f },

      new SpawnEntry { PrefabName = "BTR60PB",
                       Position = new Vector3(1047.797f, 43.0075f, 1310.897f),
                       Rotation = Quaternion.Euler(355.1247f, 3.0961f,
                                                   358.887f),
                       Allegiance = Faction.Red, DisplayName = "btr60pb 2m",
                       IsMobile = true, MobileDelay = 10f },
      new SpawnEntry { PrefabName = "BTR60PB",
                       Position = new Vector3(934.1169f, 43.7296f, 1304.663f),
                       Rotation = Quaternion.Euler(359.7846f, 2.4179f, 0.6017f),
                       Allegiance = Faction.Red, DisplayName = "btr60pb 1m",
                       IsMobile = true, MobileDelay = 10f },

      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(1431.125f, 28.1247f, 1302.869f),
        Rotation = Quaternion.Euler(357.512f, 332.4255f, 356.7021f),
        Allegiance = Faction.Red,
        DisplayName = "spg 2m",

      },
      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(1484.893f, 20.4445f, 1352.654f),
        Rotation = Quaternion.Euler(0.8776f, 354.93f, 358.9893f),
        Allegiance = Faction.Red,
        DisplayName = "spg 3m",

      },

    };
  }
}

using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_ruined_regiment {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      new SpawnEntry { PrefabName = "BMP2_SA",
                       Position = new Vector3(-2132.151f, 159.0264f, 1783.687f),
                       Rotation = Quaternion.Euler(359.0373f, 123.2871f,
                                                   359.3481f),
                       Allegiance = Faction.Red, DisplayName = "bmp2 1 modded",
                       IsMobile = true, MobileDelay = 200f },
      new SpawnEntry { PrefabName = "BMP2_SA",
                       Position = new Vector3(-2143.813f, 158.8733f, 1795.364f),
                       Rotation = Quaternion.Euler(359.0373f, 123.2871f,
                                                   359.3481f),
                       Allegiance = Faction.Red, DisplayName = "bmp2 2 modded",
                       IsMobile = true, MobileDelay = 230f },
      new SpawnEntry { PrefabName = "T62",
                       Position = new Vector3(-1984.75f, 132.7079f, 1229.649f),
                       Rotation = Quaternion.Euler(355.2948f, 5.0317f, 1.5671f),
                       Allegiance = Faction.Red, DisplayName = "t62 1 modded",
                       IsMobile = true, MobileDelay = 150f },
      new SpawnEntry { PrefabName = "BTR70",
                       Position = new Vector3(-1987.002f, 135.7723f, 1264.106f),
                       Rotation = Quaternion.Euler(354.7981f, 14.9211f,
                                                   0.9706f),
                       Allegiance = Faction.Red, DisplayName = "btr70 1 modded",
                       IsMobile = true, MobileDelay = 145f },
      new SpawnEntry { PrefabName = "BTR70",
                       Position = new Vector3(-1968.637f, 140.9113f, 1311.727f),
                       Rotation = Quaternion.Euler(354.8962f, 41.254f,
                                                   359.0307f),
                       Allegiance = Faction.Red, DisplayName = "btr70 2 modded",
                       IsMobile = true, MobileDelay = 140f },

      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(-1747.443f, 152.0495f, 1298.849f),
        Rotation = Quaternion.Euler(0.8834f, 137.2079f, 355.2931f),
        Allegiance = Faction.Red,
        DisplayName = "spg9 1m",
      },
      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(-1390.219f, 180.6211f, 1886.819f),
        Rotation = Quaternion.Euler(4.4634f, 68.1454f, 359.0157f),
        Allegiance = Faction.Red,
        DisplayName = "spg9 2m",
      },

      new SpawnEntry {
        PrefabName = "BMP1_SA",
        Position = new Vector3(-1291.389f, 177.0105f, 2006.558f),
        Rotation = Quaternion.Euler(1.6629f, 138.9128f, 0.9299f),
        Allegiance = Faction.Red,
        DisplayName = "bmp1 1m",
      },

      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(-1376.181f, 186.5598f, 1546.239f),
        Rotation = Quaternion.Euler(359.7256f, 140.3342f, 358.7624f),
        Allegiance = Faction.Red,
        DisplayName = "9k111 1m",
      },

      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(-1021.524f, 169.7525f, 1990.067f),
        Rotation = Quaternion.Euler(3.2501f, 189.9303f, 1.1955f),
        Allegiance = Faction.Red,
        DisplayName = "9k111 2m",
      },

    };
  }
}

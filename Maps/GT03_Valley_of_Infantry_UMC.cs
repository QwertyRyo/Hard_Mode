using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_Valley_of_Infantry_UMC {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {

      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(2714.79f, 86.1995f, 1041.136f),
        Rotation = Quaternion.Euler(6.6722f, 87.2733f, 11.9054f),
        Allegiance = Faction.Red,
        DisplayName = "SPG9 1m",

      },

      new SpawnEntry {
        PrefabName = "BMP1",
        Position = new Vector3(2602.312f, 71.0605f, 1108.638f),
        Rotation = Quaternion.Euler(2.2915f, 65.1248f, 13.5387f),
        Allegiance = Faction.Red,
        DisplayName = "bmp 1m",

      },
      new SpawnEntry {
        PrefabName = "BMP1",
        Position = new Vector3(2274.857f, 30.0194f, 1546.154f),
        Rotation = Quaternion.Euler(0.2866f, 103.6325f, 359.6193f),
        Allegiance = Faction.Red,
        DisplayName = "bmp 2m",

      },
      new SpawnEntry {
        PrefabName = "BMP1",
        Position = new Vector3(2275.528f, 43.6543f, 2006.515f),
        Rotation = Quaternion.Euler(8.3615f, 129.3496f, 356.9737f),
        Allegiance = Faction.Red,
        DisplayName = "bmp 3m",

      },

      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(2196.855f, 54.4147f, 1164.943f),
        Rotation = Quaternion.Euler(3.867f, 78.8849f, 3.4941f),
        Allegiance = Faction.Red,
        DisplayName = "9k111 1m",
      },

      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(2205.227f, 47.3628f, 1287.621f),
        Rotation = Quaternion.Euler(357.0048f, 94.1986f, 0.0689f),
        Allegiance = Faction.Red,
        DisplayName = "9k111 2m",
      },

      new SpawnEntry {
        PrefabName = "T55A",
        Position = new Vector3(2238.8f, 29.6019f, 1716.569f),
        Rotation = Quaternion.Euler(358.9609f, 84.825f, 359.515f),
        Allegiance = Faction.Red,
        DisplayName = "T55A 1m",
      },

      new SpawnEntry {
        PrefabName = "T55A",
        Position = new Vector3(2260.77f, 35.2264f, 1839.592f),
        Rotation = Quaternion.Euler(1.4394f, 109.8026f, 4.6214f),
        Allegiance = Faction.Red,
        DisplayName = "T55A 2m",
      },

      new SpawnEntry { PrefabName = "T72M",
                       Position = new Vector3(874.0652f, 14.2749f, 2631.646f),
                       Rotation = Quaternion.Euler(358.1262f, 139.6224f,
                                                   1.3836f),
                       Allegiance = Faction.Red, DisplayName = "t72m 1m",
                       IsMobile = true, MobileDelay = 1f },

      new SpawnEntry { PrefabName = "T72M",
                       Position = new Vector3(848.3154f, 13.4988f, 2671.636f),
                       Rotation = Quaternion.Euler(1.1931f, 215.6766f, 0.3671f),
                       Allegiance = Faction.Red, DisplayName = "t72m 2m",
                       IsMobile = true, MobileDelay = 5f },

      new SpawnEntry { PrefabName = "T72M",
                       Position = new Vector3(880.3998f, 13.8468f, 2659.667f),
                       Rotation = Quaternion.Euler(359.4855f, 78.9484f,
                                                   359.6569f),
                       Allegiance = Faction.Red, DisplayName = "t72m 3m",
                       IsMobile = true, MobileDelay = 10f },

    };
  }
}

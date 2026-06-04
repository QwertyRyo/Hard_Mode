using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_Meditative_Malediction {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {

      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(-1531.696f, 173.96f, 1391.021f),
                       Rotation = Quaternion.Euler(357.7983f, 352.8113f,
                                                   5.4052f),
                       Allegiance = Faction.Red, DisplayName = "t55 1 modded",
                       IsMobile = true, MobileDelay = 150f },
      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(-1513.154f, 173.4875f, 1342.445f),
                       Rotation = Quaternion.Euler(355.8706f, 23.6831f,
                                                   1.3591f),
                       Allegiance = Faction.Red, DisplayName = "bmp1p 1 modded",
                       IsMobile = true, MobileDelay = 150f },
      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(-1560.45f, 169.7231f, 1325.652f),
                       Rotation = Quaternion.Euler(355.8706f, 23.6831f,
                                                   1.3591f),
                       Allegiance = Faction.Red, DisplayName = "bmp1p 2 modded",
                       IsMobile = true, MobileDelay = 150f },

      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(-2504.375f, 177.4246f, 2275.846f),
        Rotation = Quaternion.Euler(0.2853f, 316.9645f, 1.2864f),
        Allegiance = Faction.Red,
        DisplayName = "spg9 1m",
      },
      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(-1984.198f, 147.5168f, 2474.689f),
        Rotation = Quaternion.Euler(358.5112f, 258.8641f, 357.7567f),
        Allegiance = Faction.Red,
        DisplayName = "spg9 2m",
      },
      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(-1178.152f, 168.8214f, 1718.205f),
        Rotation = Quaternion.Euler(1.5994f, 352.4839f, 356.8485f),
        Allegiance = Faction.Red,
        DisplayName = "spg9 3m",
      },

      new SpawnEntry {
        PrefabName = "BMP1",
        Position = new Vector3(-1690.439f, 156.4198f, 2437.52f),
        Rotation = Quaternion.Euler(1.2991f, 256.6703f, 1.0787f),
        Allegiance = Faction.Red,
        DisplayName = "bmp1 1m",
      },
      new SpawnEntry {
        PrefabName = "BMP1",
        Position = new Vector3(-1690.381f, 155.6924f, 2385.209f),
        Rotation = Quaternion.Euler(358.782f, 226.1353f, 2.6374f),
        Allegiance = Faction.Red,
        DisplayName = "bmp1 2m",
      },
      new SpawnEntry {
        PrefabName = "BMP1",
        Position = new Vector3(-1678.967f, 164.9948f, 2251.359f),
        Rotation = Quaternion.Euler(3.929f, 282.1176f, 354.452f),
        Allegiance = Faction.Red,
        DisplayName = "bmp1 3m",
      },

      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(-1448.915f, 185.5614f, 1586.727f),
        Rotation = Quaternion.Euler(2.6464f, 262.6761f, 0.8843f),
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

      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(-1073.688f, 172.3255f, 2016.393f),
        Rotation = Quaternion.Euler(359.9878f, 220.5625f, 0.2329f),
        Allegiance = Faction.Red,
        DisplayName = "9k111 3m",
      },
      new SpawnEntry {
        PrefabName = "BTR60PB",
        Position = new Vector3(-978.122f, 166.1493f, 1910.546f),
        Rotation = Quaternion.Euler(358.2728f, 300.1281f, 359.8649f),
        Allegiance = Faction.Red,
        DisplayName = "BTR60PB 1m",
      },
      new SpawnEntry {
        PrefabName = "BTR60PB",
        Position = new Vector3(-962.9272f, 165.5008f, 1899.783f),
        Rotation = Quaternion.Euler(358.2728f, 300.1281f, 359.8649f),
        Allegiance = Faction.Red,
        DisplayName = "BTR60PB 2m",
      },
      new SpawnEntry {
        PrefabName = "BTR60PB",
        Position = new Vector3(-941.0702f, 164.6047f, 1887.355f),
        Rotation = Quaternion.Euler(358.2728f, 300.1281f, 359.8649f),
        Allegiance = Faction.Red,
        DisplayName = "BTR60PB 3m",
      },

      new SpawnEntry {
        PrefabName = "T55A",
        Position = new Vector3(-714.1802f, 141.6088f, 1145.404f),
        Rotation = Quaternion.Euler(355.1456f, 289.5328f, 1.6435f),
        Allegiance = Faction.Red,
        DisplayName = "T55a 2m",
      },
      new SpawnEntry { PrefabName = "T72GILLS",
                       Position = new Vector3(-361.9464f, 101.4882f, 1086.839f),
                       Rotation = Quaternion.Euler(0.5171f, 51.006f, 354.6722f),
                       Allegiance = Faction.Red, DisplayName = "T72 3m",
                       IsMobile = true, MobileDelay = 280f },
      new SpawnEntry { PrefabName = "T72GILLS",
                       Position = new Vector3(-315.6803f, 101.4649f, 1133.61f),
                       Rotation = Quaternion.Euler(357.5556f, 25.6482f,
                                                   350.6813f),
                       Allegiance = Faction.Red, DisplayName = "T72 2m",
                       IsMobile = true, MobileDelay = 280f },
      new SpawnEntry { PrefabName = "T72GILLS",
                       Position = new Vector3(-295.5682f, 102.8465f, 1169.277f),
                       Rotation = Quaternion.Euler(357.6666f, 27.9725f,
                                                   350.7097f),
                       Allegiance = Faction.Red, DisplayName = "T72 1m",
                       IsMobile = true, MobileDelay = 280f },

    };
  }
}

using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_Marketable_Mayham {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      new SpawnEntry {
        PrefabName = "BMP1",
        Position = new Vector3(-2893.593f, 150.2475f, -2152.09f),
        Rotation = Quaternion.Euler(0.7853f, 33.7741f, 1.3355f),
        Allegiance = Faction.Red,
        DisplayName = "bmp1 1 modded",

      },
      new SpawnEntry {
        PrefabName = "BMP1P",
        Position = new Vector3(-3244.506f, 207.5419f, -2879.306f),
        Rotation = Quaternion.Euler(354.0286f, 186.7547f, 359.2115f),
        Allegiance = Faction.Red, DisplayName = "bmp1p 3 modded",
        IsMobile = true, MobileDelay = 180f

      },
      new SpawnEntry {
        PrefabName = "BMP1P",
        Position = new Vector3(-3257.569f, 215.5134f, -2984.9f),
        Rotation = Quaternion.Euler(355.5276f, 185.597f, 0.7497f),
        Allegiance = Faction.Red, DisplayName = "bmp1p 4 modded",
        IsMobile = true, MobileDelay = 170f

      },
      new SpawnEntry {
        PrefabName = "T72M1",
        Position = new Vector3(-2625.456f, 148.2067f, -2077.556f),
        Rotation = Quaternion.Euler(0.0721f, 35.9046f, 355.9981f),
        Allegiance = Faction.Red,
        DisplayName = "t72m1 2 modded",
      },
      new SpawnEntry {
        PrefabName = "T72M1",
        Position = new Vector3(-2960.794f, 149.9839f, -2141.26f),
        Rotation = Quaternion.Euler(3.0681f, 54.4838f, 2.5302f),
        Allegiance = Faction.Red,
        DisplayName = "t72m1 1 modded",
      },
      new SpawnEntry {
        PrefabName = "T72M1",
        Position = new Vector3(-2443.224f, 138.9082f, -2163.541f),
        Rotation = Quaternion.Euler(5.5354f, 27.3993f, 359.4522f),
        Allegiance = Faction.Red,
        DisplayName = "t72m1 3 modded",
      },

      new SpawnEntry {
        PrefabName = "STATIC_SPG9",
        Position = new Vector3(-2310.189f, 118.6204f, -1972.407f),
        Rotation = Quaternion.Euler(4.3951f, 42.9827f, 359.2975f),
        Allegiance = Faction.Red,
        DisplayName = "spg9 1m",
      },

      new SpawnEntry {
        PrefabName = "T55A",
        Position = new Vector3(-2383.053f, 126.494f, -1869.626f),
        Rotation = Quaternion.Euler(0.2477f, 68.6563f, 355.2943f),
        Allegiance = Faction.Red,
        DisplayName = "t55a 1m",
      },
      new SpawnEntry {
        PrefabName = "T55A",
        Position = new Vector3(-2443.21f, 132.1803f, -1827.355f),
        Rotation = Quaternion.Euler(4.0326f, 70.8307f, 358.2252f),
        Allegiance = Faction.Red,
        DisplayName = "t55a 2m",
      },

      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(-2672.342f, 133.0822f, -1844.442f),
        Rotation = Quaternion.Euler(358.1216f, 226.4893f, 355.4749f),
        Allegiance = Faction.Red,
        DisplayName = "9k111 1m",
      },

      new SpawnEntry {
        PrefabName = "STATIC_9K111",
        Position = new Vector3(-2979.505f, 149.4728f, -2126.519f),
        Rotation = Quaternion.Euler(354.7929f, 66.7236f, 0.6904f),
        Allegiance = Faction.Red,
        DisplayName = "9k111 2m",
      },

      new SpawnEntry { PrefabName = "T72M1",
                       Position = new Vector3(-3119.03f, 168.866f, -2339.06f),
                       Rotation = Quaternion.Euler(359.2972f, 346.8363f,
                                                   357.3244f),
                       Allegiance = Faction.Red, DisplayName = "T72M1 4m",
                       IsMobile = true, MobileDelay = 300f },
      new SpawnEntry {
        PrefabName = "BMP1P",
        Position = new Vector3(-3122.921f, 172.1497f, -2394.792f),
        Rotation = Quaternion.Euler(4.4951f, 18.7106f, 356.9665f),
        Allegiance = Faction.Red, DisplayName = "bmp1p 1m", IsMobile = true,
        MobileDelay = 305f
      },

      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(-3148.953f, 175.1307f,
                                              -2404.629f),
                       Rotation = Quaternion.Euler(3.4436f, 3.2138f, 352.8107f),
                       Allegiance = Faction.Red, DisplayName = "bmp1p 2m",
                       IsMobile = true, MobileDelay = 310f },

      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(-3590.043f, 160.7035f, 1032.307f),
                       Rotation = Quaternion.Euler(0.6139f, 174.7558f, 4.0896f),
                       Allegiance = Faction.Red, DisplayName = "t55a 3m",
                       IsMobile = true, MobileDelay = 1f },
      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(-3622.765f, 166.1045f, 910.4492f),
                       Rotation = Quaternion.Euler(0.1754f, 191.5037f, 1.825f),
                       Allegiance = Faction.Red, DisplayName = "t55a 4m",
                       IsMobile = true, MobileDelay = 1f },
      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(-3647.164f, 168.5314f, 815.4715f),
                       Rotation = Quaternion.Euler(0.0708f, 195.9646f, 0.0961f),
                       Allegiance = Faction.Red, DisplayName = "t55a 5m",
                       IsMobile = true, MobileDelay = 1f },



    };
  }
}

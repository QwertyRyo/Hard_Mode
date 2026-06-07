using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;


namespace Hard_Mode {
  public static class GT03_Savage_Scream_UMC {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      new SpawnEntry { PrefabName = "STATIC_9K111", Position = new Vector3(1037.83f, 39.4454f, 448.069f),
                       Rotation = Quaternion.Euler(3.7975f, 63.5379f, 9.8093f),
                       Allegiance = Faction.Red, DisplayName = "9k111 1 Modded" },
      new SpawnEntry { PrefabName = "STATIC_9K111", Position = new Vector3(1535.526f, 20.9811f, 1282.737f),
                       Rotation = Quaternion.Euler(358.6926f, 196.707f, 0.9284f),
                       Allegiance = Faction.Red, DisplayName = "9k111 2 Modded" },
      new SpawnEntry { PrefabName = "BMP1", Position = new Vector3(1658.186f, 24.9929f, 1216.525f),
                       Rotation = Quaternion.Euler(0.0632f, 72.7601f, 3.3481f),
                       Allegiance = Faction.Red, DisplayName = "bmp1 1 Modded" },
      new SpawnEntry { PrefabName = "T55A", Position = new Vector3(371.709f, 73.9685f, 1608.215f),
                       Rotation = Quaternion.Euler(359.0435f, 105.1689f, 1.0387f),
                       Allegiance = Faction.Red, DisplayName = "T-55A 1 Modded", },
      new SpawnEntry { PrefabName = "T55A", Position = new Vector3(283.8748f, 67.9072f, 1514.622f),
                       Rotation = Quaternion.Euler(5.2412f, 139.0714f, 354.4569f),
                       Allegiance = Faction.Red, DisplayName = "T-55A 2 Modded" },
      new SpawnEntry { PrefabName = "T55A", Position = new Vector3(1306.651f, 20.5041f, 1979.737f),
                       Rotation = Quaternion.Euler(359.3138f, 120.0239f, 0.2733f),
                       Allegiance = Faction.Red, DisplayName = "T-55A 3 Modded",  },
      new SpawnEntry { PrefabName = "STATIC_SPG9", Position = new Vector3(1293.217f, 21.6553f, 1838.804f),
                       Rotation = Quaternion.Euler(1.8555f, 294.8187f, 1.9975f),
                       Allegiance = Faction.Red, DisplayName = "SPG9 1m"},
                       new SpawnEntry { PrefabName = "BMP1P", Position = new Vector3(201.9734f, 57.611f, 618.3578f),
                       Rotation = Quaternion.Euler(3.8743f, 54.6951f, 5.1255f),
                       Allegiance = Faction.Red, DisplayName = "BMP1P 1m"},

  new SpawnEntry { PrefabName = "BMP1P", Position = new Vector3(                       -532.9193f, 115.8094f, 872.1526f),
                       Rotation = Quaternion.Euler(4.4797f, 158.5153f, 2.9231f),
                       Allegiance = Faction.Red, DisplayName = "BMP1P 2m"},

                       
  new SpawnEntry { PrefabName = "BMP1P", Position = new Vector3(                             -472.2092f, 135.0432f, 1528.261f),
                       Rotation = Quaternion.Euler(2.6648f, 39.1268f, 0.0408f),
                       Allegiance = Faction.Red, DisplayName = "BMP1P 2m"},


  new SpawnEntry { PrefabName = "T72M1", Position = new Vector3(                             -717.5548f, 152.4454f, 1398.383f),
                       Rotation = Quaternion.Euler(4.1963f, 82.7043f, 359.3145f),
                       Allegiance = Faction.Red, DisplayName = "T72M1 1m", IsMobile = true, MobileDelay = 350f},
                       
  new SpawnEntry { PrefabName = "T72M1", Position = new Vector3(                             -738.0165f, 151.55f, 1318.284f),
                       Rotation = Quaternion.Euler(3.3821f, 84.8115f, 357.3883f),
                       Allegiance = Faction.Red, DisplayName = "T72M1 2m", IsMobile = true, MobileDelay = 350f},
                       
  new SpawnEntry { PrefabName = "T72M1", Position = new Vector3(                             -713.614f, 152.9896f, 1506.625f),
                       Rotation = Quaternion.Euler(2.5477f, 66.3472f, 359.0976f),
                       Allegiance = Faction.Red, DisplayName = "T72M1 3m", IsMobile = true, MobileDelay = 350f},


                         new SpawnEntry { PrefabName = "T72M1", Position = new Vector3(                             846.6462f, 13.5082f, 2663.604f),
                       Rotation = Quaternion.Euler(359.2512f, 152.3207f, 359.641f),
                       Allegiance = Faction.Red, DisplayName = "T72M1 4m", IsMobile = true, MobileDelay = 110f},
                       
  new SpawnEntry { PrefabName = "T72M1", Position = new Vector3(                             830.2562f, 13.3199f, 2684.969f),
                       Rotation = Quaternion.Euler(359.9042f, 140.932f, 359.4987f),
                       Allegiance = Faction.Red, DisplayName = "T72M1 5m",
                       IsMobile = true, MobileDelay = 120f},
                       
  new SpawnEntry { PrefabName = "T72M1", Position = new Vector3(                             817.0481f, 13.3283f, 2702.802f),
                       Rotation = Quaternion.Euler(359.602f, 128.4201f, 359.48f),
                       Allegiance = Faction.Red, DisplayName = "T72M1 6m", IsMobile = true, MobileDelay = 130f},


      };
    };
  }


using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_CrossScreen {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {

      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(2063.451f, 36.9339f, 227.5966f),
                       Rotation = Quaternion.Euler(357.0266f, 350.2686f, 5.2596f),
                       Allegiance = Faction.Red, DisplayName = "BMP1P modded 1",
                       IsMobile = true, MobileDelay = 240f },
      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(2121.852f, 40.9241f, 187.9946f),
                       Rotation = Quaternion.Euler(357.4064f, 351.8694f, 6.4234f),
                       Allegiance = Faction.Red, DisplayName = "BMP1P modded 2",
                       IsMobile = true, MobileDelay = 240f },
      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(2179.731f, 42.6855f, 144.5998f),
                       Rotation = Quaternion.Euler(352.1408f, 347.6643f, 2.6595f),
                       Allegiance = Faction.Red,
                       DisplayName = "bmp1 modded 3" ,
                                              IsMobile = true, MobileDelay = 240f },



                                                    new SpawnEntry { PrefabName = "BMP1",
                       Position = new Vector3(-384.9641f, 59.3052f, -47.9914f),
                       Rotation = Quaternion.Euler(356.3154f, 14.2226f, 353.2887f),
                       Allegiance = Faction.Red, DisplayName = "BMP1 modded 1",
                       IsMobile = true, MobileDelay = 240f },
      new SpawnEntry { PrefabName = "BMP1",
                       Position = new Vector3(-294.0887f, 55.1884f, -71.2131f),
                       Rotation = Quaternion.Euler(359.2348f, 23.4185f, 0.3622f),
                       Allegiance = Faction.Red, DisplayName = "BMP1 modded 2",
                       IsMobile = true, MobileDelay = 240f },
      new SpawnEntry { PrefabName = "BMP1",
                       Position = new Vector3(-483.5648f, 63.2097f, -21.6697f),
                       Rotation = Quaternion.Euler(358.2612f, 12.1933f, 0.9585f),
                       Allegiance = Faction.Red,
                       DisplayName = "bmp1 modded 3" ,
                                              IsMobile = true, MobileDelay = 240f },


        new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(-903.7996f, 68.1628f, -40.4261f),
                       Rotation = Quaternion.Euler(348.4512f, 54.1955f, 1.0163f),
                       Allegiance = Faction.Red, DisplayName = "bmp1p modded 4",
                       IsMobile = true, MobileDelay = 480f },
      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(-911.5703f, 75.7868f, 42.7741f),
                       Rotation = Quaternion.Euler(355.6098f, 79.2609f, 0.0846f),
                       Allegiance = Faction.Red, DisplayName = "bmp1p modded 5",
                       IsMobile = true, MobileDelay = 480f },
      new SpawnEntry { PrefabName = "BMP1P",
                       Position = new Vector3(-878.0099f, 64.3321f, -105.4366f),
                       Rotation = Quaternion.Euler(351.5778f, 54.4411f, 359.1338f),
                       Allegiance = Faction.Red,
                       DisplayName = "bmp1p modded 6" ,
                                              IsMobile = true, MobileDelay = 480f },


                                              
        new SpawnEntry { PrefabName = "T72M",
                       Position = new Vector3(
                      1809.23f, 36.7514f, -993.4669f),
                       Rotation = Quaternion.Euler(358.8611f, 23.5677f, 2.4199f),
                       Allegiance = Faction.Red, DisplayName = "t72m modded 1",
                       IsMobile = true, MobileDelay = 480f },
      new SpawnEntry { PrefabName = "T72M",
                       Position = new Vector3(1714.155f, 35.4013f, -1031.973f),
                       Rotation = Quaternion.Euler(1.7266f, 21.6671f, 0.0412f),
                       Allegiance = Faction.Red, DisplayName = "t72m modded 2",
                       IsMobile = true, MobileDelay = 480f },
      new SpawnEntry { PrefabName = "T72M",
                       Position = new Vector3(1611.458f, 34.383f, -1072.018f),
                       Rotation = Quaternion.Euler(359.1015f, 13.7749f, 3.5795f),
                       Allegiance = Faction.Red,
                       DisplayName = "t72m modded 3" ,
                                              IsMobile = true, MobileDelay = 480f },



      new SpawnEntry { PrefabName = "BRDM2",
                       Position = new Vector3(-753.5039f, 143.9908f, 1158.776f),
                       Rotation = Quaternion.Euler(356.6136f, 273.0716f, 358.2046f),
                       Allegiance = Faction.Red, DisplayName = "BRDM modded 1",
                       IsMobile = true, MobileDelay = 320f },
      new SpawnEntry { PrefabName = "BRDM2",
                       Position = new Vector3(-786.9856f, 145.72f, 1099.503f),
                       Rotation = Quaternion.Euler(355.9022f, 261.6577f, 358.9535f),
                       Allegiance = Faction.Red,
                       DisplayName = "brdm modded 2" ,
                                              IsMobile = true, MobileDelay = 320f },


      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(-856.3149f, 158.3215f, 1422.195f),
                       Rotation = Quaternion.Euler(359.4257f, 12.7219f, 357.5196f),
                       Allegiance = Faction.Red, DisplayName = "T55A modded 1",
                       IsMobile = true, MobileDelay = 360f },
      new SpawnEntry { PrefabName = "BMP2",
                       Position = new Vector3(-976.5685f, 164.1935f, 1348.479f),
                       Rotation = Quaternion.Euler(0.757f, 16.6572f, 356.0337f),
                       Allegiance = Faction.Red,
                       DisplayName = "bmp2 modded 1" ,
                                              IsMobile = true, MobileDelay = 360f },

                                                    new SpawnEntry { PrefabName = "BMP2",
                       Position = new Vector3(-1095.633f, 173.7639f, 1274.133f),
                       Rotation = Quaternion.Euler(358.6349f, 12.317f, 356.5453f),
                       Allegiance = Faction.Red,
                       DisplayName = "bmp2 modded 2" ,
                                              IsMobile = true, MobileDelay = 360f },




    };
  }
}

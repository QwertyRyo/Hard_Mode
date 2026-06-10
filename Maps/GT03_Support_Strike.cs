using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_Support_Strike {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      // M2BRADLEY
      //-504.0772 136.3181 1492.66
      //359.8843 18.4918 357.3337

      //-526.9102 115.387 874.1965
      //4.9661 170.4844 4.4798

      /*M60A3TTS
26.2438 102.4708 2806.66
7.0632 139.4835 5.9458

106.783 95.9421 2990.651
12.3144 86.1699 354.9681

//M60A1RISEP77
305.3609 64.8512 2851.929
4.4393 122.0277 7.5125

435.8275 44.0451 2635.247
3.4243 171.547 4.8364

//LEOPARD1A1A4
-35.6027 73.6161 498.6565
4.1735 93.9335 2.1411

63.0188 70.9774 436.7086
4.1735 93.9335 2.1411

//M1
837.8677 40.5675 -105.8037
0.0505 78.0027 357.7256

788.4609 45.7426 -13.4396
358.8918 37.1782 355.5084

//MARDER1A2
979.2009 47.909 337.5237
1.8873 44.2037 0.1141

1016.651 48.4352 315.1222
1.0603 115.2685 355.1558

//M1IP
2019.887 31.6271 36.3391
2.8849 19.9424 2.4186

1925.189 30.9692 229.5514
1.1117 42.4738 0.6001
//
      */
      new SpawnEntry {
        PrefabName = "M2BRADLEY", Position = new Vector3(-504.0772f, 136.3181f, 1492.66f),
        Rotation = Quaternion.Euler(359.8843f, 18.4918f, 357.3337f),
        Allegiance = Faction.Blue, DisplayName = "BRAD 1m", IsMobile = true, MobileDelay = 300f
      },
      new SpawnEntry {
        PrefabName = "M2BRADLEY", Position = new Vector3(-526.9102f, 115.387f, 874.1965f),
        Rotation = Quaternion.Euler(4.9661f, 170.4844f, 4.4798f),
        Allegiance = Faction.Blue, DisplayName = "BRAD 2m", IsMobile = true, MobileDelay = 325f
      },

      new SpawnEntry {
        PrefabName = "M60A3TTS", Position = new Vector3(26.2438f, 102.4708f, 2806.66f),
        Rotation = Quaternion.Euler(7.0632f, 139.4835f, 5.9458f),
        Allegiance = Faction.Blue, DisplayName = "M60A3 1m", IsMobile = true, MobileDelay = 300f
      },
      new SpawnEntry {
        PrefabName = "M60A3TTS", Position = new Vector3(106.783f, 95.9421f, 2990.651f),
        Rotation = Quaternion.Euler(12.3144f, 86.1699f, 354.9681f),
        Allegiance = Faction.Blue, DisplayName = "M60A3 2m", IsMobile = true, MobileDelay = 325f
      },

      new SpawnEntry {
        PrefabName = "M60A1RISEP77", Position = new Vector3(305.3609f, 64.8512f, 2851.929f),
        Rotation = Quaternion.Euler(4.4393f, 122.0277f, 7.5125f),
        Allegiance = Faction.Blue, DisplayName = "RISEP 1m", IsMobile = true, MobileDelay = 300f
      },
      new SpawnEntry {
        PrefabName = "M60A1RISEP77", Position = new Vector3(435.8275f, 44.0451f, 2635.247f),
        Rotation = Quaternion.Euler(3.4243f, 171.547f, 4.8364f),
        Allegiance = Faction.Blue, DisplayName = "RISEP 2m", IsMobile = true, MobileDelay = 325f
      },

      new SpawnEntry {
        PrefabName = "LEO1A1A4", Position = new Vector3(-35.6027f, 73.6161f, 498.6565f),
        Rotation = Quaternion.Euler(4.1735f, 93.9335f, 2.1411f),
        Allegiance = Faction.Blue, DisplayName = "LEO 1m", IsMobile = true, MobileDelay = 300f
      },
      new SpawnEntry {
        PrefabName = "LEO1A1A4", Position = new Vector3(63.0188f, 70.9774f, 436.7086f),
        Rotation = Quaternion.Euler(4.1735f, 93.9335f, 2.1411f),
        Allegiance = Faction.Blue, DisplayName = "LEO 2m", IsMobile = true, MobileDelay = 325f
      },

      new SpawnEntry {
        PrefabName = "M1", Position = new Vector3(837.8677f, 40.5675f, -105.8037f),
        Rotation = Quaternion.Euler(0.0505f, 78.0027f, 357.7256f),
        Allegiance = Faction.Blue, DisplayName = "M1 1m", IsMobile = true, MobileDelay = 300f
      },
      new SpawnEntry {
        PrefabName = "M1", Position = new Vector3(788.4609f, 45.7426f, -13.4396f),
        Rotation = Quaternion.Euler(358.8918f, 37.1782f, 355.5084f),
        Allegiance = Faction.Blue, DisplayName = "M1 2m", IsMobile = true, MobileDelay = 325f
      },

      new SpawnEntry {
        PrefabName = "MARDER1A2", Position = new Vector3(979.2009f, 47.909f, 337.5237f),
        Rotation = Quaternion.Euler(1.8873f, 44.2037f, 0.1141f),
        Allegiance = Faction.Blue, DisplayName = "MARDER 1m", IsMobile = true, MobileDelay = 300f
      },
      new SpawnEntry {
        PrefabName = "MARDER1A2", Position = new Vector3(1016.651f, 48.4352f, 315.1222f),
        Rotation = Quaternion.Euler(1.0603f, 115.2685f, 355.1558f),
        Allegiance = Faction.Blue, DisplayName = "MARDER 2m", IsMobile = true, MobileDelay = 325f
      },

      new SpawnEntry {
        PrefabName = "M1IP", Position = new Vector3(2019.887f, 31.6271f, 36.3391f),
        Rotation = Quaternion.Euler(2.8849f, 19.9424f, 2.4186f),
        Allegiance = Faction.Blue, DisplayName = "M1IP 1m", IsMobile = true, MobileDelay = 300f
      },
      new SpawnEntry {
        PrefabName = "M1IP", Position = new Vector3(1925.189f, 30.9692f, 229.5514f),
        Rotation = Quaternion.Euler(1.1117f, 42.4738f, 0.6001f),
        Allegiance = Faction.Blue, DisplayName = "M1IP 2m", IsMobile = true, MobileDelay = 325f
      },

      new SpawnEntry
      {
        PrefabName = "STATIC_TOW", Position = new Vector3(1643.11f, 27.9834f, 1160.366f), Rotation = Quaternion.Euler(355.5088f, 81.9038f, 0.1054f), Allegiance = Faction.Blue, DisplayName="tow 1m"
      },
            new SpawnEntry
      {
        PrefabName = "STATIC_TOW", Position = new Vector3(1633.107f, 21.835f, 1271.671f), Rotation = Quaternion.Euler(357.2096f, 102.5666f, 0.9657f), Allegiance = Faction.Blue, DisplayName="tow 2m"
      }
    };
  }
}

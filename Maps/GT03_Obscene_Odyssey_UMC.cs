using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;


namespace Hard_Mode {
  public static class GT03_Obscene_Odyssey_UMC{
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      new SpawnEntry { 
        PrefabName = "STATIC_TOW", 
        Position = new Vector3(-2303.416f, 124.8224f, 358.9623f),

        Rotation = Quaternion.Euler(0.4761f, 323.8726f, 357.7026f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 1m",
    },

          new SpawnEntry { 
        PrefabName = "STATIC_TOW", 
        Position = new Vector3(-1859.314f, 86.3857f, 271.053f),

        Rotation = Quaternion.Euler(358.6068f, 282.8558f, 1.3311f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 2m",
    },

        new SpawnEntry { 
        PrefabName = "MARDER1A2", 
        Position = new Vector3(-1498.468f, 71.7714f, -284.8744f),

        Rotation = Quaternion.Euler(359.6639f, 311.5284f, 2.2216f),
        Allegiance = Faction.Blue,
        DisplayName = "mard 1m",
    },
    
        new SpawnEntry { 
        PrefabName = "MARDER1A2", 
        Position = new Vector3(-1511.839f, 70.5378f, -383.9064f),

        Rotation = Quaternion.Euler(359.5847f, 321.6577f, 358.9438f),
        Allegiance = Faction.Blue,
        DisplayName = "mard 2m",
    },

        new SpawnEntry { 
        PrefabName = "MARDER1A2", 
        Position = new Vector3(-2590.998f, 94.5018f, -979.5547f),

        Rotation = Quaternion.Euler(0.6644f, 17.1757f, 0.0007f),
        Allegiance = Faction.Blue,
        DisplayName = "mard 3m",
    },

          new SpawnEntry { 
        PrefabName = "LEO1A1A4", 
        Position = new Vector3(-1437.983f, 69.9886f, -264.8561f),

        Rotation = Quaternion.Euler(359.8424f, 339.1688f, 1.275f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 1m",
    },

          new SpawnEntry { 
        PrefabName = "LEO1A1A4", 
        Position = new Vector3(-1303.602f, 63.6116f, -302.6525f),

        Rotation = Quaternion.Euler(358.1241f, 331.4986f, 357.0677f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 2m",
    },
          new SpawnEntry { 
        PrefabName = "LEO1A1A4", 
        Position = new Vector3(-2437.827f, 130.5932f, -1710.941f),

        Rotation = Quaternion.Euler(4.1882f, 342.7756f, 352.2381f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 3m",
    },
          new SpawnEntry { 
        PrefabName = "LEO1A1A4", 
        Position = new Vector3(-2456.382f, 133.0545f, -1728.638f),

        Rotation = Quaternion.Euler(0.5271f, 357.2295f, 354.6111f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 4m",
    },

          new SpawnEntry { 
        PrefabName = "M1IP", 
        Position = new Vector3(-1742.928f, 192.1418f, -3041.54f),

        Rotation = Quaternion.Euler(1.0057f, 9.6345f, 357.2196f),
        Allegiance = Faction.Blue,
        DisplayName = "m1ip 1m",
                IsMobile = true,
        MobileDelay = 460f
    },
          new SpawnEntry { 
        PrefabName = "M1IP", 
        Position = new Vector3(-1748.149f, 192.3096f, -3050.468f),

        Rotation = Quaternion.Euler(0.1442f, 35.0285f, 356.2266f),
        Allegiance = Faction.Blue,
        DisplayName = "m1ip 2m",
        IsMobile = true,
        MobileDelay = 480f
    },
              new SpawnEntry { 
        PrefabName = "M1IP", 
        Position = new Vector3(-1413.146f, 172.411f, -2894.389f),

        Rotation = Quaternion.Euler(1.481f, 319.8013f, 359.4129f),
        Allegiance = Faction.Blue,
        DisplayName = "m1ip 3m",
        IsMobile = true,
        MobileDelay = 500f
    },
              new SpawnEntry { 
        PrefabName = "M1IP", 
        Position = new Vector3(-1400.892f, 172.5052f, -2895.438f),

        Rotation = Quaternion.Euler(0.8344f, 271.4416f, 358.3759f),
        Allegiance = Faction.Blue,
        DisplayName = "m1ip 4m",
        IsMobile = true,
        MobileDelay = 520f
    },
                  new SpawnEntry { 
        PrefabName = "M1", 
        Position = new Vector3(-581.3752f, 142.8085f, -2358.981f),

        Rotation = Quaternion.Euler(358.6748f, 7.5981f, 358.2712f),
        Allegiance = Faction.Blue,
        DisplayName = "m1 2m",
        IsMobile = true,
        MobileDelay = 600f
    },
                  new SpawnEntry { 
        PrefabName = "M1IP", 
        Position = new Vector3(-582.6044f, 142.8107f, -2345.468f),

        Rotation = Quaternion.Euler(0.7847f, 351.6206f, 356.2575f),
        Allegiance = Faction.Blue,
        DisplayName = "m1 1m",
        IsMobile = true,
        MobileDelay = 580f
    },
    

             
  };
}
}
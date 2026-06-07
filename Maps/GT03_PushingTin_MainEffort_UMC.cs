using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;


namespace Hard_Mode {
  public static class GT03_PushingTin_MainEffort_UMC{
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      new SpawnEntry { 
        PrefabName = "STATIC_TOW", 
        Position = new Vector3(-1882.208f, 81.2033f, 636.3765f),

        Rotation = Quaternion.Euler(357.5375f, 303.3387f, 6.6154f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 1m",
    },

          new SpawnEntry { 
        PrefabName = "STATIC_TOW", 
        Position = new Vector3(-506.17f, 53.8719f, -689.8724f),

        Rotation = Quaternion.Euler(0.9462f, 302.1714f, 0.1419f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 2m",
    },

        new SpawnEntry { 
        PrefabName = "M2BRADLEY", 
        Position = new Vector3(-2978.998f, 122.8641f, 375.5743f),

        Rotation = Quaternion.Euler(4.9555f, 72.2591f, 358.3615f),
        Allegiance = Faction.Blue,
        DisplayName = "brad1m",
    },

    
        new SpawnEntry { 
        PrefabName = "M2BRADLEY", 
        Position = new Vector3(-1444.494f, 97.7742f, 579.4036f),

        Rotation = Quaternion.Euler(2.8366f, 272.1965f, 7.2387f),
        Allegiance = Faction.Blue,
        DisplayName = "brad2m",
    },



            new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-2237.234f, 123.3839f, 384.3708f),

        Rotation = Quaternion.Euler(1.2256f, 297.9177f, 358.8525f),
        Allegiance = Faction.Blue,
        DisplayName = "M60A3 5m",
    },


      new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-3147.185f, 134.9138f, 464.7433f),

        Rotation = Quaternion.Euler(4.3935f, 81.0151f, 359.399f),
        Allegiance = Faction.Blue,
        DisplayName = "m60a3 1m",
        IsMobile = true,
        MobileDelay = 20f
    },

          new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-3195.703f, 137.9948f, 457.0427f),

        Rotation = Quaternion.Euler(357.2575f, 356.7211f, 2.6195f),
        Allegiance = Faction.Blue,
        DisplayName = "m60a3 2m",
        IsMobile = true,
        MobileDelay = 25f
    },
              new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-3229.177f, 139.3588f, 430.521f),

        Rotation = Quaternion.Euler(3.2636f, 62.8328f, 357.0816f),
        Allegiance = Faction.Blue,
        DisplayName = "m60a3 3m",
        IsMobile = true,
        MobileDelay = 30f
    },
              new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-3274.14f, 141.0822f, 408.7377f),

        Rotation = Quaternion.Euler(2.0012f, 62.4298f, 357.9136f),
        Allegiance = Faction.Blue,
        DisplayName = "m60a3 4m",
        IsMobile = true,
        MobileDelay = 35f
    },


          new SpawnEntry { 
        PrefabName = "LEO1A1", 
        Position = new Vector3(-250.2851f, 79.6797f, 854.983f),

        Rotation = Quaternion.Euler(2.5367f, 190.6196f, 3.7698f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 1m",
        IsMobile = true,
        MobileDelay = 340f
    },

          new SpawnEntry { 
        PrefabName = "LEO1A1", 
        Position = new Vector3(-240.8179f, 80.5669f, 886.5233f),

        Rotation = Quaternion.Euler(1.127f, 197.1156f, 3.3326f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 2m",
        IsMobile = true,
        MobileDelay = 350f
    },
          new SpawnEntry { 
        PrefabName = "LEO1A1", 
        Position = new Vector3(193.5895f, 127.3688f, -1665.179f),

        Rotation = Quaternion.Euler(353.7002f, 280.5853f, 2.0634f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 3m",
        IsMobile = true,
        MobileDelay = 340f
    },
          new SpawnEntry { 
        PrefabName = "LEO1A1", 
        Position = new Vector3(215.5939f, 124.8064f, -1695.353f),

        Rotation = Quaternion.Euler(351.7855f, 279.9007f, 1.875f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 4m",
        IsMobile = true,
        MobileDelay = 350f
    },
              new SpawnEntry { 
        PrefabName = "LEO1A1", 
        Position = new Vector3(95.6792f, 59.9546f, -610.1217f),

        Rotation = Quaternion.Euler(355.0135f, 240.7464f, 353.2416f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 5m",

    },
                  new SpawnEntry { 
        PrefabName = "LEO1A1", 
        Position = new Vector3(44.8523f, 90.3188f, -1016.036f),

        Rotation = Quaternion.Euler(2.8613f, 293.0974f, 358.687f),
        Allegiance = Faction.Blue,
        DisplayName = "leo1 6m",

    },

       new SpawnEntry { 
        PrefabName = "M1", 
        Position = new Vector3(-1291.29f, 184.0355f, 1459.189f),

        Rotation = Quaternion.Euler(1.7052f, 92.0743f, 356.5625f),
        Allegiance = Faction.Blue,
        DisplayName = "m1 1m",
        IsMobile = true,
        MobileDelay = 200f
    },

               new SpawnEntry { 
        PrefabName = "M1", 
        Position = new Vector3(-1332.894f, 183.7987f, 1434.779f),

        Rotation = Quaternion.Euler(4.2179f, 105.503f, 357.6236f),
        Allegiance = Faction.Blue,
        DisplayName = "m1 2m",
                IsMobile = true,
        MobileDelay = 215f
    },

  };
}
}
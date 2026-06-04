using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;


namespace Hard_Mode {
  public static class GT03_PushingTin_FlankSecurity_UMC{
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      new SpawnEntry { 
        PrefabName = "STATIC_TOW", 
        Position = new Vector3(-1953.541f, 149.8813f, 2431.563f),

        Rotation = Quaternion.Euler(357.7322f, 232.8867f, 357.1422f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 1m",
    },

    new SpawnEntry { 
        PrefabName = "STATIC_TOW", 
        Position = new Vector3(-1915.652f, 176.0311f, 1983.337f),

        Rotation = Quaternion.Euler(0.5788f, 352.5413f, 0.994f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 2m",
    },
    
    new SpawnEntry { 
        PrefabName = "STATIC_TOW", 
        Position = new Vector3(    -2806.448f, 181.7574f, 2935.998f),

        Rotation = Quaternion.Euler(4.5973f, 178.4152f, 1.133f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 3m",
    },


        new SpawnEntry { 
        PrefabName = "M2BRADLEY", 
        Position = new Vector3(-1692.005f, 164.7277f, 2244.916f),

        Rotation = Quaternion.Euler(358.8066f, 260.3534f, 354.073f),
        Allegiance = Faction.Blue,
        DisplayName = "brad1m",
    },

    
        new SpawnEntry { 
        PrefabName = "M2BRADLEY", 
        Position = new Vector3(    -2263.506f, 150.0835f, 2829.333f),

        Rotation = Quaternion.Euler(358.7857f, 255.7956f, 0.0817f),
        Allegiance = Faction.Blue,
        DisplayName = "brad2m",
    },

        
        new SpawnEntry { 
        PrefabName = "M113", 
        Position = new Vector3(    -2620.753f, 182.208f, 2607.782f),

        Rotation = Quaternion.Euler(355.0363f, 248.7894f, 355.6173f),
        Allegiance = Faction.Blue,
        DisplayName = "m113 1m",
    },

            new SpawnEntry { 
        PrefabName = "M113", 
        Position = new Vector3(-2747.141f, 178.987f, 2927.41f),

        Rotation = Quaternion.Euler(0.1855f, 181.3729f, 357.2298f),
        Allegiance = Faction.Blue,
        DisplayName = "m113 2m",
    },

      new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-2343.826f, 155.2407f, 1885.82f),

        Rotation = Quaternion.Euler(355.4194f, 352.8608f, 1.0505f),
        Allegiance = Faction.Blue,
        DisplayName = "m60a3 1m",
        IsMobile = true,
        MobileDelay = 20f
    },

          new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-2358.502f, 152.5624f, 1849.863f),

        Rotation = Quaternion.Euler(357.2575f, 356.7211f, 2.6195f),
        Allegiance = Faction.Blue,
        DisplayName = "m60a3 2m",
        IsMobile = true,
        MobileDelay = 25f
    },
              new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-2352.523f, 143.6435f, 1703.891f),

        Rotation = Quaternion.Euler(357.9423f, 358.0872f, 4.6098f),
        Allegiance = Faction.Blue,
        DisplayName = "m60a3 2m",
        IsMobile = true,
        MobileDelay = 30f
    },
              new SpawnEntry { 
        PrefabName = "M60A3", 
        Position = new Vector3(-2364.904f, 140.3468f, 1648.462f),

        Rotation = Quaternion.Euler(354.5903f, 12.1088f, 359.4704f),
        Allegiance = Faction.Blue,
        DisplayName = "m60a3 2m",
        IsMobile = true,
        MobileDelay = 35f
    },



                new SpawnEntry { 
        PrefabName = "M1", 
        Position = new Vector3(-1736.036f, 161.7971f, 1426.514f),

        Rotation = Quaternion.Euler(354.4986f, 34.5789f, 357.5471f),
        Allegiance = Faction.Blue,
        DisplayName = "m1 1m",
        IsMobile = true,
        MobileDelay = 120f
    },

               new SpawnEntry { 
        PrefabName = "M1", 
        Position = new Vector3(-1787.106f, 160.0393f, 1447.357f),

        Rotation = Quaternion.Euler(355.5062f, 19.4264f, 3.0702f),
        Allegiance = Faction.Blue,
        DisplayName = "m1 2m",
                IsMobile = true,
        MobileDelay = 140f
    },

    
                new SpawnEntry { 
        PrefabName = "M1IP", 
        Position = new Vector3(-1170.83f, 141.4499f, 892.8118f),

        Rotation = Quaternion.Euler(354.3644f, 354.6943f, 359.1943f),
        Allegiance = Faction.Blue,
        DisplayName = "m1ip 1m",
        IsMobile = true,
        MobileDelay = 240f
    },

               new SpawnEntry { 
        PrefabName = "M1", 
        Position = new Vector3(-559.7866f, 128.3838f, 2058.492f),

        Rotation = Quaternion.Euler(358.3456f, 309.3077f, 356.4786f),
        Allegiance = Faction.Blue,
        DisplayName = "m1ip 2m",
                IsMobile = true,
        MobileDelay = 200f
    },


                new SpawnEntry { 
        PrefabName = "M1IP", 
        Position = new Vector3(-536.8727f, 139.8596f, 1624.51f),

        Rotation = Quaternion.Euler(-351.578f, 249.7122f, 3.0914f),
        Allegiance = Faction.Blue,
        DisplayName = "m1ip 3m",
        IsMobile = true,
        MobileDelay = 240f
    },

               new SpawnEntry { 
        PrefabName = "M1IP", 
        Position = new Vector3(-557.7077f, 137.1485f, 1307.907f),

        Rotation = Quaternion.Euler(358.5658f, 243.9253f, 3.6579f),
        Allegiance = Faction.Blue,
        DisplayName = "m1ip 4m",
                IsMobile = true,
        MobileDelay = 240f
    },




  };
}
}
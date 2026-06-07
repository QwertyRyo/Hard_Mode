using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_Eastern_Scramble {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {

      
      new SpawnEntry {
        PrefabName = "M60A1RISEP77", Position = new Vector3(-3490.294f, 192.1172f, -2243.555f),
        Rotation = Quaternion.Euler(355.653f, 165.053f, 3.5976f),
        Allegiance = Faction.Blue, DisplayName = "m60a1 1m", IsMobile = true,
        MobileDelay = 600f
      },
      new SpawnEntry { PrefabName = "M60A1RISEP77",
                       Position = new Vector3(-3491.177f, 190.609f, -2226.238f),
                       Rotation = Quaternion.Euler(356.5275f, 168.8745f, 5.496f),
                       Allegiance = Faction.Blue, DisplayName = "m60a1 2m",
                       IsMobile = true, MobileDelay = 620f },





                             new SpawnEntry {
        PrefabName = "LEO1A3", Position = new Vector3(-3457.476f, 184.5877f, -2182.225f),
        Rotation = Quaternion.Euler(358.8782f, 145.8282f, 4.4859f),
        Allegiance = Faction.Blue, DisplayName = "leo 1m", IsMobile = true,
        MobileDelay = 10f
        //350f
      },
      new SpawnEntry { PrefabName = "LEO1A3",
                       Position = new Vector3(-3464.945f, 184.8303f, -2170.896f),
                       Rotation = Quaternion.Euler(357.3311f, 145.7872f, 5.5868f),
                       Allegiance = Faction.Blue, DisplayName = "leo 2m",
                       IsMobile = true, MobileDelay = 370f },

//test m1

   new SpawnEntry {
        PrefabName = "M1", Position = new Vector3(-3345.808f, 157.9925f, -1922.201f),
        Rotation = Quaternion.Euler(2.0255f, 9.7347f, 353.8893f),
        Allegiance = Faction.Blue, DisplayName = "m1 3m",
      },
                             new SpawnEntry {
        PrefabName = "M1", Position = new Vector3(-3355.808f, 157.9925f, -1922.201f),
        Rotation = Quaternion.Euler(2.0255f, 9.7347f, 353.8893f),
        Allegiance = Faction.Blue, DisplayName = "m1 1m", IsMobile = true,
        MobileDelay = 1070f
      },


                             new SpawnEntry {
        PrefabName = "M113", Position = new Vector3(-3337.904f, 156.207f, -1923.708f),
        Rotation = Quaternion.Euler(8.087f, 80.6464f, 0.3168f),
        Allegiance = Faction.Blue, DisplayName = "m113 1m", IsMobile = true,
        MobileDelay = 1040f
      },


    };
  }
}

using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_prying_eyes {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      new SpawnEntry {
        PrefabName = "M113",
        Position = new Vector3(-1124.3f, 106.5355f, 549.101f),
        Rotation = Quaternion.Euler(359.8513f, 107.8015f, 351.0089f),
        Allegiance = Faction.Blue,
        DisplayName = "m113 1 modded",
      },
      new SpawnEntry {
        PrefabName = "M113",
        Position = new Vector3(-826.3487f, 79.2445f, 58.8805f),
        Rotation = Quaternion.Euler(1.8029f, 115.6392f, 0.3762f),
        Allegiance = Faction.Blue,
        DisplayName = "m113 2 modded",
      },
      new SpawnEntry {
        PrefabName = "M113",
        Position = new Vector3(-309.6461f, 51.9365f, -563.3293f),
        Rotation = Quaternion.Euler(2.166f, 28.7716f, 1.6807f),
        Allegiance = Faction.Blue,
        DisplayName = "m113 3 modded",
      },
      new SpawnEntry {
        PrefabName = "M113",
        Position = new Vector3(-27.0542f, 78.8073f, -907.1492f),
        Rotation = Quaternion.Euler(354.7453f, 144.0564f, 1.0743f),
        Allegiance = Faction.Blue,
        DisplayName = "m113 4 modded",
      },

      new SpawnEntry {
        PrefabName = "STATIC_TOW",
        Position = new Vector3(-850.5607f, 67.5179f, -96.4682f),
        Rotation = Quaternion.Euler(355.5597f, 89.778f, 354.3125f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 1 modded",
      },
      new SpawnEntry {
        PrefabName = "STATIC_TOW",
        Position = new Vector3(-319.2974f, 51.5728f, -545.0807f),
        Rotation = Quaternion.Euler(359.1909f, 112.8407f, 1.241f),
        Allegiance = Faction.Blue,
        DisplayName = "tow 2 modded",
      },

    };
  }
}

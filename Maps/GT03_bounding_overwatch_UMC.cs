using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode {
  public static class GT03_bounding_overwatch_UMC {
    public static List<SpawnEntry> Spawns() => new List<SpawnEntry> {
      new SpawnEntry { PrefabName = "BRDM2",
                       Position = new Vector3(-2975.268f, 176.2528f, 3522.69f),
                       Rotation = Quaternion.Euler(358.6857f, 241.8267f,
                                                   358.2979f),
                       Allegiance = Faction.Red, DisplayName = "brdm2 modded",
                       IsMobile = true, MobileDelay = 10f },
      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(-3148.353f, 172.4197f, 3668.099f),
                       Rotation = Quaternion.Euler(359.3554f, 296.2935f,
                                                   358.7755f),
                       Allegiance = Faction.Red, DisplayName = "t55a 2 modded",
                       IsMobile = true, MobileDelay = 420f },
      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(-3211.163f, 172.2292f, 3692.094f),
                       Rotation = Quaternion.Euler(1.4528f, 290.6434f,
                                                   356.8366f),
                       Allegiance = Faction.Red, DisplayName = "t55a 1 modded",
                       IsMobile = true, MobileDelay = 420f },
      new SpawnEntry { PrefabName = "T55A",
                       Position = new Vector3(-3313.133f, 172.7479f, 3753.325f),
                       Rotation = Quaternion.Euler(0.267f, 307.7811f,
                                                   357.2401f),
                       Allegiance = Faction.Red, DisplayName = "t55a 3 modded",
                       IsMobile = true, MobileDelay = 420f },

    };
  }
}

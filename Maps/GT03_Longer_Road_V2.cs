using GHPC;
using GHPC.Mission.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Hard_Mode
{
    public static class GT03_Longer_Road_V2
    {
        public static List<SpawnEntry> Spawns() => new List<SpawnEntry>
        {
                       new SpawnEntry
            {
                PrefabName = "T80B",
                Position = new Vector3(2549.444f, 87.1418f, -1459.15f),
                Rotation = Quaternion.Euler(359.0099f, 93.741f, 7.4799f),
                
                Allegiance = Faction.Red,
                DisplayName = "T-80B 1 Modded"
            },

        };
    }
}

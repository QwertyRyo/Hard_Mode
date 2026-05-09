using GHPC;
using GHPC.Mission.Data;
using UnityEngine;

namespace Hard_Mode
{
    public struct SpawnEntry
    {
        public string PrefabName;
        public Vector3 Position;
        public Quaternion Rotation;
        public Faction Allegiance;
        public string DisplayName;
        public bool IsMobile;     // if true, unit pursues the M1IP after MobileDelay seconds
        public float MobileDelay; // seconds after Planning phase ends before tracking begins
    }
}

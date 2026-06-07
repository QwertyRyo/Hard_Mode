using GHPC;
using GHPC.Effects.Voices;
using GHPC.Mission;
using GHPC.Mission.Data;
using GHPC.State;
using GHPC.Vehicle;
using Hard_Mode;
using HarmonyLib;
using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using GHPC.AI.Sensors;
using System.Reflection.Emit;
using GHPC.AI;
using GHPC.AI.Interfaces;
using GHPC.AI.Platoons;
using UnityEngine.Events;
using Pathfinding;
using GHPC.Crew;
using System.Linq.Expressions;

[assembly:MelonInfo(typeof(GMPC), "Hard Mode", "1.0.0", "Qwertyryo")]
[assembly:MelonGame("Radian Simulations LLC", "GHPC")]
/*available prefabs: M60A3TTS, T55A, T72M1, M2BRADLEY, M2BRADLEY(ALT), M901,
 * M113, M113G, M151M232, M151, BRDM2, UAZ469, STATIC_TOW, STATIC_9K111,
 * STATIC_SPG9, STATIC_SPG9_SA, T3485, TC, BMP1, URAL375D, M923, BMP2, LEO1A1,
 * LEO1A1A2, LEO1A1A3, LEO1A1A4, LEO1A3, LEO1A3A1, LEO1A3A2, LEO1A3A3, T62,
 * T64R, T64A74, T64A79, T64A81, T64A, T64A84, T64B, T64B81, T64B1, T64B181,
 * T72M, M60A1RISEP, M60A1RISEP77, M60A1, M60A1AOS, M60A3, M1, M1IP, T72GILLS,
 * T72UV1, T72UV2, T72ULEM, T72, SquadUnit_US_PASGT, SquadUnit_GDR, BMP1P,
 * BMP1P_SA, STATIC_9K111_SA, BMP1_SA, BMP2_SA, BRDM2_SA, BTR60PB, BTR60PB_SA,
 * URAL375D_SA, PT76B, T80B, T54A, BTR70, AH1, MI2, Mi8T, Mi24, Mi24V_SA, OH58A,
 * Mi24V_NVA, STATIC_SPG9_TRENCH, STATIC_SPG9_SA_TRENCH, STATIC_9K111_TRENCH,
 * STATIC_9K111_SA_TRENCH, STATIC_TOW_TRENCH, AH1_rockets, Mi24_rockets,
 * Mi24V_SA_rockets, Mi24V_NVA_rockets, RTS_CAMERA, MARDERA1, MARDERA1_NO_ATGM,
 * MARDERA1PLUS, MARDER1A2
 
 At the moment do NOT make mobile IFVs their atgm code breaks fix later
 1. custom stop feature? try to see how ingame code works in dnspy alter
 
 */
namespace Hard_Mode {


  public class GMPC : MelonMod {
    public static MelonPreferences_Entry<bool> CfgNoMobile;
    public static MelonPreferences_Entry<bool> CfgDisableSensorPatch;

    private static readonly Dictionary<string, Func<List<SpawnEntry>>>
        _sceneSpawns = new Dictionary<string, Func<List<SpawnEntry>>>() {
          { "GT03_abrams_alley", GT03_abrams_alley.Spawns },
          { "GT03_patton_pass", GT03_patton_pass.Spawns },
          { "GT03_Longer_Road_V2", GT03_Longer_Road_V2.Spawns},
          { "GT03_gunnery_duel", GT03_gunnery_duel.Spawns},
                    { "GT03_cheap_tricks", GT03_cheap_tricks.Spawns},

          { "GT03_Native_Narrative", GT03_Native_Narrative.Spawns},
          { "GT03_rolling_the_flank_UMC", GT03_rolling_the_flank_UMC.Spawns},
                    { "GT03_Momentous_Maniac_UMC", GT03_Momentous_Maniac_UMC.Spawns},
          { "GT03_destroy_in_place", GT03_destroy_in_place.Spawns},
          {"GT03_bounding_overwatch_UMC", GT03_bounding_overwatch_UMC.Spawns},
          {"GT03_prying_eyes", GT03_prying_eyes.Spawns}
,
          {"GT03_ruined_regiment", GT03_ruined_regiment.Spawns},
          {"GT03_Meditative_Malediction", GT03_Meditative_Malediction.Spawns},
                    {"GT03_Valley_of_Infantry_UMC", GT03_Valley_of_Infantry_UMC.Spawns},
                    {"GT03_Marketable_Mayham", GT03_Marketable_Mayham.Spawns},
                    {"GT03_late_to_the_party_UMC", GT03_late_to_the_party_UMC.Spawns},
                    {"GT03_Red_Steel", GT03_Red_Steel.Spawns},
                    {"GT03_PushingTin_FlankSecurity_UMC", GT03_PushingTin_FlankSecurity_UMC.Spawns},
        {"GT03_PushingTin_MainEffort_UMC", GT03_PushingTin_MainEffort_UMC.Spawns},
        {"GT03_Obscene_Odyssey_UMC", GT03_Obscene_Odyssey_UMC.Spawns},
        {"GT03_Savage_Scream_UMC", GT03_Savage_Scream_UMC.Spawns},
        {"GT03_Eastern_Scramble", GT03_Eastern_Scramble.Spawns}

        };

    public override void OnInitializeMelon() {
      MelonPreferences_Category cfg = MelonPreferences.CreateCategory("HardMode");
      CfgNoMobile = cfg.CreateEntry<bool>("DisableMobileSpawns", false, "Disable Mobile EnemySpawns");
      CfgNoMobile.Comment = "Disables enemy spawns that will track down nearest allied vehicles. Applies on game restart";
      CfgDisableSensorPatch = cfg.CreateEntry<bool>("DisableSensorPatch", false, "Disable AI having increased awareness");
      CfgDisableSensorPatch.Comment = "Disables the sensor patch that increases AI awareness. Applies on game restart";

      HarmonyInstance.PatchAll();

      
    }


public override void OnSceneWasLoaded(int buildIndex, string sceneName) {
      //LoggerInstance.Msg($"Loaded scene {sceneName}, trying to patch game...");

      //StateController.RunOrDefer(GameState.GameReady, new GameStateEventHandler(StartBlueLogger), GameStatePriority.Medium);

      if (!_sceneSpawns.TryGetValue(sceneName, out var getSpawns))
        return;

      _done = false;
      _pendingSpawns = getSpawns();
      if (CfgNoMobile.Value)
        _pendingSpawns = _pendingSpawns.Where(e => !e.IsMobile).ToList();
      StateController.RunOrDefer(GameState.GameReady,
                                 new GameStateEventHandler(OnGameReady),
                                 GameStatePriority.Medium);
    }

    [HarmonyPatch(typeof(TankTargetSensor),
                  nameof(TankTargetSensor.IsTargetVisible))]

    //Increases the range at which AI will detect targets. 
    public static class IsTargetVisiblePatch {
      [HarmonyTranspiler]
      static IEnumerable<CodeInstruction> Transpiler(
          IEnumerable<CodeInstruction> instructions) {
        if (CfgDisableSensorPatch?.Value == true)
          return instructions;

        var codes = new List<CodeInstruction>(instructions);

        for (int i = 0; i < codes.Count; i++) {
          if (codes[i].opcode == OpCodes.Ldc_R4 &&
              (float)codes[i].operand == 30f) {
            codes[i].operand = 180f;
          }
          //180 degrees both ways = 360 degree coverage

          //250000f (500m squared) -> 1000000f (1000m squared)
          if (codes[i].opcode == OpCodes.Ldc_R4 &&
              (float)codes[i].operand == 250000f) {
            codes[i].operand = 1000000f;
          }
        }

        return codes;
      }
    }

    private bool _done = false;
    private List<SpawnEntry> _pendingSpawns;

    private static readonly List<Vehicle> _vehicleCache = new List<Vehicle>();
    private static float _vehicleCacheTime = -1f;
    private const float VehicleCacheInterval = 8f;

    private static void RefreshVehicleCacheIfStale() {
        if (Time.time - _vehicleCacheTime < VehicleCacheInterval) return;
        _vehicleCacheTime = Time.time;
        _vehicleCache.Clear();
        _vehicleCache.AddRange(GameObject.FindObjectsByType<Vehicle>(FindObjectsSortMode.None));
    }

    private static bool IsValidUnit(Vehicle v) =>
        v.Neutralized == false && v.UnitIncapacitated == false && v.Abandoned == false;

    private Vehicle FindNearestEnemy(Vehicle tracker)
    {
        RefreshVehicleCacheIfStale();
        Faction enemyFaction = tracker.Allegiance == Faction.Red ? Faction.Blue : Faction.Red;
        Vehicle nearest = null;
        float nearestDist = float.MaxValue;
        MelonLogger.Msg($"findnearestenemy running, {tracker.transform.position}");
        foreach (var v in _vehicleCache)
        {
            if (v == null || v.Allegiance != enemyFaction || !IsValidUnit(v)) continue;
            float dist = Vector3.Distance(tracker.transform.position, v.transform.position);
            if (dist < nearestDist) { nearestDist = dist; nearest = v; }
        }
        return nearest;
    }

    private static Vector3 RandomPerimeter(Vector3 center) {
        Vector2 ring = UnityEngine.Random.insideUnitCircle.normalized * 5f;
        return center + new Vector3(ring.x, 0f, ring.y);
    }

    private static int _coroutineCounter = 0;

    private IEnumerator MobileSpawnTrackNearestEnemy(Vehicle targetVehicle, float delay)
    {
        int coroutineId = ++_coroutineCounter;
        float spawnTime = Time.time;
        MelonLogger.Msg($"[{coroutineId}] Coroutine started at Time.time={spawnTime:F1} for {targetVehicle.gameObject.name} delay={delay}");

        while (MissionStateController.CurrentState == MissionState.Planning)
            yield return null;

        float startTime = SceneController.MissionTime;
        while (SceneController.MissionTime - startTime < delay)
            yield return null;

        MelonLogger.Msg($"[{coroutineId}] Delay done at Time.time={Time.time:F1} (started at {spawnTime:F1}). Pos={targetVehicle.transform.position}");

        Vehicle target = FindNearestEnemy(targetVehicle);
        if (target == null)
        {
            MelonLogger.Msg($"[{coroutineId}] No valid enemy found for {targetVehicle.gameObject.name}.");
            yield break;
        }

        DriverAIController aiController = targetVehicle.GetComponent<DriverAIController>();
        if (aiController == null)
        {
            MelonLogger.Msg($"[{coroutineId}] No DriverAIController on {targetVehicle.gameObject.name}.");
            yield break;
        }

        GameObject waypointGo = new GameObject($"DynamicWaypoint_{targetVehicle.gameObject.name}");
        waypointGo.transform.position = RandomPerimeter(target.transform.position);
        TransformWaypoint waypoint = waypointGo.AddComponent<TransformWaypoint>();

        waypoint.MaxSpeed = -1f;
        waypoint.CompletionRadius = 2f;
        waypoint.AvoidObstacles = true;
        waypoint.FollowMode = WaypointHolder.FollowModes.Automatic;

        MelonLogger.Msg($"[{coroutineId}] Pre-SetupDriverController pos={targetVehicle.transform.position}");
        try { aiController.SetupDriverController(); }
        catch (Exception ex)
        {
            MelonLogger.Error($"[{coroutineId}] SetupDriverController threw: {ex}");
            yield break;
        }
        MelonLogger.Msg($"[{coroutineId}] Post-SetupDriverController pos={targetVehicle.transform.position}");

        aiController.TargetSpeed = 45f;

        MelonLogger.Msg($"[{coroutineId}] Pre-StartDriveToWaypoint waypoint pos={waypointGo.transform.position}");
        var nn = AstarPath.active?.GetNearest(targetVehicle.transform.position);
        MelonLogger.Msg($"[{coroutineId}] Nearest navmesh node to vehicle: {nn?.position} dist={nn?.distance}");
        var nn2 = AstarPath.active?.GetNearest(waypointGo.transform.position);
        MelonLogger.Msg($"[{coroutineId}] Nearest navmesh node to waypoint: {nn2?.position} dist={nn2?.distance}");
        try { aiController.StartDriveToWaypoint(waypoint); }
        catch (Exception ex)
        {
            MelonLogger.Error($"[{coroutineId}] StartDriveToWaypoint threw: {ex}");
            yield break;
        }
        MelonLogger.Msg($"[{coroutineId}] Post-StartDriveToWaypoint pos={targetVehicle.transform.position}");

        MelonLogger.Msg($"[{coroutineId}] {targetVehicle.gameObject.name} now tracking nearest enemy.");

        while (aiController != null && waypoint != null && targetVehicle != null && IsValidUnit(targetVehicle))
        {
          bool loopcond3 = targetVehicle != null;
          MelonLogger.Msg($"{loopcond3}");
            target = FindNearestEnemy(targetVehicle);
            //MelonLogger.Msg($" MobileSpawn {targetVehicle.gameObject.name} is finding nearest enemy.");
            if (target == null) {
              MelonLogger.Msg($"MobileSpawn {targetVehicle.gameObject.name} cannot find nearest enemy during tracking.");

              break;}
            waypoint.Position = RandomPerimeter(target.transform.position);



            yield return new WaitForSeconds(6f);
       
        }
        MelonLogger.Msg($"230 loop ended");


        if (waypoint != null) GameObject.Destroy(waypoint.gameObject);
    }



    private IEnumerator StartBlueLogger(GameState _)
    {
        MelonCoroutines.Start(LogBlueVehiclePositions());
        yield break;
    }

    private IEnumerator LogBlueVehiclePositions()
    {
        //MelonLogger.Msg("Logger started");
        while (true)
        {
            foreach (var v in GameObject.FindObjectsByType<Vehicle>(FindObjectsSortMode.None))
            {
                if (v.Allegiance == Faction.Blue && v.Neutralized == false && v.UnitIncapacitated == false && v.Abandoned == false){
                
                
                //MelonLogger.Msg($"[BluePos] {v.gameObject.name}: {v.transform.position}");
                }
            }
            yield return new WaitForSeconds(10f);
        }
    }
    private IEnumerator LogRedVehiclePositions()
    {
        //MelonLogger.Msg("Red Logger started");
        while (true)
        {
            foreach (var v in GameObject.FindObjectsByType<Vehicle>(FindObjectsSortMode.None))
            {
                if (v.Allegiance == Faction.Red && ((v.Neutralized == false && v.UnitIncapacitated == false) && v.Abandoned == false))
                {
                //MelonLogger.Msg($"[RedPos] {v.gameObject.name}: {v.transform.position}");
              }
            }
            yield return new WaitForSeconds(5f);
        }
    }

    private IEnumerator OnGameReady(GameState _) {
      if (_done)
        yield break;
      _done = true;

      var lookup = UnitSpawner.Instance.PrefabLookup;

      foreach (var entry in _pendingSpawns) {
        var meta =
            lookup.AllUnits.FirstOrDefault(u => u.Name == entry.PrefabName);

        if (meta == null) {
          LoggerInstance.Msg($"{entry.PrefabName} not found in unit lookup");
          continue;
        }

        // resolve the prefab
        GameObject prefab = null;
        if (meta.PrefabReference.Asset != null) {
          // LoggerInstance.Msg("null asset else NOT ran");
          prefab = meta.PrefabReference.Asset as GameObject;
        } else {
          // LoggerInstance.Msg("null asset else ran");
          var handle = meta.PrefabReference.LoadAssetAsync<GameObject>();
          yield return handle;
          prefab = handle.Result;
        }

        if (prefab == null) {
          LoggerInstance.Msg($"{entry.PrefabName} prefab failed to load");
          continue;
        }

        var unit = UnitSpawner.Instance.SpawnUnit(prefab, new UnitMetaData() {
          Allegiance = entry.Allegiance, Position = entry.Position,
          Rotation = entry.Rotation, Name = entry.DisplayName
        });

        if (unit == null) {
          LoggerInstance.Error($"Failed to spawn {entry.DisplayName}");
          continue;
        }

        unit.Targetable = true;
        //LoggerInstance.Msg($"{entry.DisplayName} spawned successfully");

        if (entry.IsMobile) {
          if (unit is Vehicle vehicle)
            MelonCoroutines.Start(MobileSpawnTrackNearestEnemy(vehicle, entry.MobileDelay));
          else
            LoggerInstance.Error($"MobileSpawn: {entry.DisplayName} could not be cast to Vehicle.");
        }
        else
        {
          LoggerInstance.Error($"entry.IsMobile returned false");
        }
      }

      yield break;
    }
  }
}

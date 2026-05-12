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
          { "GT03_Native_Narrative", GT03_Native_Narrative.Spawns},

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
      LoggerInstance.Msg($"Loaded scene {sceneName}, trying to patch game...");

      StateController.RunOrDefer(GameState.GameReady,
                                 new GameStateEventHandler(StartBlueLogger),
                                 GameStatePriority.Medium);

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

    
    private static bool IsValidUnit(Vehicle v) =>
        v.Neutralized == false && v.UnitIncapacitated == false && v.Abandoned == false;

    private Vehicle FindNearestEnemy(Vehicle tracker)
    {
        Faction enemyFaction = tracker.Allegiance == Faction.Red ? Faction.Blue : Faction.Red;
        Vehicle nearest = null;
        float nearestDist = float.MaxValue;
        foreach (var v in GameObject.FindObjectsByType<Vehicle>(FindObjectsSortMode.None))
        {
            if (v.Allegiance != enemyFaction || !IsValidUnit(v)) continue;
            float dist = Vector3.Distance(tracker.transform.position, v.transform.position);
            if (dist < nearestDist) { nearestDist = dist; nearest = v; }
        }
        return nearest;
    }

    private IEnumerator MobileSpawnTrackNearestEnemy(Vehicle targetVehicle, float delay)
    {
        while (MissionStateController.CurrentState == MissionState.Planning)
            yield return null;

        float startTime = SceneController.MissionTime;
        while (SceneController.MissionTime - startTime < delay)
            yield return null;

        MelonLogger.Msg($"MobileSpawn: {targetVehicle.gameObject.name} activating after {delay}s delay.");

        Vehicle target = FindNearestEnemy(targetVehicle);
        if (target == null)
        {
            MelonLogger.Msg($"MobileSpawn: No valid enemy found for {targetVehicle.gameObject.name}.");
            yield break;
        }

        DriverAIController aiController = targetVehicle.GetComponent<DriverAIController>();
        if (aiController == null)
        {
            MelonLogger.Msg($"MobileSpawn: No DriverAIController on {targetVehicle.gameObject.name}.");
            yield break;
        }

        GameObject waypointGo = new GameObject($"DynamicWaypoint_{targetVehicle.gameObject.name}");
        waypointGo.transform.position = target.transform.position;
        TransformWaypoint waypoint = waypointGo.AddComponent<TransformWaypoint>();

        waypoint.MaxSpeed = -1f;
        waypoint.CompletionRadius = 2f;
        waypoint.AvoidObstacles = true;
        waypoint.FollowMode = WaypointHolder.FollowModes.Automatic;

        try { aiController.SetupDriverController(); }
        catch (Exception ex)
        {
            MelonLogger.Error($"MobileSpawn SetupDriverController threw: {ex}");
            yield break;
        }

        aiController.TargetSpeed = 50f;

        try { aiController.StartDriveToWaypoint(waypoint); }
        catch (Exception ex)
        {
            MelonLogger.Error($"MobileSpawn StartDriveToWaypoint threw: {ex}");
            yield break;
        }

        MelonLogger.Msg($"MobileSpawn: {targetVehicle.gameObject.name} now tracking nearest enemy.");

        while (aiController != null && waypoint != null)
        {
            target = FindNearestEnemy(targetVehicle);
            if (target == null) {
              MelonLogger.Msg($"MobileSpawn {targetVehicle.gameObject.name} cannot find nearest enemy during tracking.");
              break;}
            waypoint.Position = target.transform.position;
            MelonLogger.Msg($"{targetVehicle.gameObject.name}  MobileSpawn: Updated waypoint position to nearest enemy at " + waypoint.Position);
            yield return new WaitForSeconds(5f);
        }

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
                if (v.Allegiance == Faction.Blue && ((v.Neutralized == false && v.UnitIncapacitated == false) && v.Abandoned == false)){
                
                
                //MelonLogger.Msg($"[BluePos] {v.gameObject.name}: {v.transform.position}");
                }
            }
            yield return new WaitForSeconds(5f);
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
      }

      yield break;
    }
  }
}

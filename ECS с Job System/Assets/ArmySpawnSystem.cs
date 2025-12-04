using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public partial struct ArmySpawnSystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        state.RequireForUpdate<ArmySpawnConfigComponent>();
    }

    public void OnUpdate(ref SystemState state)
    {
        var cfgEntity = SystemAPI.GetSingletonEntity<ArmySpawnConfigComponent>();
        var cfg = SystemAPI.GetComponent<ArmySpawnConfigComponent>(cfgEntity);

        if (!cfg.NeedSpawn) return;

        cfg.NeedSpawn = false;
        state.EntityManager.SetComponentData(cfgEntity, cfg);

        // получаем prefab
        Entity prefab = cfg.Prefab;

        for (int x = 0; x < cfg.CountX; x++)
            for (int y = 0; y < cfg.CountY; y++)
            {
                float3 pos = new float3(x * cfg.Spacing, 0, y * cfg.Spacing);

                Entity e = state.EntityManager.Instantiate(prefab);

                state.EntityManager.SetComponentData(e, LocalTransform.FromPosition(pos));
                state.EntityManager.SetComponentData(e, new PivotPosition { Value = pos });
                state.EntityManager.SetComponentData(e, new MoveSpeed { Value = cfg.MoveSpeed });
                state.EntityManager.SetComponentData(e, new Radius { Value = cfg.Radius });
            }
    }
}

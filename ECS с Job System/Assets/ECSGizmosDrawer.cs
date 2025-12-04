using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Collections;
using Unity.Mathematics;

public class ECSGizmosDrawer : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;

        var em = World.DefaultGameObjectInjectionWorld.EntityManager;
        var query = em.CreateEntityQuery(typeof(LocalTransform), typeof(PivotPosition));

        var count = query.CalculateEntityCount();
        if (count == 0) return;

        var cfg = em.CreateEntityQuery(typeof(ArmySpawnConfigComponent))
                    .GetSingleton<ArmySpawnConfigComponent>();

        int sample = math.min(cfg.GizmoSample, count);

        NativeArray<Entity> entities = query.ToEntityArray(Allocator.Temp);
        NativeArray<LocalTransform> transforms = query.ToComponentDataArray<LocalTransform>(Allocator.Temp);

        Gizmos.color = Color.yellow;

        for (int i = 0; i < sample; i++)
        {
            Gizmos.DrawSphere(transforms[i].Position, 0.1f);
        }

        entities.Dispose();
        transforms.Dispose();
    }
}

using Unity.Entities;
using UnityEngine;

public class ArmyConfigAuthoring : MonoBehaviour
{
    public ArmySpawnConfig config;

    class Baker : Baker<ArmyConfigAuthoring>
    {
        public override void Bake(ArmyConfigAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.None);
            var prefabEntity = GetEntity(authoring.config.prefab, TransformUsageFlags.Dynamic);

            AddComponent(entity, new ArmySpawnConfigComponent
            {
                Prefab = prefabEntity,
                CountX = authoring.config.countX,
                CountY = authoring.config.countY,
                Spacing = authoring.config.spacing,
                MoveSpeed = authoring.config.moveSpeed,
                Radius = authoring.config.radius,
                GizmoSample = authoring.config.gizmoSample,
                NeedSpawn = true
            });
        }
    }
}

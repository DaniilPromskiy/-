using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class CircleMoverAuthoring : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float radius = 2f;

    class Baker : Baker<CircleMoverAuthoring>
    {
        public override void Bake(CircleMoverAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);

            AddComponent(entity, new MoveSpeed { Value = authoring.moveSpeed });
            AddComponent(entity, new Radius { Value = authoring.radius });

           AddComponent(entity, new PivotPosition { Value = float3.zero });
        }
    }
}

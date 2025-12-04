using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial struct CircleMovementSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        float t = (float)SystemAPI.Time.ElapsedTime;

        new CircleJob
        {
            Time = t
        }.ScheduleParallel();
    }
}

public partial struct CircleJob : IJobEntity
{
    public float Time;

    private void Execute(ref LocalTransform transform,
                         in MoveSpeed speed,
                         in Radius radius,
                         in PivotPosition pivot)
    {
        float angle = Time * speed.Value;
        float x = math.cos(angle) * radius.Value;
        float z = math.sin(angle) * radius.Value;

        transform.Position = pivot.Value + new float3(x, 0, z);
    }
}

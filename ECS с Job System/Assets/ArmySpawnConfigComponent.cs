using Unity.Entities;

public struct ArmySpawnConfigComponent : IComponentData
{
    public Entity Prefab;
    public int CountX;
    public int CountY;
    public float Spacing;

    public float MoveSpeed;
    public float Radius;

    public int GizmoSample;

    public bool NeedSpawn;   
}

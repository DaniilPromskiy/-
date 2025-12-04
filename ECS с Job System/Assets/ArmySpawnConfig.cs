using UnityEngine;

[CreateAssetMenu(menuName = "Configs/ArmySpawnConfig")]
public class ArmySpawnConfig : ScriptableObject
{
    public GameObject prefab;
    public int countX = 200;
    public int countY = 250;
    public float spacing = 2f;

    public float moveSpeed = 1f;
    public float radius = 2f;

    public int gizmoSample = 500;  
}

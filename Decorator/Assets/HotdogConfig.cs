using UnityEngine;

[CreateAssetMenu(fileName = "HotdogConfig", menuName = "Hotdogs/Hotdog Base")]
public class HotdogConfig : ScriptableObject
{
    public string hotdogName;
    public int cost;
    public int weight;
}

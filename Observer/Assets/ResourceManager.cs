using UnityEngine;

[CreateAssetMenu(menuName = "Game/Resource Manager")]
public class ResourceManager : ScriptableObject
{
    public int wood;
    public int stone;
    public int gold;

    public int Get(ResourceType type)
    {
        return type switch
        {
            ResourceType.Wood => wood,
            ResourceType.Stone => stone,
            ResourceType.Gold => gold,
            _ => 0
        };
    }

    public void Set(ResourceType type, int value)
    {
        switch (type)
        {
            case ResourceType.Wood: wood = value; break;
            case ResourceType.Stone: stone = value; break;
            case ResourceType.Gold: gold = value; break;
        }
    }
}

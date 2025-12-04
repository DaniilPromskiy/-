using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public ResourceManager rm;
    public Transform itemsParent;
    public GameObject itemPrefab;

    private void OnEnable()
    {
        Refresh();
    }

    public void Refresh()
    {
        foreach (Transform child in itemsParent)
            Destroy(child.gameObject);

        foreach (ResourceType type in System.Enum.GetValues(typeof(ResourceType)))
        {
            var item = Instantiate(itemPrefab, itemsParent)
                       .GetComponent<ResourceItemUI>();

            item.Set(type.ToString(), rm.Get(type));
        }
    }

    public void ResetAll()
    {
        foreach (ResourceType t in System.Enum.GetValues(typeof(ResourceType)))
            rm.Set(t, 0);

        Refresh();
        GameEvents.ResetEvent.Raise();
    }
}

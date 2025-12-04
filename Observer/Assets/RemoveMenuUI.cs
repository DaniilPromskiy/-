using UnityEngine;
using UnityEngine.UI;

public class RemoveMenuUI : MonoBehaviour
{
    public ResourceManager rm;

    public Dropdown dropdown;
    public InputField input;

    private void OnEnable()
    {
        PopulateDropdown();
        ResetFields();
    }

    void PopulateDropdown()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(
            new System.Collections.Generic.List<string>(
                System.Enum.GetNames(typeof(ResourceType))
            ));
    }

    void ResetFields()
    {
        dropdown.value = 0;
        input.text = "";
    }

    public void Remove()
    {
        ResourceType type = (ResourceType)dropdown.value;

        if (!int.TryParse(input.text, out int value))
            return;

        int current = rm.Get(type);
        int newVal = Mathf.Max(0, current - value);
        rm.Set(type, newVal);

        GameEvents.RemoveEvent.Raise();

        ResetFields();
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ResourceItemUI : MonoBehaviour
{
    public Text nameText;
    public Text valueText;

    public void Set(string name, int value)
    {
        nameText.text = name;
        valueText.text = value.ToString();
    }
}

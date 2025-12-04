using UnityEngine;

[CreateAssetMenu(fileName = "IngredientConfig", menuName = "Hotdogs/Ingredient")]
public class IngredientConfig : ScriptableObject
{
    public string ingredientNamePostfix;
    public int extraCost;
    public int extraWeight;
}

using UnityEngine;

public class HotdogDebugSO : MonoBehaviour
{
    public HotdogConfig classic;
    public IngredientConfig pickles;
    public IngredientConfig sweetOnion;

    private void Start()
    {
        Hotdog baseDog = new BaseHotdogSO(classic);
        Hotdog withPickles = new IngredientsDecoratorSO(baseDog, pickles);
        Hotdog withOnion = new IngredientsDecoratorSO(new BaseHotdogSO(classic), sweetOnion);

        Debug.Log($"{baseDog.GetName()} ({baseDog.GetWeight()}г) Ч {baseDog.GetCost()}р.\n" +
                  $"ƒополнительна€ информаци€:\n" +
                  $"{withPickles.GetName()} ({withPickles.GetWeight()}г) Ч {withPickles.GetCost()}р.\n" +
                  $"{withOnion.GetName()} ({withOnion.GetWeight()}г) Ч {withOnion.GetCost()}р.");
    }
}

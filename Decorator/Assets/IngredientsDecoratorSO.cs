public class IngredientsDecoratorSO : HotdogDecorator
{
    private IngredientConfig ingredient;

    public IngredientsDecoratorSO(Hotdog hotdog, IngredientConfig ingredient)
        : base(hotdog, ingredient.ingredientNamePostfix)
    {
        this.ingredient = ingredient;
    }

    public override int GetCost() => wrapped.GetCost() + ingredient.extraCost;
    public override int GetWeight() => wrapped.GetWeight() + ingredient.extraWeight;
}

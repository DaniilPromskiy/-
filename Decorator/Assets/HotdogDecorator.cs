public abstract class HotdogDecorator : Hotdog
{
    protected Hotdog wrapped;

    protected HotdogDecorator(Hotdog hotdog, string ingredientName)
        : base($"{hotdog.GetName()} {ingredientName}")
    {
        wrapped = hotdog;
    }
}

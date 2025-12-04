public class SweetOnionDecorator : HotdogDecorator
{
    public SweetOnionDecorator(Hotdog hotdog)
        : base(hotdog, "с сладким луком") { }

    public override int GetCost() => wrapped.GetCost() + 30;
    public override int GetWeight() => wrapped.GetWeight() + 10;
}

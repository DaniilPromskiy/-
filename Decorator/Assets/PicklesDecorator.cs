public class PicklesDecorator : HotdogDecorator
{
    public PicklesDecorator(Hotdog hotdog)
        : base(hotdog, "с маринованными огурцами") { }

    public override int GetCost() => wrapped.GetCost() + 50;
    public override int GetWeight() => wrapped.GetWeight() + 20;
}

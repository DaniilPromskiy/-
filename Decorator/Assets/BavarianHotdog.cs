public class BavarianHotdog : Hotdog
{
    public BavarianHotdog() : base("Хот-дог Баварский") { }

    public override int GetCost() => 260;
    public override int GetWeight() => 180;
}

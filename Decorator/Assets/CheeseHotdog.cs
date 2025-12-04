public class CheeseHotdog : Hotdog
{
    public CheeseHotdog() : base("’от-дог сырный") { }

    public override int GetCost() => 230;
    public override int GetWeight() => 160;
}

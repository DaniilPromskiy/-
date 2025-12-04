public abstract class Hotdog
{
    protected string name;

    protected Hotdog(string name)
    {
        this.name = name;
    }

    public virtual string GetName() => name;
    public abstract int GetCost();
    public abstract int GetWeight();   
}

namespace _12_06_24;

public class BaseTypesOfFish { };

public class Herring : BaseTypesOfFish
{
    private int weigh { get; set; }
    private int maxAge { get; set; }

    public Herring(int weigh, int maxAge)
    {
        this.weigh = weigh;
        this.maxAge = maxAge;
    }

    public override string ToString()
    {
        return $"Herring: Weight: {weigh}, Maximum age: {maxAge}";
    }
}
public class Shrimps : BaseTypesOfFish
{
    private int weigh { get; set; }
    private int maxAge { get; set; }

    public Shrimps(int weigh, int maxAge)
    {
        this.weigh = weigh;
        this.maxAge = maxAge;
    }
    
    public override string ToString()
    {
        return $"Shrimps: Weight: {weigh}, Maximum age: {maxAge}";
    }
}
public class Jellyfish : BaseTypesOfFish
{
    private int weigh { get; set; }
    private int maxAge { get; set; }

    public Jellyfish(int weigh, int maxAge)
    {
        this.weigh = weigh;
        this.maxAge = maxAge;
    }
    
    public override string ToString()
    {
        return $"JellyFish: Weight: {weigh}, Maximum age: {maxAge}";
    }
}

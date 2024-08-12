namespace _10_07_24;

public class Elephant : Herbivore
{
    public Elephant(string continent) 
        : base("Elephant", continent)
    {
    }
}

public class Lion : Carnivore
{
    public Lion(string continent) : base("Lion", continent)
    {
    }

    public override void Eat(Herbivore herbivore)
    {
        Console.WriteLine($"{Name} поедает {herbivore.Name} на континенте {Continent}.");
    }
}
namespace _10_07_24;


using System;
using System.Collections.Generic;

public abstract class Animal
{
    public string Name { get; set; }
    public string Continent { get; set; }

    protected Animal(string name, string continent)
    {
        Name = name;
        Continent = continent;
    }
    
    public abstract void MakeSound();

    public override string ToString()
    {
        return $"{Name} from {Continent}";
    }
}

public abstract class Herbivore : Animal
{
    protected Herbivore(string name, string continent) : base(name, continent)
    {
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} ест траву на континенте {Continent}.");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} издает звуки травоядного."); // как бы странно это не звучало, абстракция же))
    }
}

public abstract class Carnivore : Animal
{
    protected Carnivore(string name, string continent) : base(name, continent)
    {
    }

    public abstract void Eat(Herbivore herbivore);

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} издаёт звуки хищника.");
    }
}

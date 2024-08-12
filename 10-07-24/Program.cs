namespace _10_07_24;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Elephant("Africa"),
            new Lion("Africa"),
            new Elephant("Asia"),
            new Lion("Asia")
        };

        // foreach (var animal in animals)
        // {
        //     Console.WriteLine(animal);
        //     animal.MakeSound();
        // }
        
        Herbivore elephant = new Elephant("Africa");
        Carnivore lion = new Lion("Africa");

        elephant.Eat(); // cлон ест траву
        lion.Eat(elephant); // лев поедает слона

        elephant.MakeSound(); // звук слона
        lion.MakeSound(); // рык льва
    }
}
namespace _03_07_24;

class Program
{
    static void Main(string[] args)
    {
        var devices1 = new List<Device>
        {
            new Device("Phone A", "Manufacturer1", 1000),
            new Device("Phone B", "Manufacturer2", 1200),
            new Device("Phone C", "Manufacturer3", 1500)
        };

        var devices2 = new List<Device>
        {
            new Device("Phone D", "Manufacturer2", 1300),
            new Device("Phone E", "Manufacturer4", 1100),
            new Device("Phone F", "Manufacturer3", 1400)
        };

        var difference = devices1.Except(devices2);

        var intersection = devices1.Intersect(devices2);

        var union = devices1.Union(devices2);

        Console.WriteLine("Difference (devices in devices1 but not in devices2):");
        foreach (var device in difference)
        {
            Console.WriteLine(device);
        }
        
        Console.WriteLine("\nIntersection (devices in both devices1 and devices2):");
        foreach (var device in intersection)
        {
            Console.WriteLine(device);
        }

        Console.WriteLine("\nUnion (all unique devices from both devices1 and devices2):");
        foreach (var device in union)
        {
            Console.WriteLine(device);
        }
    }
}
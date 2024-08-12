namespace _03_07_24;

public class Device
{
    public string Name { get; set; }
    public string Manufacturer { get; set; } // для удобного сравнения
    public decimal Cost { get; set; }

    public Device(string name, string manufacturer, decimal cost)
    {
        Name = name;
        Manufacturer = manufacturer;
        Cost = cost;
    }

    public override bool Equals(object obj)
    {
        if (obj is Device device)
        {
            return this.Manufacturer == device.Manufacturer;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Manufacturer.GetHashCode();
    }

    public override string ToString()
    {
        return $"Name: {Name}, Manufacturer: {Manufacturer}, Cost: {Cost}";
    }
}
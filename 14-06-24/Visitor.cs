using _14_06_24;

public class Visitor
{
    public string Name { get; init; }
    public Table? ReservedTableNumber { get; set; }
    public DateTime ReservedTime { get; set; }

    public Visitor(string name)
    {
        Name = name;
    }
}
public class Table
{
    public int Id { get; private set; }
    public DateTime? ReservedTime { get; set; }

    public Table(int id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Table table)
        {
            return Id == table.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
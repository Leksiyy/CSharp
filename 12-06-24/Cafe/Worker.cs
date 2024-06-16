namespace _12_06_24.Cafe;

public class Worker(int salary, string name)
{
    private int Salary = salary;
    private string Name = name;

    public override string ToString()
    {
        return $"Salary: {Salary}, Name: {Name}";
    }
}
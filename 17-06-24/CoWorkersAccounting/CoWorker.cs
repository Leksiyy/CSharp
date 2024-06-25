namespace _17_06_24;

public class CoWorker(string fullName, string position, uint salary, string corporateEMail)
{
    public string FullName { get; set; } = fullName;
    public string Position { get; set; } = position;
    public double Salary { get; set; } = salary;
    public string CorporateEMail { get; set; } = corporateEMail;
    
    public override string ToString()
    {
        return $"FullName: {FullName}, Position: {Position}, Salary: {Salary}, Corporate EMail: {CorporateEMail}";
    }
}
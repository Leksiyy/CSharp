namespace _24_06_24;

public record PersonRecord(string name, string surname, int age)
{
    public string Name = name;
    public string Surname = surname;
    public int Age = age;
}

public static class PersonRecordExtension
{
    public static double MaxAge(this List<PersonRecord> nums)
    {
        double result = -1;
        foreach (PersonRecord record in nums)
        {
            if (record.Age > result) result = record.Age;
        }

        return result;
    }
    
    public static double MinAge(this List<PersonRecord> nums)
    {
        double result = double.MaxValue;
        foreach (PersonRecord record in nums)
        {
            if (record.Age < result) result = record.Age;
        }

        return result;
    }
    
    public static double AvarageAge(this List<PersonRecord> nums)
    {
        double result = 0;
        foreach (PersonRecord record in nums)
        {
            result += record.Age;
        }

        return result / nums.Count;
    }
}
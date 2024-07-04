namespace _24_06_24;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(5.IsEven() ? "That number is even" : "That number isn't even");
        Console.WriteLine(6.IsEven() ? "That number is even" : "That number isn't even");

        PersonRecord personRecord1 = new PersonRecord("Lina", "Hovarsky", 22);
        PersonRecord personRecord2 = new PersonRecord("Nolan", "Workship", 26);
        PersonRecord personRecord3 = new PersonRecord("Mona", "Apelsinsky", 34);

        List<PersonRecord> PersonList = new List<PersonRecord>();

        PersonList.Add(personRecord1);
        PersonList.Add(personRecord2);
        PersonList.Add(personRecord3);
        
        Console.WriteLine("MaxAge extension method: " + PersonList.MaxAge() + "\nMinAge extension method: " + PersonList.MinAge() + "\nAvarageAge extension method: " + PersonList.AvarageAge());

        List<Point3DRecord> JustList = new List<Point3DRecord>();
        
        Point3DRecord point1 = new Point3DRecord(4, 6, 9);
        Point3DRecord point2 = new Point3DRecord(2, 57, 8);
        Point3DRecord point3 = new Point3DRecord(3, 4, 8);
        Point3DRecord point4 = new Point3DRecord(4, 12, 4);
        
        JustList.Add(point1);
        JustList.Add(point2);
        JustList.Add(point3);
        JustList.Add(point4);

        List<Point3DRecord>? result = JustList.MaxDistance();
        
        Console.WriteLine("Distance is: " + point1.Distance(point2));
        Console.WriteLine("Maximum distance in array is between " + result[0].ToString() + " and " + result[1].ToString());
    }   
}
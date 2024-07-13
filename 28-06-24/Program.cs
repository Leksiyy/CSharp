namespace _28_06_24;

class Program
{
    static void Main(string[] args)
    {
        IpWho ipWho = new IpWho();
        ipWho.DoRequest("8.8.4.4"); // пустое поле = посмортеть свой айпи
        Console.Read();
    }
}
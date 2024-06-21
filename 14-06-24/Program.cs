namespace _14_06_24;

class Program
{
    static void Main(string[] args)
    {
        PopularCafe cafe = new PopularCafe(5);

        Visitor visitor1 = new Visitor("Саня");
        Visitor visitor2 = new Visitor("Богданчик");
        Visitor visitor3 = new Visitor("Виктория");
        Visitor visitor4 = new Visitor("Мишаня");
        Visitor visitor5 = new Visitor("Влядик");
        Visitor visitor6 = new Visitor("Мария");

        cafe.AddVisitorToQueue(visitor1);
        cafe.AddVisitorToQueue(visitor2);
        cafe.AddVisitorToQueue(visitor3);
        cafe.AddVisitorToQueue(visitor4);
        cafe.AddVisitorToQueue(visitor5);
        cafe.AddVisitorToQueue(visitor6);

        cafe.SeatVisitor();
        
        Table tableToFree = new Table(3);
        bool freed = cafe.FreeUpTheTable(tableToFree);
        Console.WriteLine(freed ? "Столик успешно освобожден." : "Не удалось освободить столик.");
            
        bool reserved = cafe.ReserveTable(visitor6, DateTime.Now.AddMinutes(30), 3);
        Console.WriteLine(reserved ? "Столик успешно зарезервирован." : "Не удалось зарезервировать столик.");
        
        bool tookReservedTable = cafe.TakeReservedTable(visitor6, DateTime.Now.AddMinutes(30));
        Console.WriteLine(tookReservedTable ? "Посетитель занял зарезервированный столик." : "Не удалось занять зарезервированный столик.");

        bool removedReserve = cafe.RemoveReserv(visitor6);
        Console.WriteLine(removedReserve ? "Резерв успешно снят." : "Не удалось снять резерв.");
    }
}
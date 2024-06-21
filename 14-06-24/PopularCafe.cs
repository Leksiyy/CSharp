namespace _14_06_24;

public class PopularCafe
{
    private Queue<Visitor> _queue = new Queue<Visitor>();
    private Dictionary<Table, Visitor?> _tables = new Dictionary<Table, Visitor?>();
    private ushort TableQuantity; // удалить не забудь
    
    public PopularCafe(ushort tableQuantity)
    {
        for (ushort i = 1; i <= tableQuantity; i++)
        {
            _tables.Add(new Table(i), null);
        }

        this.TableQuantity = tableQuantity; // тут тоже
    }

    public Table? FindFreeTable()
    {
        foreach (var table in _tables.Keys)
        {
            if (_tables[table] == null)
            {
                return table;
            }
        }

        return null;
    }

    public void AddVisitorToQueue(Visitor visitor)
    {
        _queue.Enqueue(visitor);
    }

    // метод чтобы двигать очередь пока есть свободные столики.
    public void SeatVisitor()
    {
        while (FindFreeTable() != null && _queue.Count > 0)
        {
            Visitor nextVisitor = _queue.Dequeue();
            Table? table = FindFreeTable();

            _tables[table] = nextVisitor;
            Console.WriteLine($"Посетитель {nextVisitor.Name} занял столик {table.Id}.");
        }

        if (_queue.Count == 0)
        {
            Console.WriteLine("Очередь пуста.");
            return;
        }

        Console.WriteLine("Свободные столики закончились или очередь пуста.");
        return;
    }
    
    // есть возможность зарезервировать любой свободный столик,
    // если он будет занят будет зарезервирован столик согласно методу FindFreeTable
    public bool ReserveTable(Visitor visitor, DateTime time, ushort tableNumber = UInt16.MaxValue)
    {
        if (tableNumber <= _tables.Count)
        {
            Table tableToReserve = new Table(tableNumber);

            if (_tables.TryGetValue(tableToReserve, out Visitor? currentVisitor) && currentVisitor == null)
            {
                _tables[tableToReserve] = visitor;
                visitor.ReservedTableNumber = tableToReserve;
                visitor.ReservedTime = time;
                tableToReserve.ReservedTime = time;
                return true;
            }
        }

        Table? freeTable = FindFreeTable();

        if (freeTable != null)
        {
            _tables[freeTable] = visitor;
            visitor.ReservedTableNumber = freeTable;
            visitor.ReservedTime = time;
            freeTable.ReservedTime = time;

            Console.WriteLine(
                $"Столик, который выбрал посетитель, не существует, поэтому ему был предложен столик {freeTable.Id}.");
            return true;
        }

        return false;
    }

    public bool FreeUpTheTable(Table table)
    {
        if (_tables[table] != null)
        {
            _tables[table] = null;
            return true;
        }
        
        return false;
    }

    public bool RemoveReserv(Visitor visitor)
    {
        if (visitor.ReservedTableNumber != null)
        {
            Table? reservedTable = visitor.ReservedTableNumber;
            visitor.ReservedTableNumber = null;

            if (reservedTable != null)
            {
                _tables[reservedTable] = null;
                return true;
            }
        }

        return false;
    }
    
    public bool TakeReservedTable(Visitor visitor, DateTime currentTime)
    {
        if (visitor.ReservedTableNumber == null)
        {
            Console.WriteLine("У посетителя нет зарезервированного столика.");
            return false;
        }

        Table reservedTable = visitor.ReservedTableNumber;

        if (currentTime >= visitor.ReservedTime && _tables[reservedTable] == visitor)
        {
            _tables[reservedTable] = visitor;
            Console.WriteLine($"Посетитель {visitor.Name} занял свой зарезервированный столик {reservedTable.Id}.");
            return true;
        }
        else if (_tables[reservedTable] == null)
        {
            _tables[reservedTable] = visitor;
            Console.WriteLine($"Посетитель {visitor.Name} занял свой зарезервированный столик {reservedTable.Id}.");
            return true;
        }

        Console.WriteLine("Посетитель опоздал, столик занят другим посетителем.");
        return false;
    }
}

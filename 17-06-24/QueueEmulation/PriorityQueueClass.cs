namespace _17_06_24.QueueEmulation;

public class PriorityQueueClass
{
    //пишу код когда нету света, переводчиком не могу пользовться, поэтому все названия переменных написаны транслитом
    //TODO: не забудь переименовать переменные
    
    private PriorityQueue<Visitor, ushort> _mainQueue = new PriorityQueue<Visitor, ushort>();
    private ushort _acctualPriority = 0;

    public void EnQueue(Visitor visitor)
    {
        if ((_mainQueue.Count + 1) % 4 == 0)
        {
            _acctualPriority++;
            Console.WriteLine($"В КОНЕЦ очереди добавлен пациент по имени: {visitor.Name}");
            _mainQueue.Enqueue(visitor, _acctualPriority);
            return;
        }
        Console.WriteLine($"В очередь добавлен пациент по имени: {visitor.Name}");
        _mainQueue.Enqueue(visitor, _acctualPriority);
    }

    public void DeQueue(Visitor visitor)
    {
        Console.WriteLine($"В кабинет вошел посетитель по имени: {_mainQueue.Dequeue().Name}");
        OptimizePriority();
    }

    private void OptimizePriority()
    {
        if (_mainQueue.Count == 0)
        {
            _acctualPriority = 0;
        }
    }
}
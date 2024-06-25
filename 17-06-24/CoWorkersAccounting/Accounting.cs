using System.Collections;

namespace _17_06_24;

public class Accounting(params CoWorker[] list) : IEnumerable
{
    private List<CoWorker> _coWorkers = [..list];
    
    public void AddCoWorker(CoWorker coWorker)
    {
        _coWorkers.Add(coWorker);
    }

    public void RemoveCoWorker(CoWorker coWorker)
    {
        _coWorkers.Remove(coWorker);
    }
    
    public bool EditCoWorker(CoWorker coWorker, CoWorker editedCoWorker)
    {
        CoWorker temp = _coWorkers.Find(x => x == coWorker);

        if (temp == null) return false;

        temp.Position = editedCoWorker.Position;
        temp.FullName = editedCoWorker.FullName;
        temp.CorporateEMail = editedCoWorker.CorporateEMail;
        temp.Salary = editedCoWorker.Salary;

        return true;
    }

    // FullName 
    // Position
    // Salary
    // CorporateEMail
    public List<CoWorker> FindCoWorker(int[] choose = null, string[] findOptions = null)
    {
        List<CoWorker> result = new List<CoWorker>();

        if (choose == null || findOptions == null || choose.Length != findOptions.Length)
        {
            return result;
        }

        IEnumerable<CoWorker> filteredWorkers = _coWorkers;

        for (int i = 0; i < choose.Length; i++)
        {
            switch (choose[i])
            {
                case 0: // FullName
                    filteredWorkers = filteredWorkers.Where(x => x.FullName == findOptions[i]);
                    break;
                case 1: // Position
                    filteredWorkers = filteredWorkers.Where(x => x.Position == findOptions[i]);
                    break;
                case 2: // Salary
                    if (double.TryParse(findOptions[i], out double salary)) // потому что передал массив строк
                    {
                        filteredWorkers = filteredWorkers.Where(x => x.Salary == salary);
                    }
                    break;
                case 3: // CorporateEMail
                    filteredWorkers = filteredWorkers.Where(x => x.CorporateEMail == findOptions[i]);
                    break;
                default:
                    break;
            }
        }

        result = filteredWorkers.ToList();
        return result;
    }


    public List<CoWorker> SortCoWorkers(int criterion, bool reverse = false)
    {
        List<CoWorker> sortedCoWorkers = new List<CoWorker>(_coWorkers);

        if (criterion == 0) // FullName
        {
            sortedCoWorkers.Sort((x, y) => string.Compare(x.FullName, y.FullName, StringComparison.Ordinal));
        }
        else if (criterion == 1) // Position
        {
            sortedCoWorkers.Sort((x, y) => string.Compare(x.Position, y.Position, StringComparison.Ordinal));
        }
        else if (criterion == 2) // Salary
        {
            sortedCoWorkers.Sort((x, y) => x.Salary.CompareTo(y.Salary));
        }
        else if (criterion == 3) // CorporateEMail
        {
            sortedCoWorkers.Sort((x, y) => string.Compare(x.CorporateEMail, y.CorporateEMail, StringComparison.Ordinal));
        }
        
        // string.Compare - метод компаратор принимает 2 аргумуента которые нужно сравнить и условие по какому нужно сравнивать. Вертает числа больше нуля, ноль и меньше нуля. С их помощью элементы которые нужно отсортировать сортируються по принципу больше нуля - первый аргумент больше второго, 0 - одинаковые, меньше нуля - первый аргумент меньше второго
        // StringComparison.Ordinal - сравнение по битам (в случае с стрингами сравнение будет лексикографическое)
        // x.Salary.CompareTo(y.Salary)) - сравнивает число на котором был вызван с числом переданным в аргументах, возвращаемые значения такие же как и у string.Compare и принцип работы такой же, тольок сравниваються числа.
        
        if (reverse)
        {
            sortedCoWorkers.Reverse();
        }

        return sortedCoWorkers;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (CoWorker coWorker in _coWorkers)
        {
            yield return coWorker;
        }
    }
}
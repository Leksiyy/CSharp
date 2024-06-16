using System.Collections;

namespace _12_06_24;

public class Oceanarium : IEnumerable
{
    private List<BaseTypesOfFish> list;

    public Oceanarium(params BaseTypesOfFish[] list)
    {
        this.list = new List<BaseTypesOfFish>(list);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (BaseTypesOfFish fish in list)
        {
            yield return fish;
        }
    }

    public void Add(BaseTypesOfFish fish)
    {
        list.Add(fish);
    }
}
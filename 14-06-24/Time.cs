using System.Text;

namespace _14_06_24;

public class Time
{
    public int Hours { get; set; }
    public int Minutes { get; set; }

    public Time(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
        Normalize();
    }
    
    public void Plus30min()
    {
        Minutes += 30;
        Normalize();
    }

    private void Normalize()
    {
        if (Minutes >= 60)
        {
            Hours += 1;
        }

        if (Hours >= 24)
        {
            Hours = 0;
        }
    }
}
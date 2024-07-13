using System.Runtime.InteropServices.JavaScript;

namespace _01_07_24;

class Program
{
    static void Main(string[] args)
    {
        Magazine magazine = new Magazine("Privet ot Gordona", "MMKLA", DateTime.Parse("23.05.2023"), 100);
        
        magazine.InputInfo([1, 2], ["HELLO", "22.02.2022"]);
        magazine.OutputInfo();
        magazine.SaveJsonToFile();
        Magazine magazine2 = new Magazine(null,null,null,null);
        magazine2.LoadJsonFromFile();
        magazine2.OutputInfo();
    }
}
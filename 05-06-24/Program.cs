using System;
using _05_06_24._1;
using _05_06_24._2;

namespace _05_06_24
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                Product product = new Product("Chocolate", 10, 50);
                product.ShowMoney();  // 10.50

                product.DecreasePrice(2, 75);
                product.ShowMoney();  // 7.75

                product.DecreasePrice(8, 0);
                product.ShowMoney();  // 0.00
            }
            {
                Device automobile = new Automobile("Audi", "metal, etc", 1500);
                Device microvawe = new Microvawe("Saturn", "metal and smoe plastic, etc", 22);
                Device steamMelter = new SteamMelter("OceanWarior", "metal and.. MORE METAL, etc.", 150000);
                Device cattle = new Cattle("Braun", "plastic and copper", 2);
                
                automobile.Show();
                automobile.Desc();
                automobile.Sound();
                
                Console.WriteLine("----------------------------------------");
                
                microvawe.Show();
                microvawe.Desc();
                microvawe.Sound();
                
                Console.WriteLine("----------------------------------------");
                
                steamMelter.Show();
                steamMelter.Desc();
                steamMelter.Sound();
                
                Console.WriteLine("----------------------------------------");

                cattle.Show();
                cattle.Desc();
                cattle.Sound();
            }
        }
    }
}
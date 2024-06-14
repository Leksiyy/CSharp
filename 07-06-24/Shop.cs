using System;

namespace _07_06_24
{
    public class Shop
    {
        private int Area { get; }

        public Shop(int num)
        {
            Area = num;
        }
        
        public void ShowShop()
        {
            Console.WriteLine(Area);
        }

        public static Shop operator +(Shop obj, int num)
        {
            return new Shop(obj.Area + num);
        }

        public static Shop operator -(Shop obj, int num)
        {
            return new Shop(obj.Area - num);
        }

        public static bool operator ==(Shop obj, Shop obj1)
        {
            if (obj is null || obj1 is null)
            {
                throw new Exception("А не нужно было передавать нулл значение"); 
            }
            
            return obj.Area == obj1.Area;
        }

        public static bool operator !=(Shop obj, Shop obj1)
        {
            if (obj is null || obj1 is null)
            {
                throw new Exception("А не нужно было передавать нулл значение");
            }
            
            return !(obj.Area == obj1.Area);
        }

        public static bool operator >(Shop obj, Shop obj1)
        {
            return obj.Area > obj1.Area;
        }

        public static bool operator <(Shop obj, Shop obj1)
        {
            return obj.Area < obj1.Area;
        }
        
        public override bool Equals(object obj) // требует так же перегрурзки GetHashCode
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Shop temp = (Shop)obj;
            return Area == temp.Area;
        }

        public override int GetHashCode() // только для иммутабельных полей
        {
            return Area.GetHashCode();
        }
    }
}
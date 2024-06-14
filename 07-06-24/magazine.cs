using System;

namespace _07_06_24
{
    public class Magazine
    {
        private int WorkersCount { get; }

        public Magazine(int num1)
        {
            WorkersCount = num1;
        }

        public void ShowMagazine()
        {
            Console.WriteLine(WorkersCount);
        }
     
        public static Magazine operator +(Magazine obj, int num)
        {
            return new Magazine(obj.WorkersCount + num);
        }
        
        public static Magazine operator -(Magazine obj, int num)
        {
            return new Magazine(obj.WorkersCount - num);
        }

        public static bool operator ==(Magazine obj1, Magazine obj2)
        {
            if (obj1 is null || obj2 is null)
            {
                throw new Exception("А не нужно было передавать нулл значение");
            }

            return obj1.WorkersCount == obj2.WorkersCount;
        }

        public static bool operator !=(Magazine obj1, Magazine obj2)
        {
            if (obj1 is null || obj2 is null)
            {
                throw new Exception("А не нужно было передавать нулл значение");
            }

            return (obj1.WorkersCount == obj2.WorkersCount);
        }

        public static bool operator <(Magazine obj1, Magazine obj2)
        {
            return obj1.WorkersCount < obj2.WorkersCount;
        }

        public static bool operator >(Magazine obj1, Magazine obj2)
        {
            return obj1.WorkersCount > obj2.WorkersCount;
        }
        
        // public static Magazine operator =(Magazine obj1, int num)
        // {
        //     obj1. //??
        // }

        public override bool Equals(object obj) // требует так же перегрурзки GetHashCode
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Magazine temp = (Magazine)obj;
            return WorkersCount == temp.WorkersCount;
        }

        public override int GetHashCode() // только для иммутабельных полей
        {
            return WorkersCount.GetHashCode();
        }
        
    }
}
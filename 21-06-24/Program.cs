using _21_06_24._1;

namespace _21_06_24;

class Program
{
    public delegate void MyDelegate(string mess);
    
    public delegate int PlusDelegate(int num1, int num2);
    public delegate int MinusDelegate(int num1, int num2); // можно было использовать и один делегат
    public delegate int MultDelegate(int num1, int num2);

    public delegate bool ArithmeticDelegate(int num);
    
    static void Main(string[] args)
    {
        MyDelegate @delegate = Message.ShowMessage;
        @delegate("Hello");

        PlusDelegate plusDelegate = (num1, num2) => num1 + num2;
        MinusDelegate minusDelegate = (num1, num2) => num1 - num2;
        MultDelegate multDelegate = (num1, num2) => num1 * num2;
        
        Console.WriteLine(plusDelegate(1, 2));
        Console.WriteLine(minusDelegate(2, 1));
        Console.WriteLine(multDelegate(2, 4));

        ArithmeticDelegate arithmeticDelegate = (num) => num % 2 == 0;
        
        Console.WriteLine(arithmeticDelegate(6));
        
        arithmeticDelegate = (num) => num % 2 != 0;
        
        Console.WriteLine(arithmeticDelegate(6));
        
        arithmeticDelegate = (num) =>
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        };
        
        Console.WriteLine(arithmeticDelegate(6));
        
        arithmeticDelegate = (num) =>
        {
            int a = 0;
            int b = 1;

            if (num == 0 || num == 1)
            {
                return true;
            }

            while (b < num)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b == num;
        };
        
        Console.WriteLine(arithmeticDelegate(6));
        
        
        Console.WriteLine(plusDelegate.Invoke(1, 4));
        Console.WriteLine(minusDelegate.Invoke(9, 4));
        Console.WriteLine(multDelegate.Invoke(1, 4));
    }
}
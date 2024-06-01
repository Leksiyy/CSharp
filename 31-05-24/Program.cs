using System;

namespace _31_05_24
{
    internal class Programm
    {
        public static void Main(string[] args)
        {
            // TASK 2
            try
            {
                NumberReader reader1 = new NumberReader();
                System.Console.Out.WriteLine(reader1.UseReader("five"));
                System.Console.Out.WriteLine(reader1.UseReader("one"));
                //System.Console.Out.WriteLine(reader1.UseReader("9")); // working
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            // TASK 4
            try
            {
                TrueOrFalseExpression trueOrFalse = new TrueOrFalseExpression();
                trueOrFalse.CheckExpression("14>15");
                trueOrFalse.CheckExpression("14<15");
                //trueOrFalse.CheckExpression("hello?"); //working
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
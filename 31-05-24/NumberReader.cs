using System;

namespace _31_05_24
{
    public class NumberReader
    {
        private string[,] _dictionary =
        {
            { "one", "1" }, { "two", "2" }, { "three", "3" }, { "four", "4" }, { "five", "5" },
            { "six", "6" }, { "seven", "7" }, { "eight", "8" }, { "nine", "9" }
        };
        
        public byte UseReader(string str)
        {
            for (int i = 0; i < _dictionary.Length/2; i++)
            {
                if (str == _dictionary[i, 0])
                {
                    return Convert.ToByte(_dictionary[i, 1]);
                }
            }
            throw new ArgumentException("Incorrect method input!");
        }
    }
}
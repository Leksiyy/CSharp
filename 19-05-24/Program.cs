using System;
using System.Linq;

namespace _19_05_24
{
    internal class Program
    {
        public class MinMax
        {
            private int result;
            public MinMax(int[,] arr, bool type) // type = 0 - min
            {
                if (!type)
                {
                    int temp = arr[0, 1]; 
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] < result)
                            {
                                result = arr[i, j];
                            }
                        }
                    }
                    this.result = temp;
                }
                else
                {
                    int temp = arr[0, 1]; 
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] > result)
                            {
                                result = arr[i, j];
                            }
                        }
                    }
                    this.result = temp;
                }
            }

            public int getResult()
            {
                return result;
            }

            public void setMin(int[,] arr)
            {
                int temp = arr[0, 1]; 
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < result)
                        {
                            result = arr[i, j];
                        }
                    }
                }
                this.result = temp;
            }
            
             public void setMax(int[,] arr)
            {
                int temp = arr[0, 1]; 
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > result)
                        {
                            result = arr[i, j];
                        }
                    }
                }
                this.result = temp;
            }
        }
        
        public class StringReverse
        {
            private string result = "";

            public StringReverse(string str)
            {
                int wordStartIndex = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ' || i == str.Length - 1)
                    {
                        int wordEndIndex = (i == str.Length - 1) ? i : i - 1;

                        bool isLastWord = (i == str.Length - 1);
                        AppendReversedWord(str, wordStartIndex, wordEndIndex, !isLastWord);

                        wordStartIndex = i + 1;
                    }
                }
            }

            private void AppendReversedWord(string str, int start, int end, bool addSpace)
            {
                for (int j = end; j >= start; j--)
                {
                    result += str[j];
                }

                if (addSpace)
                {
                    result += ' ';
                }
            }

            public string getResult()
            {
                return result;
            }
        }

        public class SubstringCounter
        {
            public string[] count(string str, string find)
            {
                int count = 0;
                for (int i = 0; i <= str.Length - find.Length; i++)
                {
                    if (str[i] == find[0])
                    {
                        int j;
                        for (j = 0; j < find.Length; j++)
                        {
                            if (str[i + j] != find[j])
                            {
                                break;
                            }
                        }
                        if (j == find.Length)
                        {
                            count++;
                        }
                    }
                }

                string[] result = new string[2];
                result[0] = find;
                result[1] = count.ToString();
                return result;
            }
        }

        public static void Main(string[] args)
        {
            int[,] arr = { { 1, 2 }, { 3, 4 } };

            MinMax min = new MinMax(arr, false);
            MinMax max = new MinMax(arr, true);

            System.Console.Out.WriteLine("min: " + min.getResult() + '\n');
            System.Console.Out.WriteLine("max: " + max.getResult() + '\n');

            string just_string = "Why she had to go. I don't know, she wouldn't say";

            StringReverse str = new StringReverse(just_string);
            
            System.Console.Out.WriteLine("reverse string: " + str.getResult() + '\n');

            SubstringCounter sub = new SubstringCounter();

            System.Console.Out.WriteLine("substring: " + sub.count(just_string, "she")[0] + "\n count of substring: " + sub.count(just_string, "she")[1]);
        }
    }
}
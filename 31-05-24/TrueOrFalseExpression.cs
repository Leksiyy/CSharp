using System;

namespace _31_05_24
{
    public class TrueOrFalseExpression
    {
        private string[] ParseOperator(string str)
        {
            string[] result = {"", "", ""};
            bool isHalf = false;
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    result[1] += c;
                    isHalf = true;
                }
                else
                {
                    if (isHalf)
                    {
                        result[0] += c;
                    }
                    else
                    {
                        result[2] += c;
                    }
                }
            }
            if (result[0] == "" || result[1] == "" || result[2] == "") throw new ArgumentException("Can't parse your string!");
            return result;
        }
        
        public bool CheckExpression(string str)
        {
            string[] parsedString = ParseOperator(str);
            int num1 = Convert.ToInt32(parsedString[0]);
            int num2 = Convert.ToInt32(parsedString[2]);

            switch (parsedString[1])
            {
                case ">":
                    return num1 > num2;
                case "<":
                    return num1 < num2;
                case "<=":
                    return num1 <= num2;
                case ">=":
                    return num1 >= num2;
                case "==":
                    return num1 == num2;
                case "!=":
                    return num1 != num2;
                default:
                     break;
            }

            throw new ArgumentException(
                "я не знаю что тут вертать поэтому будет исключение которое никогда не словиться");
        }
    }
}
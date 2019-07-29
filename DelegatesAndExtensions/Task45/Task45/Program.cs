using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task45
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "100";
            string str2 = "0";
            string str3 = "-1";
            Console.WriteLine($"Is string positive?:{str1.IsPositiveNumber()}");
            Console.WriteLine($"Is string positive?:{str2.IsPositiveNumber()}");
            Console.WriteLine($"Is string positive?:{str3.IsPositiveNumber()}");
            Console.ReadKey();
        }

    }

    public static class StringisNumber
    {
        public static bool IsPositiveNumber(this string str)
        {
            return StringToInt(str) > 0;
        }

        private static int StringToInt(String str)
        {
            int i = 0;
            int num = 0;
            bool isNeg = false;

            //Check for negative sign; if it there, set the isNeg flag
            if (str[0] == '-')
            {
                isNeg = true;
                i = 1;
            }

            while (i < str.Length)
            {
                if (char.IsDigit(str[i]))
                {
                    num *= 10;
                    num += str[i++] - '0';//Minus the ASCII code of '0' to get the value of the string[i++].
                }
                else
                {
                    throw new ArgumentException("String is not a number");
                }

            }

            if (isNeg)
                num = -num;
            return num;
        }
    }
}

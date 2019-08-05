using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        private static bool isAllowedToWrite = true;
        private static string catalogPath;
        static void Main(string[] args)
        {
            try
            {
                if (isAllowedToWrite)
                {
                    isAllowedToWrite = false;
                    Console.Write("Введите путь к каталогу: ");
                    catalogPath = Console.ReadLine();
                }

            }
            catch
            {

            }
        }
    }
}

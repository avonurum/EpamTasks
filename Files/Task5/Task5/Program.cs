using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                OnObserve();

            }
            catch
            {

            }
        }

        public static void OnObserve()
        {
            bool ModeIsChosen = false;
            while (!ModeIsChosen)
            {
                Console.Clear();
                Console.WriteLine("Наблюдать или перейти в режим отката ? y/n");
                var answer = Console.ReadKey();
                if (answer.Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    isAllowedToWrite = true;
                    Console.WriteLine("Режим наблюдения");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Surveillance surveillance = new Surveillance(catalogPath);
                    break;
                }

                else if (answer.Key == ConsoleKey.N)
                {
                    Console.WriteLine();
                    isAllowedToWrite = false;
                    Console.WriteLine("Режим отката");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Reverting reverting = new Reverting();
                    break;
                }
                else
                {
                    throw new ArgumentException("");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4._1_3
{

    //In this application I have combined several tasks: Task4.1,Task4.2 and Task4.3.
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5] { "locular", "locator", "genesis", "sand", "sambuca" };
            string[] str2 = new string[5] { "a", "aa", "b", "bbb", "bbbb" };
            int[] num = new int[] { 1234, 12, 12345, 1, 456789, 15, 200000, 155555 };
            ArraySorting<string> arraySorting1 = new ArraySorting<string>();
            ArraySorting<int> arraySorting2 = new ArraySorting<int>();
            arraySorting1.CreateThreadForSorting(str, CompareElem);
            arraySorting2.CreateThreadForSorting(num, CompareElem);
            Console.ReadKey();

        }

        public static void ShowArray<U>(U[] array)
        {
            foreach (U element in array)
            {
                Console.Write($"{element} ");
            }
            Console.Write(Environment.NewLine);
        }

        public static int CompareElem(string str1, string str2)
        {
            if (str1 == str2) return 0;
            else if (str1 == null) return -1;
            else if (str2 == null) return 1;
            else if (str1.Length < str2.Length) return -1;
            else if (str1.Length > str2.Length) return 1;
            else return CompareAlphabetically(str1, str2);
        }

        private static int CompareAlphabetically(string str1, string str2)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (char.ToLower(str1[i]) == char.ToLower(str2[i])) { }
                else if (str1[i] > str2[i])
                {
                    return 1;
                }
                else return -1;
            }
            return 0;
        }
        public static int CompareElem(int num1, int num2)
        {
            if (num1 == num2) return 0;
            else if (num1 < num2) return -1;
            else return 1;
        }
        public static int CompareElem(double num1, double num2)
        {
            if (num1 == num2) return 0;
            else if (num1 < num2) return -1;
            else return 1;
        }



    }
    class ArraySorting<T>
    {
        public event EventHandler SortingIsFinished;

        public void EventMessage(object o, EventArgs arg)
        {
            Console.WriteLine("Sorting is finished!");
        }

        public void CreateThreadForSorting(T[] arr, Func<T, T, int> compare)
        {
            SortingIsFinished += EventMessage;
            Thread th = new Thread(() => {
                SortMass(arr, compare);
                Program.ShowArray(arr);
            });
            th.Start();
        }

        public void SortMass(T[] array, Func<T, T, int> func)
        {
            if (func == null)
            {
                throw new ArgumentNullException();
            }
            T temp;
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine($"{i * 100 / array.Length} percent of sorting {array.GetType()} is done");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                for (int j = i; j >= 1 && func(array[j - 1], array[j]) > 0; j--)
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;

                }
            }
            SortingIsFinished?.Invoke(this, EventArgs.Empty);

        }

    }

}


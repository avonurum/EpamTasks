using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language17
{
    /* ---Задание 1.7--
     * Написать программу, которая генерирует случайным образом элементы массива (число элементов в массиве и их тип определяются разработчиком), определяет для него максимальное и минимальное значения, сортирует массив и выводит полученный результат на экран
     * Примечание: LINQ запросы и готовые функции языка (Sort, Max и т.д.) использовать в данном задании запрещается.
     * 
    /* По сути max и min элементы массива это последний и первый элементы отсортированного массива)Но на всякий пожарный я прописала их отдельно*/
    class Program
    {
        static Random ranGen = new Random();
        static int randomMin = -99, randomMax = 99;

        static void Main(string[] args)
        {
            int arrayLength = 15;
            int[] randomArray = new int[arrayLength];
            FillArray(ref randomArray);
            Show(randomArray);
            SearchMin(randomArray);
            SortArray(randomArray);
            Console.WriteLine("Max: " + SearchMax(randomArray));
            Console.WriteLine("Min: " + SearchMin(randomArray));
            Show(randomArray);
            Console.ReadLine();
        }

        public static void FillArray(ref int[] array)//заполнение массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ranGen.Next(randomMin, randomMax);
            }
        }

        public static void Show(int[] array)//вывод массива
        {
            foreach (int arr in array)
            {
                Console.Write(arr + " ");
            }
            Console.Write(Environment.NewLine);
        }


        public static int SearchMax(int[] elem) //нахождение макс. элемента
        {
            int max = elem[0];
            for(int i=1;i<elem.Length;i++)
            {
                if(max<elem[i])
                {
                    max = elem[i];
                }
            }
            return max;
        }

        public static int SearchMin(int[] elem)//нахождение мин. элемента
        {
            int min = elem[0];
            for (int i = 1; i < elem.Length; i++)
            {
                if (min > elem[i])
                {
                    min = elem[i];
                }
            }
            return min;
        }

        static void SortArray(int[] a)//сортировка вставками
        {
            int temp;
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = i; j >= 1 && a[j] < a[j - 1]; j--)
                {
                    temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                }
            }

        }
    }
}

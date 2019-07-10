using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language19
{
    /* ---Задание 1.9---
     * Написать программу, 
     * которая определяет сумму неотрицательных элементов в одномерном массиве. Число элементов в массиве и их тип определяются разработчиком.
     * */
    class Program
    {
        static Random ranGen = new Random();
        static int randomMin = -99, randomMax = 99;
        static void Main(string[] args)
        {

            int length = 10;
            int[] arr = new int[length];
            FillArray(ref arr);
            Console.WriteLine("array:");
            ShowArray(ref arr);
            SumNegative(ref arr);
            Console.WriteLine("sum:");
            Console.WriteLine(SumNegative(ref arr));
            Console.ReadKey();
        }


        public static int SumNegative(ref int[] arr)//замена положительных элементов на нули
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) sum += arr[i];
            }
            return sum;
        }

        public static void FillArray(ref int[] arr)//заполнение массива
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ranGen.Next(randomMin, randomMax);
            }
        }
        public static void ShowArray(ref int[] arr)//вывод массива
        {
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.Write(Environment.NewLine);
        }
    }
}

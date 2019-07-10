using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language110
{
    /*---Задание 1.10---
     * Элемент двумерного массива считается стоящим на чётной позиции, если сумма номеров его позиций по обеим размерностям
     * является чётным числом (например, [1,1] — чётная позиция, а [1,2] — нет). Определить сумму элементов массива, стоящих на чётных позициях.
     * */
    class Program
    {
        static Random ranGen = new Random();
        static int randomMin = -99, randomMax = 99;
        static void Main(string[] args)
        {
            int flength = 10;
            int slength = 10;
            int[,] array = new int[flength, slength];
            FillArray(ref array,flength,slength);
            Console.WriteLine("array:");
            ShowArray(ref array, flength, slength);
            Console.WriteLine("sum :"+SumEvenPos(ref array, flength, slength));
            Console.ReadKey();
        }



        public static void FillArray(ref int[,] arr,int flength, int slength)//заполнение массива
        {
            for (int i = 0; i < flength; i++)
            {
                for(int j=0;j<slength;j++)
                arr[i,j] = ranGen.Next(randomMin, randomMax);
            }
        }
        public static void ShowArray(ref int[,] arr, int flength, int slength)//вывод массива
        {
            for (int i = 0; i < flength; i++)
            {
                for (int j = 0; j < slength; j++)
                    Console.Write(arr[i,j] + " ");
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }
        public static int SumEvenPos(ref int[,] arr, int flength, int slength)//суммирование элеменов, находящихся на четных позициях
        {
            int sum=0;
            for (int i = 0; i < flength; i++)
            {
                for (int j = 0; j < slength; j++)
                {
                    if((i+j)%2==0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language18
{
    /*---Задание 1.8---
     * Написать программу, которая заменяет все положительные элементы в 
     * трёхмерном массиве на нули. Число элементов в массиве и их тип определяются разработчиком.
     * */
    class Program
    {
        static Random ranGen = new Random();
        static int randomMin = -99, randomMax = 99;
        static void Main(string[] args)
        {
            //размерности массива
            int fRank = 5;
            int sRank = 3;
            int thRank = 2;
            int[,,] arr = new int[fRank, sRank,thRank];
            FillArray(ref arr, fRank, sRank, thRank);
            Console.WriteLine("original:");
            ShowArray(ref arr, fRank, sRank, thRank);
            ChangeElem(ref arr, fRank, sRank, thRank);
            Console.WriteLine("changed:");
            ShowArray(ref arr, fRank, sRank, thRank);
            Console.ReadKey();
        }


        public static void ChangeElem(ref int[,,] arr, int fRank,int sRank,int thRank)//замена положительных элементов на нули
        {
            for(int i=0;i<fRank;i++)
            {
                for(int j=0;j<sRank;j++)
                {
                    for(int k=0;k<thRank;k++)
                    {
                        if(arr[i, j, k] >0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
                }
            }
        }

        public static void FillArray(ref int[,,] arr, int fRank, int sRank, int thRank)//заполнение массива
        {
            for (int i = 0; i < fRank; i++)
            {
                for (int j = 0; j < sRank; j++)
                {
                    for (int k = 0; k < thRank; k++)
                    {
                        arr[i, j, k] = ranGen.Next(randomMin, randomMax);
                    }
                }
            }
        }
        public static void ShowArray(ref int[,,] arr, int fRank, int sRank, int thRank)//вывод массива
        {
            for (int i = 0; i < fRank; i++)
            {
                for (int j = 0; j < sRank; j++)
                {
                    for (int k = 0; k < thRank; k++)
                    {
                        Console.Write(arr[i, j, k] + " ");
                    }
                    Console.Write(Environment.NewLine);
                }
                Console.Write(Environment.NewLine);
            }
            
        }
    }
}

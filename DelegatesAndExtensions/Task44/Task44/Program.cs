using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            double[] arr2 = new double[5] { 1.2, 2.8, 3.7, 4.3, 5 };
            Console.WriteLine(arr.SumElements());
            Console.WriteLine(arr2.SumElements());
            Console.ReadKey();
        }

    }

   static class SumArray 
    {
        public static int SumElements(this int[] array)
        {
            int res=array[0];
            for(int i=1;i<array.Length;i++)
            {
                res = array[i];
            }
            return res;

        }
        public static double SumElements(this double[] array)
        {
            double res = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                res = array[i];
            }
            return res;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task46
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5,-6,12,-20 };
            List<int> positive=FindPositiveElem(array);
            List<int> negativeByDelegate = FindNegativeElem(array, IsPositive);
            int minElemByLambda = FindExtremumElem(array, (int x,int y) => {
                                                        if (x == y) return 0;
                                                        else if (x > y) return 1;
                                                        else return -1;
                                                         });
            int maxElemByAnonMethod = FindExtremumElem(array, delegate (int x, int y) {
                                                        if (x == y) return 0;
                                                        else if (x < y) return 1;
                                                        else return -1;
                                                        });
            List<int> evenElmByLINQ=FindEvenElem(array);

            Show(positive,"Positive elements");
            Show(negativeByDelegate, "Negative elements");
            Show(minElemByLambda, "Min");
            Show(maxElemByAnonMethod,"Max");
            Show(evenElmByLINQ, "Even elements");
            
        }

        public static void Show(List<int> array,string  message)
        {
            Console.Write(message+":");
            foreach(int elem in array)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
        }

        public static void Show(int elem,string  message)
        {
            Console.WriteLine($"{message}:{elem}");
        }

        public static List<int> FindPositiveElem(int[] array)
        {
            List <int>list = new List<int>();
            foreach(int elem in array)
            {
                if(elem>0)
                {
                    list.Add(elem);
                }
            }
            return list;
        }

        public static List<int> FindEvenElem(int[] array)
        {
            var evenElem = from elem in array
                               where elem%2==0
                               select elem;
            return evenElem.ToList();
        }

        public static List<int> FindNegativeElem(int[] array,Predicate<int> predicate)
        {
            List <int>list = new List<int>();
            foreach(int elem in array)
            {
                if(predicate(elem))
                {
                    list.Add(elem);
                }
            }
            return list;
        }

        public static T FindExtremumElem<T>(T[] array, Func<T,T,int> func)
        {
            T max = array[0];
            if (func == null)
            {
                throw new NullReferenceException();
            }
            for(int i=1;i<array.Length;i++)
            {
                if(func(max,array[i])>0)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static bool IsPositive(int elem)
        {
           return(elem < 0);
        }
    }

}

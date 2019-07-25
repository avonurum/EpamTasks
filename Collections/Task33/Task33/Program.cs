using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DynamicArray<int> d = new DynamicArray<int>();
            for(int i=0;i<20;i++)
            {
                d.Add(i);
            }

            
            //foreach(int i in d)
            //{
            //    Console.WriteLine(i);
            //}
            List<int> list = new List<int>();
            list.Add(50);
            list.Add(100);
            list.Add(150);
            d.AddRange(list);
            d.Insert(25, 1);
            foreach (int i in d)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

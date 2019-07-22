using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Circle<int> list = new Circle<int>();
            Circle<int>.FillList(list);
            DeleteNodes<int>(list.Head, list);
            list.Show();
            Console.ReadKey();
        }
        static void DeleteNodes <T>(Node<T> n, Circle<T> list)
        {
            if(list.Count==1)
            {
                return;
            }
            else
            {
                list.Remove(n.Next);
                DeleteNodes<T>(n.Next,list);
            }
        }

    }
}

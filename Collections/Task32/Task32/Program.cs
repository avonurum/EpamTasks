using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "Hello honey. You need some honey. Do you have some money";
            char c = ' ';
            char[] separators = new char[2] { '.', ' ' };
            char c2 = '.';
            string[] array = temp.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            foreach(string str in array)
            {
                Console.WriteLine(str);
            }
            Dictionary<string, int> countwords = new Dictionary<string, int>();
            foreach (string str in array)
            {
               if(countwords.ContainsKey(str.ToLower()))
                {
                    countwords[str]++;
                }
               else
                {
                    countwords.Add(str.ToLower(), 1);
                }
            }

            for (int i=0;i < countwords.Count;i++)
            {
                Console.WriteLine(countwords.Keys.ElementAt(i));
            Console.WriteLine(countwords.Values.ElementAt(i));
                
            }
            
            Console.ReadKey();
        }
    }
}

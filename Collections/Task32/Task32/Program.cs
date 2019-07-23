using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static char sep1=' ';
        static char sep2 = '.';
        static void Main(string[] args)
        {
            string temp = "The city of Washington was designed in the late eighteenth century. It is co-extensive with the District of Columbia.All interiors of the building were burned by the British in 1814. The Capitol was reoccupied in 1819. The present Senate and House wings were begun in 1851";
            char[] separators = new char[2] { sep1, sep2 };
            string[] array = SplitString(separators, temp);
            Dictionary<string, int> countwords = new Dictionary<string, int>();
            FillDictionary(countwords, array);
            ShowStatistics(countwords);
            Console.ReadKey();
        }


        public static string[] SplitString(char[] sep,string text)//разделение текста на слова
        {
            return text.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        }


        public static void FillDictionary(Dictionary<string,int> dic,string[] array)//заполнение словаря
        {
            foreach (string str in array)
            {
                if (dic.ContainsKey(str.ToLower()))
                {
                    dic[str.ToLower()]++;
                }
                else
                {
                    dic.Add(str.ToLower(), 1);
                }
            }
        }


        public static void ShowStatistics(Dictionary<string,int> dic)//вывод информации о том, сколько раз встречаются слова в этом тексте
        {
            for (int i=0;i < dic.Count;i++)
            {
                Console.WriteLine($"Слово {dic.Keys.ElementAt(i)} встречается {dic.Values.ElementAt(i)} раз(а)");
            }
        }

    }
}

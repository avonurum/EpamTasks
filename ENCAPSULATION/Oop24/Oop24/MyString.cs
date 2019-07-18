using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop24
{
    
    //поиск символов
    //конвертация в/из массива
    class MyString
    {
        private char[] array;

        public MyString(char[] array)
        {
            Array = array;
        }
        public MyString(string s)
        {
            Array = toArray(s);
        }

        public char[] Array { get => array; private set => array = value; }//сделать проверку на null

        public int Length => array.Length;

        public static MyString operator + (MyString s, MyString s2)//сложение строк;
        {
            char[] res = new char[s.Length + s2.Length];
            int i = 0;
            for(i=0;i<s.Length;i++)
            {
                res[i] = s[i];
            }
            for(i=s.Length;i<res.Length;i++)
            {
                res[i] = s2[i-s.Length];
            }
            return new MyString(res);
        }
        public static char[] toArray(String str)
        {
            char[] res = new char[str.Length];
            for(int i=0;i<res.Length;i++)
            {
                res[i] = str[i];
            }
            return res;
        }

        public void Show()
        {
            foreach(char c in array)
            {
                Console.Write(c);
            }
        }
        public char this[int i]//доступ к определенному символу
        {
            get
            {
                return array[i];
            }
        }

        public bool Equals(MyString str)//сравнение
        {
            if(Length==str.Length)
            {

                for (int i=0;i<str.Length;i++)
                {
                    if (this[i] != str[i]) 
                    return false;
                }
                return true;
            }
            else return false;
        }
        public String toString()//конвертация из массива в строку
        {
            string temp="";
            foreach(char c in array)
            {
                temp += c;
            }
            return temp;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop24
{
    class MyString
    {
        private char[] array;

        public MyString(char[] array)
        {
            Array = array;
        }
        public MyString(string s)
        {
            Array = ToArray(s);
        }

        public char[] Array { get => array; private set => array = value ?? throw new NullReferenceException("Передана пустая ссылка");}

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
        public static char[] ToArray(String str)
        {
            char[] res = new char[str.Length];
            for(int i=0;i<res.Length;i++)
            {
                res[i] = str[i];
            }
            return res;
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
        public override String ToString()//конвертация из массива в строку
        {
            string temp="";
            foreach(char c in array)
            {
                temp += c;
            }
            return temp;
        }
        public bool Contains(char c)//поиск элемента
        {
            foreach (char ch in array)
            {
                if (ch == c)
                    return true;
            }
            return false;
        }
        public MyString Replace(char c,char c2)//замена элемента
        {
            char[] res = new char[Length];
            for(int i=0;i<array.Length;i++)
            {
                if (array[i]==c)res[i] = c2;
                else res[i] = array[i];
            }
            return new MyString(res);
        }


    }
}

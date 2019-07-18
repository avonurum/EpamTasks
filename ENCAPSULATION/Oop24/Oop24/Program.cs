using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop24
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString(new char[]{ 'п', 'р', 'и', 'в', 'е', 'т' });
            MyString str2 = new MyString(new char[] { 'п', 'о', 'к', 'а' });
            MyString str3 = new MyString(new char[] { 'п', 'о', 'к', 'а' });
            Show(str, str2, str3);
            Console.ReadKey();
        }

        static void Show(MyString str1, MyString str2, MyString str3)
        {
            Console.WriteLine($"Сравнение строки 1 и строки 2: {str1.Equals(str2)}");
            Console.WriteLine($"Сравнение строки 3 и строки 2: {str3.Equals(str2)}");
            Console.WriteLine($"Находится ли в строке 1 символ п: {str1.Contains('п')}");
            Console.WriteLine($"Находится ли в строке 1 символ ж: {str1.Contains('ж')}");
            Console.WriteLine($"Заметить в строке 3 символ п на м: {str3.Replace('п','м')}");
            Console.WriteLine($"Вывести 3 символ 1 строки: {str1[2]}");
            Console.WriteLine($"Соединить две строки: {str1+str2}");
        }
    }
}

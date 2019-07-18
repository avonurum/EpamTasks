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
            MyString res = str + str2;
            res.Show();
            Console.WriteLine(str2.Length );
            Console.WriteLine(str3.Length);
            Console.WriteLine(str3.Equals(str2));
            Console.ReadKey();
        }
    }
}

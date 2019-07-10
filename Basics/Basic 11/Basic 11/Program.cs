using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_11
{

    /* ---Задание 1.1
     * Написать программу, которая определяет площадь прямоугольника со сторонами a и b. 
     * Если пользователь вводит некорректные значения (отрицательные или ноль),
     * должно выдаваться сообщение об ошибке. Возможность ввода пользователем строки вида «абвгд» или нецелых чисел игнорировать.
     * */

    /* В задании сказано игнорировать, если пользователь вводит строку или вещественные числа. Я не совсем поняла как это сделать. 
     * Ведь, когда пользователь вводит значение, мы получаем строку, а строка не приходится к int и ее нужно парсить, а если парсить то, что не
     * нельзя преобразовывать к указанному типу, выскакивает исключение. Так что я написала некую проверку и надеюсь, что это не является грубой ошибкой при 
     * решении данной задачи. */
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            AddValue(ref a);
            AddValue(ref b);
            double result = CalculateArea(a, b);
            Console.WriteLine($"result: {result}");
            Console.ReadKey();
        }

        //вычисление площади
        public static double CalculateArea(float a, float b)
        {
            return a * b;
        }

        //добавление значения
        public static void AddValue(ref float value)
        {
            Console.WriteLine("Введите сторону: ");
            string temp = Console.ReadLine();
            if (CheckValue(temp) == true) value = float.Parse(temp);
            else
            {
                Console.WriteLine("Вы ввели неверное зничение. Повторите ввод.");
                AddValue(ref value);
            }
        }

        //проверка значения
        public static bool CheckValue(string value)
        {
            try
            {
                return float.Parse(value) > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}

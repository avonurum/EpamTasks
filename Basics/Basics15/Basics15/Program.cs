using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics15
{
    /* ---Задание 1.5---
     * Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. 
     * Сумма этих чисел будет равна 23. Напишите программу, которая выводит на экран сумму всех чисел меньше 1000, кратных 3 или 5.
     * */
    /* Для решения данной задачи я решила воспользоваться формулой вычисления суммы членов арифметической прогрессии. 
     * Но так как имеются числа, которые делятся и 3 и 5 одновременно, для верного результата вычесть числа являющиеся членами арифметической прогрессии
     * 5*3*n
     */
    class Program
    {
        static void Main(string[] args)
        {
            const int border = 1000;//граница
            const int firstNum = 3;//первый делитель
            const int secondNum = 5;//второй делитель
            Console.WriteLine(CalculateSum(firstNum, secondNum, border));
            Console.ReadKey();
        }

        static int CalculateSum(int first, int second, int border)//вычисление суммы
        {
            return CalculateArith(first,border) + CalculateArith(second,border) - CalculateArith(first * second,border);
        }
        static int CalculateArith(int Num,int border)//вычисление суммы элементов арифм. прогрессии.
        {
           int aBorder = border-1;//так как числа входят в диапазн до границы не включительно, необходимо вычесть единицу
           return aBorder / Num * (Num + (aBorder / Num) * Num)/2;
        }
    }
}

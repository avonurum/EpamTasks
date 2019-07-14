using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Oop22
{
    //для того чтобы тругольник со сторонами a,b,c существовал, нужно чтобы выполнялись условия : a + b > c and a + c > b and b + c > a:
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
                A = a;
                B = b;
                C = c;
        }

        public double A {
            get => a;
            set
            {
                if (value > 0)
                {
                    if(b!=0 && c!=0 && !isTriangleExist(value,b,c))
                    {
                        throw new ArgumentException("Треугольник с данными длинами сторон не существует");
                    }
                    else a = value;
                }
                else throw new ArgumentException("Треугольник с данными длинами сторон не существует");
            }    
        }

        public double B {
            get => b;
            set
            {
                if (value > 0)
                {
                    if (a != 0 && c != 0 && !isTriangleExist(a, value, c))
                    {
                        throw new ArgumentException("Треугольник с данными длинами сторон не существует");
                    }
                    else b = value;
                }
                else throw new ArgumentException("Треугольник с данными длинами сторон не существует");
            }
        }
        public double C {
            get => c;
            set
            {
                if (value > 0)
                {
                    if (b != 0 && a != 0 && !isTriangleExist(a, b, value))
                    {
                        throw new ArgumentException("Треугольник с данными длинами сторон не существует");
                    }
                    else c = value;
                }
                else throw new ArgumentException("Треугольник с данными длинами сторон не существует");
            }
        }

        public double Area()
        {
            double p = Perimetr() / 2;
            return Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Perimetr()=>a + b + c;

        private bool isTriangleExist(double a,double b, double c)=>a + c > b && a + b > c && b + c > a; //проверка на существование треугольника

    }
}

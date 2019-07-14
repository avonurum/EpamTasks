using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop26
{
    class Ring
    {
        private Round inner;
        private Round outer;

        public Ring(double inR,double outR)
        {
            if(CheckRadius(inR, outR))
            {
                Inner = new Round(inR);
                Outer = new Round(outR);
            }
        }

        public bool CheckRadius(double innerR,double outerR)
        {
            if(innerR<outerR){return true;}
            else
            {
                throw new ArgumentException("Внешний радиус не может быть меньше внутреннего");
            }
        }

        public double Area=>Outer.Area-Inner.Area;

        public double SumOfLength => Outer.Length + Inner.Length;

        public Round Inner { get => inner; private set => inner = value; }
        public Round Outer { get => outer; private set => outer = value; }
    }
}

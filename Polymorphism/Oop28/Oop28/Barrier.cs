using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
   abstract class Barrier : Entity  //барьеры, ни монстр, ни персонаж не могут наступать на клетку такого типа
    {
        public Barrier(int x, int y) : base(x, y)
        {
        }
    }
}

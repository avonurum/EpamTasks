using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    abstract class Fruit : Entity
    {
        public Fruit(int x, int y) : base(x, y)
        {
        }
        abstract public void GiveSmthGood(Player y);
    }
}

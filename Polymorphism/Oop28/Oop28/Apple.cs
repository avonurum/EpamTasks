using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    class Apple:Fruit
    {
        private char sign = 'A';

        public Apple(int x, int y) : base(x, y)
        {
        }
        public override void GiveSmthGood(Player p)
        {
            if(p.Lives<Player.LiveM)
            {
                p.Lives++;
            }
        }
    }
}

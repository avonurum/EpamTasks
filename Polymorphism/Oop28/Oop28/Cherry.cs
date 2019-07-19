using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{//данный фрукт увеличивает здоровье до максимума
    class Cherry:Fruit
    {
        private char sign = 'C';

        public Cherry(int x, int y) : base(x, y)
        {
        }

        public override void GiveSmthGood(Player p)
        {
            p.Lives = Player.LiveM;
        }
    }
}

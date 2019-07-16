using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
   abstract class Monster:Entity,IMovable
    {
        protected Monster(int x, int y, char sign) : base(x, y, sign)
        {
        }

        public abstract bool CheckPosition(int x, int y);
        abstract public void HitPlayer(Player p);
        public abstract void Move(string direction);
    }
}

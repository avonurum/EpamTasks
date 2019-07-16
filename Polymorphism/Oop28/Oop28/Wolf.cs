using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    class Wolf : Monster
    {
        public Wolf(int x, int y) : base(x, y)
        {
        }

        public override void HitPlayer(Player p)
        {
            throw new NotImplementedException();
        }
    }
}

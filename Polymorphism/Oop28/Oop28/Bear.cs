using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    class Bear : Monster
    {
        public Bear(int x, int y, char sign) : base(x, y, sign)
        {
        }

        public override bool CheckPosotion(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void HitPlayer(Player p)
        {
            throw new NotImplementedException();
        }

        public override void Move(string direction)
        {
            throw new NotImplementedException();
        }
    }
}

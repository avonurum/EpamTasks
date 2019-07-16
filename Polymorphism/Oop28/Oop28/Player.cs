using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    class Player : Entity :IMovable
    {
        private int lives=5;

        public Player(int x, int y, char sign) : base(x, y, sign)
        {
        }

        public bool CheckPosition(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Move(string direction)
        {
            throw new NotImplementedException();
        }
    }
}

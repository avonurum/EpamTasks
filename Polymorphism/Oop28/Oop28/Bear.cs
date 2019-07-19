using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    class Bear : Monster
    {
        private char sign = 'B';
        public Bear(int x, int y) : base(x, y)
        {
            Sign = 'B';
        }

        public override bool CheckPosition(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void HitPlayer(Player p)
        {
            Console.WriteLine("Лапой по лицу");
            p.Lives = p.Lives - 2;
        }

        public override void Move(string direction)
        {
            throw new NotImplementedException();
        }
    }
}

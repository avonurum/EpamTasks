using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    class Wolf : Monster
    {
        private char sign = 'W';
        public Wolf(int x, int y) : base(x, y)
        {
            Sign = 'W';
        }

        public override bool CheckPosition(int x, int y)
        {
            
        }

        public override void HitPlayer(Player p)
        {
            Console.WriteLine("Кусь за бочок");
            p.Lives--;
        }

        public override void Move(string direction)
        {
            
        }
    }
}

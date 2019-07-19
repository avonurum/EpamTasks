using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    class Player : Entity,IMovable
    {
        private bool status;
        private int lives=LiveM;
        private static int liveM = 5;
        private char sign ='P';

        public Player(int x, int y) : base(x, y)
        {
           
        }

        public int Lives { get => lives; set { if (value > 0) lives = value; } }

        public bool CheckPosition(int x, int y)
        {
            throw new NotImplementedException();
        }


        public void Move(string direction)
        {
            throw new NotImplementedException();
        }
        public bool Status=>lives>0?true:false;

        public static int LiveM { get => liveM;private set => liveM = value; }
    }
}

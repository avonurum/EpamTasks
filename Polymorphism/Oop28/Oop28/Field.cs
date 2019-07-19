using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    class Field
    {
        private int x;
        private int y;
        private char[,] field;

        public Field(int x, int y)
        {

            X = x;
            Y = y;
            this.field = new char[x, y];
        }

        public int X
        {
            get => x;
            set
            {
                if (x > 0 && x < 10)
                {
                    x = value;
                }
            }
        }
        public int Y
        {
            get => y;
            set
            {
                if (y > 0 && y < 10)
                {
                    y = value;
                }
            }
        }
        public void AddGameObject(Entity[] mass)
        {
            foreach(Entity e in mass)
            {

            }
        }
    }
}

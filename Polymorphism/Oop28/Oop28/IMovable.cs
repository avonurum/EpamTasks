using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop28
{
    interface IMovable
    {
        void Move(string direction);
        bool CheckPosition(int x,int y);
    }
}

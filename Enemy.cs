using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.NewFolder2
{
    internal class Enemy
    {
        public Enemy(int x, int y, string l, string l2, string l3, string l4)
        {
            ex = x;
            ey = y;
            Char1 = l;
            Char2 = l2;
            Char3 = l3;
            Char4 = l4;
        }
        public int ex;
        public int ey;
        public string Char1;
        public string Char2;
        public string Char3;
        public string Char4;
    }
}

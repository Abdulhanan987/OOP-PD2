using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.NewFolder1
{
    internal class Player
    {
        public Player(int x , int y,string l,string l1,string l2, string l3) 
        {
            px = x; py = y;
            line1 = l;
            line2 = l1;
            line3 = l2;
            line4 = l3;
        }
        public int px;
        public int py;
        public string line1;
        public string line2;
        public string line3;
        public string line4;
    }
}

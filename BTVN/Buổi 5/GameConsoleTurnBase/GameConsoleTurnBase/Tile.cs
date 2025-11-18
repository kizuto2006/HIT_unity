using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleTurnBase
{
    internal class Tile
    {
        public Character Occupant { get; set; }
        public int PosX {  get; set; }
        public int PosY { get; set; }

        public Tile(int x,int y)
        {
            PosX = x; 
            PosY = y;
            Occupant = null;
        }

    }
}

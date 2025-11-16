using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleTurnBase
{
    internal interface Character
    {
        int PosX { get; set; }
        int PosY { get; set; }
        int Dmg { get; set; }
        int RangeAtk { get; set; }
        int Hp { get; set; }
        void Move(string direction = "");
        void TakeDmg(double dmg);
        void Attack(Tile[,] grid);
        Character CheckRangeAttack(Tile[,] grid);
    }
}

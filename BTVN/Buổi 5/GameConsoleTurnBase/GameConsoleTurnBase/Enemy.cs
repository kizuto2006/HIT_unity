using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleTurnBase
{
    internal class Enemy : Character
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Dmg { get; set; }
        public int RangeAtk { get; set; }
        public int Hp { get; set; }
        private int mapW, mapH;
        
        public Enemy(int posX,int  posY,int dmg,int range,int hp, int MapW,int MapH)
        {
            PosX = posX;
            PosY = posY;
            Dmg = dmg;
            RangeAtk = range;
            Hp = hp;
            mapH = MapH;
            mapW = MapW;
        }
        
        public void Move(string direction = "")
        {
            Random rnd = new Random();
            var directions = new (int x, int y)[]
            {
                (-1,0), (1,0), (0,-1), (0,1)
            };

            for (int i = 0; i < directions.Length; i++)
            {
                var (x, y) = directions[rnd.Next(directions.Length)];

                int nX = PosX + x;
                int nY = PosX + y;

                if(nX >= 0 && nX < mapW && nY >= 0 && nY < mapH)
                {
                    PosX = nX;
                    PosY = nY;
                    break;
                }
            }
        }

        public void TakeDmg(double dmg)
        {
            Hp -= (int)dmg;
        }

        public Character CheckRangeAttack(Tile[,] grid)
        {
            for(int dX = -RangeAtk; dX <= RangeAtk; dX++)
            {
                for (int dY = -RangeAtk; dY <= RangeAtk; dY++)
                {
                    int nX = PosX + dX;
                    int nY = PosY + dY;

                    if(nX < 0 ||  nY < 0 || nX >= grid.GetLength(0) || nY >= grid.GetLength(1))
                    {
                        continue;
                    }
                    if (grid[nX,nY].Occupant is Enemy e)
                    {
                        return e;
                    }
                }
            }
            return null;
        }

        public void Attack(Tile[,] grid)
        {
            var target = CheckRangeAttack(grid);
            if(target != null)
            {
                target.TakeDmg(Dmg);
            }
        }
    }
}

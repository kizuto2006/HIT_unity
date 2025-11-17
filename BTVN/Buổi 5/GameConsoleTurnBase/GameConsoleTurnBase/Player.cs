using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleTurnBase
{
    internal class Player : Character
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Dmg { get; set; }
        public int RangeAtk { get; set; }
        public int Hp { get; set; }

        public Weapon CurrentWeapon {  get; set; }

        public Player(int posX, int posY,int hp, Weapon w)
        {
            PosX = posX;
            PosY = posY;
            Dmg = w.Dmg;
            RangeAtk = w.RangeAttack;
            Hp = hp;
            CurrentWeapon = w;
        }

        public void Move(string direction = "")
        {
            switch (direction)
            {
                case "W": PosY--; break;
                case "S": PosY++; break;
                case "A": PosX--; break;
                case "D": PosX++; break;
            }
        }

        public void TakeDmg(double dmg)
        {
            Hp -= (int)dmg;
        }

        public Character CheckRangeAttack(Tile[,] grid)
        {
            for (int dX = -RangeAtk; dX <= RangeAtk; dX++)
            {
                for (int dY = -RangeAtk; dY <= RangeAtk; dY++)
                {
                    int nX = PosX + dX;
                    int nY = PosY + dY;

                    if (nX < 0 || nY < 0 || nX >= grid.GetLength(0) || nY >= grid.GetLength(1))
                    {
                        continue;
                    }
                    if (grid[nX, nY].Occupant is Enemy e)
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
            if (target != null)
            {
                target.TakeDmg(Dmg);
                Console.WriteLine($"Bạn đã gây {Dmg} sát thương!");
            }
        }
    }
}

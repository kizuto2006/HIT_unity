using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleTurnBase
{
    internal class GameManager
    {
        public Player p;
        public List<Enemy> es;
        public GridManager gm;

        public int Turn = 0;

        public void Start()
        {
            gm = new GridManager(10,10);
            SpawnE();

            while (true)
            {

                gm.UpdateGrid(p, es);
                Console.Clear();
                Console.WriteLine($"Player: |Hp:{p.Hp}|Range:{p.RangeAtk}|Atk:{p.Dmg}|");
                Console.WriteLine("---------------------------------------------------------------------------");
                for (int i = 0; i<es.Count;i++) 
                {
                    Console.WriteLine($"Enemy {i + 1}: |Hp:{es[i].Hp}|Range:{es[i].RangeAtk}|Atk:{es[i].Dmg}|"); 
                }
                Console.WriteLine();
                gm.DrawGrid();

                if (WinOrLose()) break;

                if (Turn == 0)
                {
                    TurnP();
                    Turn = 1 - Turn;
                }
                else
                {
                    TurnE();
                    Turn = 1 - Turn;
                }                               
            }
        }
        public void SpawnE()
        {
            Weapon sword = new Weapon("Sword", 3, 1);
            Weapon bow = new Weapon("Bow", 1, 3);
            Weapon wand = new Weapon("Magic Wand", 2, 2);
            Weapon gun = new Weapon("Freedom Power", 100, 4);//dành cho ai quá gà :b

            Console.WriteLine("Chào mừng tới với chiến trường này.");
            Console.Write("Hãy chọn một vũ khí(kiếm = 1|cung = 2|trượng = 3): ");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    p = new Player(0, 0, 30, sword);
                    break;
                case "2":
                    p = new Player(0, 0, 15, bow);
                    break;
                case "3":
                    p = new Player(0, 0, 20, wand);
                    break;
                default:
                    p = new Player(0, 0, 5, gun);
                    break;
            }

            es = new List<Enemy>
            {
                new Enemy(9,9,2,1,15,gm.Width,gm.Height),
                new Enemy(5,7,4,2,10,gm.Width,gm.Height),
                new Enemy(0,8,1,3,8,gm.Width,gm.Height)
            };
        }

        public void TurnP()
        {
            Console.Write("Nhập hướng(W/A/S/D): ");
            string direction = Console.ReadLine();
            direction = direction.ToUpper();
            p.Move(direction);
            p.Attack(gm.Grid);
        }

        public void TurnE()
        {
            foreach(Enemy e in es)
            {
                if(e.Hp > 0 )
                {
                    e.Move();
                    e.Attack(gm.Grid);
                }
            }
        }

        public bool WinOrLose()
        {
            if (p.Hp <= 0) { Console.WriteLine("Bạn đã thua 💀"); return true; }
            if (es.All(e => e.Hp <= 0)) { Console.WriteLine("Bạn đã thắng 👑"); return true; }
            return false;
        }
    }
}

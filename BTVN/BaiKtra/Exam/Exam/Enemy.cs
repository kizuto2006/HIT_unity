using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Enemy : GameEntity
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Dmg { get; set; }

        public Enemy(string name, int hp, int dmg)
        {
            Name = name;
            Hp = hp;
            Dmg = dmg;
        }

        public bool IsAlive()
        {
            if (Hp > 0) return true;
            else return false;
        }

        public override void PerformAttack(GameEntity e)
        {
            Console.WriteLine($"{Name} tấn công Bạn, gây {Dmg} sát thương! Bạn còn {e.Hp - Dmg} HP.");
            e.TakeDmg(Dmg);
        }
    }
}

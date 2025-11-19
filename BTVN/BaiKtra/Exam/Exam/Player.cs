using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Player : GameEntity
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Dmg { get; set; }

        public Player(string name, int hp, int dmg)
        {
            Name = name;
            Hp = hp;
            Dmg = dmg;
        }

       

        public override void PerformAttack(GameEntity e)
        {
            Console.WriteLine($"Bạn tấn công {e.Name}, gây {Dmg} sát thương! {e.Name} còn {e.Hp - Dmg} HP.");
            e.TakeDmg(Dmg);
        }
    }
}

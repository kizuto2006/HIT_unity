using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class GameEntity
    {
        public string Name { get; set; }
        public int Hp {  get; set; }
        public int Dmg { get; set; }
        
        public void TakeDmg(int dmg)
        {
            Hp = Hp - dmg;
        }

        public bool IsAlive()
        {
            if (Hp > 0) return true;
            else return false;
        }

        public abstract void PerformAttack(GameEntity e);
    }
}

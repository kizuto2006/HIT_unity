using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleTurnBase
{
    internal class Weapon
    {
        public string Name {  get; set; }
        public int Dmg {  get; set; }
        public int RangeAttack { get; set; }
        

        public Weapon(string name, int dmg, int rangeAttack)
        {
            Name = name;
            Dmg = dmg;
            RangeAttack = rangeAttack;
        }
    }
}

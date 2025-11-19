using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Wizard
    {
        public string Name {  get; set; }
        public int Dmg { get; set; }
        public int Mp {  get; set; }

        public Wizard() { }

        public Wizard(string name, int dmg, int mp)
        {
            Name = name;
            Dmg = dmg;
            Mp = mp;
        }

        public void CastSpell()
        {
            Console.WriteLine($"Thầy {Name} tung Vô hạ hạn gây {Dmg} sát thương, sử dụng {Mp} mana");
        }
    }
}

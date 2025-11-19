using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Character
    {
        string Name {  get; set; }
        int Hp {  get; set; }

        public Character() { }

        public Character(string name,int hp)
        {
            Name = name;
            Hp = hp;
        }

        public virtual void UseAbility()
        {
            
        }
    }
}

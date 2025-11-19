using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Warrior : Character
    {
        public string Name { get; set; }
        public int Hp {  get; set; }

        public Warrior(string name, int hp)
        {
            Name = name;
            Hp = hp;
        } 

        public override void UseAbility()
        {
            Console.WriteLine($"{Name} dùng Xoay Búa!");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Toibingu
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Wizard wizard = new Wizard("Gộ", 99, 15);
            Warrior warrior1 = new Warrior("Aisen", 30);
            Warrior warrior2 = new Warrior("Herta", 20);
            Mage mage1 = new Mage("Frieren", 15);
            Mage mage2 = new Mage("Fern", 40);
            wizard.CastSpell();
            warrior1.UseAbility();
            warrior2.UseAbility();
            mage1.UseAbility();
            mage2.UseAbility();

            Console.WriteLine();




            Player player = new Player("Anh 2",40,13);
            Enemy enemy = new Enemy("Trưởng làng", 66, 6);
            

            while (true)
            {
                int Turn = 1;
                if (Turn == 1)
                {
                    Console.WriteLine($"Đến lượt của {player.Name}:");
                    player.PerformAttack(enemy);
                    Turn = 1 - Turn;
                }
                else if (Turn == 0)
                {
                    Console.WriteLine($"Đến lượt của {enemy.Name}:");
                    enemy.PerformAttack(player);
                    Turn = 1 - Turn;
                }
                if (player.IsAlive() == false)
                {
                    Console.WriteLine($"Bạn đã thua {enemy.Name}.Sẽ có những con tró phải chả giá.");
                    break;
                }
                else if (enemy.IsAlive() == false)
                {
                    Console.WriteLine($"Bạn đã thắng {enemy.Name}.Bạn đã đạt ending ''Những bàn chân lặng lẽ'' ");
                    break;
                }
            }
            
        }
    }
}

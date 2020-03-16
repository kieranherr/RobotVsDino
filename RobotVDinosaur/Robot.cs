using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Robot
    {
        string name;
        int health;
        int energy; //Stamina
        int attackPower;
       
        public Robot(string name, int health, int energy, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            attackPower = weapon.AttackPower();
        }
       public void test()
        {
            Console.WriteLine(name);
            Console.WriteLine(health);
            Console.WriteLine(energy);
            Console.WriteLine(attackPower);
            Console.ReadLine();
        }

        
        public int LoseHealth(int healthLoss)
        {
            health = health - healthLoss;
            Console.WriteLine("You lost " + healthLoss + "HP!");
            Console.WriteLine("Your current health is now at: "+health+" HP.");
            Console.ReadLine();
            return health;
        }
    }
}

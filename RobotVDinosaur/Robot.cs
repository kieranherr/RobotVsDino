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
        string term;
        string robo;
        string c3;
        Weapon weapon;
        public Robot(string name, int health, int energy, int attackPower, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
            this.weapon = weapon;
        }
        public void Robot1() //Velociraptor
        {
            Console.WriteLine("You chose " + term + "!");
            health = 200;
            energy = 12;
            Console.WriteLine("You stats are:");
            Console.WriteLine("Health: "+health+" HP.");
            Console.WriteLine("Power Level (Stamina): " + energy);
            Console.WriteLine("Attack Power: "+attackPower);
            Console.ReadLine();
         
         
        }

        public void Robot2() //Triceratops
        {
            Console.WriteLine("You chose " + robo + "!");
            health = 150;
            energy = 8;
            Console.WriteLine("You stats are:");
            Console.WriteLine("Health: " + health + " HP.");
            Console.WriteLine("Power Level (Stamina): " + energy);
            Console.WriteLine("Attack Power: " + attackPower);
            Console.ReadLine();
        }

        public void Robot3() //Indominus Rex
        {
            Console.WriteLine("You chose " + c3 + "!");
            health = 100;
            energy = 7;
            Console.WriteLine("Your stats are:");
            Console.WriteLine("Health: " + health + " HP.");
            Console.WriteLine("Power Level (Stamina): " + energy);
            Console.WriteLine("Attack Power: " + attackPower);
            Console.ReadLine();
        }

        public int Attack()
        {
            //[0] = P90, [1] = Exacalibur Sword, [2] = Flame Thrower, [3] = Nun Chucks, [4] = Sawed Off Shotgun
            int[] attackMoves = new int[5] { 20, 15, 25, 10, 30 };
            Console.WriteLine("Which move would you like to do?");
            int choice = 0;
            Console.WriteLine("1 = P90, 2 = Excalibur Sword, 3 = Flame Thrower, 4 = Nun Chucks, 5 = Sawed Off Shotgun.");
            choice = int.Parse(Console.ReadLine()) - 1;
            attackPower = attackMoves[choice];
            switch (choice)
            {
                case 0:
                    Console.WriteLine("You chose the P90!");
                    break;
                case 1:
                    Console.WriteLine("You chose the Excalibur Sword!");
                    break;
                case 2:
                    Console.WriteLine("You chose the Flame Thrower!");
                    break;
                case 3:
                    Console.WriteLine("You chose the Nun Chucks!");
                    break;
                case 4:
                    Console.WriteLine("You chose the Sawed Off Shotgun!");
                    break;
                default:
                    Console.WriteLine("Please choose from one of the listed attacks!");
                    Console.WriteLine("1 = P90, 2 = Excalibur Sword, 3 = Flame Thrower, 4 = Nun Chucks, 5 = Sawed Off Shotgun.");
                    break;

            }
            Console.ReadLine();
            return attackMoves[choice];
        }
        public void RobotChoice()
        {
            int choice = 0;
            Console.WriteLine("Which robot would you like to use? 1 = The Terminator, 2 = RoboCop, 3 = C-3PO");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Robot1();
                    break;
                case 2:
                    Robot2();
                    break;
                case 3:
                    Robot3();
                    break;
                default:
                    Console.WriteLine("Please choose from one of the listed Robots!");
                    choice = int.Parse(Console.ReadLine());
                    break;
            }
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

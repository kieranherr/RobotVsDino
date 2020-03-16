using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Weapon
    {

        public Weapon()
        {
           
        }
        public int AttackPower()
        {
            //[0] = P90, [1] = Exacalibur Sword, [2] = Flame Thrower, [3] = Nun Chucks, [4] = Sawed Off Shotgun
            int[] attackMoves = new int[5] { 20, 15, 25, 10, 30 };
            Console.WriteLine("Which move would you like to do?");
            int choice = 0;
            Console.WriteLine("1 = P90, 2 = Excalibur Sword, 3 = Flame Thrower, 4 = Nun Chucks, 5 = Sawed Off Shotgun.");
            choice = int.Parse(Console.ReadLine()) - 1;

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
            return attackMoves[choice];

        }
    }
}

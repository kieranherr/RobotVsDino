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
        public int RobotAttack()
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
        public int DinoAttack()
        {
            //[0] = Bite, [1] = Triple Swipe, [2] = Stomp, [3] = Tail Whip, [4] = Headbutt
            int[] attackMoves2 = new int[5] { 12, 15, 20, 15, 10 };
            Console.WriteLine("Which move would you like to do?");
            int choice2 = 0;
            Console.WriteLine("1 = Bite, 2 = Triple Swipe, 3 = Stomp, 4 = Tail Whip, 5 = Headbutt.");
            choice2 = int.Parse(Console.ReadLine()) - 1;
            switch (choice2)
            {
                case 0:
                    Console.WriteLine("You chose Bite!");
                    break;      
                case 1:
                    Console.WriteLine("You chose Triple Swipe!");
                    break;
                case 2:
                    Console.WriteLine("You chose Stomp!");
                    break;
                case 3:
                    Console.WriteLine("You chose Tail Whip!");
                    break;
                case 4:
                    Console.WriteLine("You chose Headbutt!");
                    break;
                default:
                    Console.WriteLine("Please choose from one of the listed attacks!");
                    Console.WriteLine("1 = Bite, 2 = Triple Swipe, 3 = Stomp, 4 = Tail Whip, 5 = Headbutt.");
                    break;

            }
            return attackMoves2[choice2];
        }
    }
}

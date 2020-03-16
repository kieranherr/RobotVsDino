using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Dinosaur
    {
        int health;
        int energy; //Stamina
        int attackPower;
        string velo;
        string tri;
        string indo;
        public Dinosaur()
        {
            health = 0;
             
            energy = 0;
           
            attackPower = 0;

            velo = "Velociraptor";
            tri = "Triceratops";
            indo = "Indominus Rex";
        }
        public void Dino1() //Velociraptor
        {
            Console.WriteLine("You chose "+velo+"!");
            health = 100;
            energy = 12;
            Console.ReadLine();
            Attack();
        }

        public void Dino2() //Triceratops
        {
            Console.WriteLine("You chose " + tri + "!");
            health = 150;
            energy = 7;
            Console.ReadLine();
            Attack();
        }

        public void Dino3() //Indominus Rex
        {
            Console.WriteLine("You chose " + indo + "!");
            health = 200;
            energy = 5;
            Console.ReadLine();
            Attack();
        }

        public void Attack()
        {
            //[0] = Bite, [1] = Triple Swipe, [2] = Stomp, [3] = Tail Whip, [4] = Headbutt
            int[] attackMoves = new int[5] { 12, 15, 20, 15, 10 };
            Console.WriteLine("Which move would you like to do?");
            int choice = 0;
            Console.WriteLine("1 = Bite, 2 = Triple Swipe, 3 = Stomp, 4 = Tail Whip, 5 = Headbutt.");
            choice = int.Parse(Console.ReadLine()) - 1;
            attackPower = attackMoves[choice];
            switch (choice)
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
            
            Console.ReadLine();
        }
        public void DinoChoice()
        {
            int choice = 0;
            Console.WriteLine("Which dinosaur would you like to use? 1 = Velociraptor, 2 = Triceratops, 3 = Indominus Rex");
            choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Dino1();
                    break;
                    case 2:
                        Dino2();
                    break;
                    case 3:
                        Dino3();
                    break;
                    default:
                        Console.WriteLine("Please choose from one of the listed Dinosaur!");
                        choice = int.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Battlefield
    {
        public Fleet RobotFleet = new Fleet();
        public Herd DinoHerd = new Herd();
        


        public void Simulate()
        {
            int RobotHealth = RobotFleet.HealthRobot();
            int DinoHealth = DinoHerd.HealthDino();
            int DinoWin = 0;
            int RoboWin = 0;
            
                while (DinoHealth > 0 && RobotHealth > 0)
                {
                    RobotFleet.Terminator.Attack(DinoHerd.Velo);
                    DinoHerd.Velo.Attack(RobotFleet.Terminator);
                    RobotHealth = RobotFleet.HealthRobot();
                    DinoHealth = DinoHerd.HealthDino();
                }
                if (RobotHealth < DinoHealth)
                {
                RoboWin++;
                    Console.WriteLine("Robot wins!");
                    Console.ReadLine();
                }
                else
                {
                DinoWin++;
                    Console.WriteLine("dino wins!");
                    Console.ReadLine();
                }
            DinoHealth = 0;
            RobotHealth = 0;
            Console.WriteLine(DinoHealth + " " + RobotHealth);
            Console.ReadLine();
            while (DinoHealth > 0 && RobotHealth > 0)
            {
                RobotFleet.RoboCop.Attack(DinoHerd.Tri);
                DinoHerd.Tri.Attack(RobotFleet.RoboCop);
                RobotHealth = RobotFleet.HealthRobot();
                DinoHealth = DinoHerd.HealthDino();
            }
            if (RobotHealth < DinoHealth)
            {
                RoboWin++;
                Console.WriteLine("Robot wins!");
                Console.ReadLine();
            }
            else
            {
                DinoWin++;
                Console.WriteLine("dino wins!");
                Console.ReadLine();
            }
            DinoHealth = 0;
            RobotHealth = 0;
            Console.WriteLine(DinoHealth + " " + RobotHealth);
            Console.ReadLine();
            while (DinoHealth > 0 && RobotHealth > 0)
            {
                RobotFleet.C3.Attack(DinoHerd.Indo);
                DinoHerd.Indo.Attack(RobotFleet.C3);
                RobotHealth = RobotFleet.HealthRobot();
                DinoHealth = DinoHerd.HealthDino();
            }
            if (RobotHealth < DinoHealth)
            {
                RoboWin++;
                Console.WriteLine("Robot wins!");
                Console.ReadLine();
            }
            else
            {
                DinoWin++;
                Console.WriteLine("dino wins!");
                Console.ReadLine();
            }
            if(RoboWin < DinoWin)
            {
                Console.WriteLine("Dinosaurs win the war!!!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Robots win the war!!!");
                Console.ReadLine();
            }
            Console.ReadLine();
        } 
    }
}

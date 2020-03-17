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
            while (DinoHealth > 0 && RobotHealth <0) {
                RobotHealth = RobotFleet.HealthRobot();
               
                DinoHealth = DinoHerd.HealthDino();
                
                RobotFleet.Terminator.Attack(DinoHerd.Velo);
                Console.WriteLine();
                DinoHerd.Velo.Attack(RobotFleet.Terminator);

                Console.ReadLine();
            }
            if (RobotHealth > DinoHealth)
            {
                Console.WriteLine("Robot wins!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("dino wins!");
                Console.ReadLine();
            }
        }
    }
}

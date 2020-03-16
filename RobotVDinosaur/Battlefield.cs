using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Battlefield
    {
        static void Main(string[] args)
        {
            Dinosaur dino = new Dinosaur();
            Robot robo = new Robot();
            int roboAttack;
            int dinoAttack;
            roboAttack = robo.Attack();
            robo.RobotChoice();
            int robotHealth = robo.LoseHealth(roboAttack);
        }
    }
}

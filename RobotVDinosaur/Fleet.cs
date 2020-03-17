using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Fleet
    {
        Weapon weapon = new Weapon();
        public Robot Terminator;
        public Robot RoboCop;
        public Robot C3;
        public Fleet()
        {
            Console.WriteLine("You are creating The Terminator!");
            Terminator = new Robot("Terminator", 200, 7, weapon);
            Console.WriteLine("You are creating RoboCop");
            RoboCop = new Robot("RoboCop", 150, 10, weapon);
            Console.WriteLine("You are creating C-3PO");
             C3 = new Robot("C-3PO", 100, 12, weapon);
        }
        public void test()
        {
            Terminator.test();

        }
        public  int HealthRobot()
        {
            return Terminator.PassHealthRobot();
        }
    }
}

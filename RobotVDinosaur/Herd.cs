using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Herd
    {
        Weapon weapon = new Weapon();
        Robot Bender;
        Robot Ultro;
        Robot Terminator;
        public Herd()
        {
            Bender = new Robot("Velo", 150, 12, weapon);
            //Ultro = new Robot();
            //Terminator = new Robot();
        }
        public void test()
        {
            Bender.test();
        }
    }
}

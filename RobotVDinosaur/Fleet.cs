﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Fleet
    {
        Weapon weapon = new Weapon();
        Robot Bender;
        Robot Ultro;
        Robot Terminator;
        public Fleet()
        {
            Bender = new Robot("Bender", 100, 25, weapon);
            //Ultro = new Robot();
            //Terminator = new Robot();
        }
        public void test()
        {
            Bender.test();
        }

    }
}

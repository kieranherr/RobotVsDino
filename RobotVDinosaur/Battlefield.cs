using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Battlefield
    {
        public Fleet test2 = new Fleet();
        public Herd test3 = new Herd();
        
   

        public void Simulate()
        {

            test2.Terminator.Attack(test3.Velo);
        }
    }
}

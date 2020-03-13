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
        public Dinosaur()
        {
            health = 0;
             
            energy = 0;
           
            attackPower = 0;
        }
          public void Dino1() //Velociraptor
        {
            health = 100;
            energy = 12;
        }

        public void Dino2() //Triceratops
        {
            health = 150;
            energy = 7;
        }

        public void Dino3() //Indominus Rex
        {
            health = 200;
            energy = 5;
        }
    }
}

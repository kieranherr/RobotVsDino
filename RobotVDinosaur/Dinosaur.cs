﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Dinosaur
    {
        string name;
        int health;
        int energy; //Stamina
        int attackPower;

        public Dinosaur(string name, int health, int energy, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            attackPower = weapon.DinoAttack();
        }
        public void test()
        {
            Console.WriteLine(name);
            Console.WriteLine(health);
            Console.WriteLine(energy);
            Console.WriteLine(attackPower);
            Console.ReadLine();
        }


     
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVDinosaur
{
    class Robot
    {
        string name;
        int health;
        int energy; //Stamina
        int attackPower;
        Weapon attack = new Weapon();

       
        public Robot(string name, int health, int energy, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            attackPower = weapon.RobotAttack();
        }
       public void test()
        {
            Console.WriteLine(name);
            Console.WriteLine(health);
            Console.WriteLine(energy);
            Console.WriteLine(attackPower);
            Console.ReadLine();
        }


        public void Attack(Dinosaur Flamingo)
        {
            Flamingo.health -= attackPower;
            energy--;
        }
    }
}

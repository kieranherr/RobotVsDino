﻿using System;

namespace RobotVDinosaur
{
    class Herd
    {
        Weapon weapon = new Weapon();
        public Dinosaur Velo;
        public Dinosaur Tri;
        public Dinosaur Indo;
        public Herd()
        {

            Console.WriteLine("You are creating your Velociraptor!");
            Velo = new Dinosaur("Velociraptor", 100, 12, weapon);
            Console.WriteLine("You are creating your Triceratops!");
            Tri = new Dinosaur("Triceratops", 150, 7, weapon);
            Console.WriteLine("You are creating your Indominus Rex!");
            Indo = new Dinosaur("Indominus Rex", 200, 5, weapon);

        }

        public int HealthDino()
        {
            return Velo.PassHealthDino();
        }

    }
}

using System;

namespace RobotVDinosaur
{
    class Robot
    {
        string name;
        public int health;
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


        public void Attack(Dinosaur Bender)
        {
            Bender.health -= attackPower;
            energy--;
            Console.WriteLine("Robots health is now: " + Bender.health);
            Console.ReadLine();
        }

        public int PassHealthRobot()
        {
            return health;
        }

    }
}

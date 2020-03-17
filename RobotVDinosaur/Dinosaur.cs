using System;

namespace RobotVDinosaur
{
    class Dinosaur
    {
        string name;
        public int health;
        int energy; //Stamina
        int attackPower;

        public Dinosaur(string name, int health, int energy, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            attackPower = weapon.DinoAttack();
        }
        public void Attack(Robot Terminator)
        {
            Terminator.health -= attackPower;
            energy--;
            Console.WriteLine("Dinos health is now: " + Terminator.health);
            Console.ReadLine();
        }
        public int PassHealthDino()
        {
            return health;
        }

    }
}

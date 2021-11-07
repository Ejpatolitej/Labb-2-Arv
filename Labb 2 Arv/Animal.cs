using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    public class Animal
    {
        public string Species;
        public int Legs;
        public bool Wings;
        public string Diet;
        public bool Mammal;

        public Animal() : this(null, 0, false, null, false) { }

        public Animal(string Species, int Legs, bool Wings, string Diet, bool Mammal)
        {
            this.Species = Species;
            this.Legs = Legs;
            this.Wings = Wings;
            this.Diet = Diet;
            this.Mammal = Mammal;
        }

        public void MoveForward(string animal)
        {
            Console.WriteLine(animal + " is moving forward *Zoooom*");
        }

        public void Eating(string animal)
        {
            Console.WriteLine(animal + " is eating *Omnomnom*");
        }

        public void Sleeping(string animal)
        {
            Console.WriteLine(animal + " is sleeping *ZZzzZZzzZZzz*");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal is making a sound!");
        }

        public void PrintAnimal()
        {
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Amount of legs: " + Legs);
            Console.WriteLine("Does it have wings: " + Wings);
            Console.WriteLine("What does it eat: " + Diet);
            Console.WriteLine("Is it a mammal: " + Mammal);
        }
    }
}

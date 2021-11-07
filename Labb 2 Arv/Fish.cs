using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    public class Fish : Animal
    {
        public bool Predator = false;

        public Fish() : this(false) { Species = "Fish"; Legs = 4; Wings = false; Diet = "Fish food"; Mammal = false; }

        public Fish(bool Predator)
        {
            this.Predator = Predator;
        }

        public void Swimming()
        {
            Console.WriteLine("The fish is swimming. Just keep swimming, just keep swimming.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Fish goes *Blub blub*");
        }

        public void PrintFish()
        {
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Amount of legs: " + Legs);
            Console.WriteLine("Does it have wings: " + Wings);
            Console.WriteLine("What does it eat: " + Diet);
            Console.WriteLine("Is it a mammal: " + Mammal);
            Console.WriteLine("Is it a predator: " + Predator);
        }
    }
}

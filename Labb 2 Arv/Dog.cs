using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    public class Dog : Animal
    {
        public string HairType = "Long";

        public Dog() : this("Long") { Species = "Dog"; Legs = 4; Wings = false; Diet = "Meat"; Mammal = true; }

        public Dog(string HairType)
        {
            this.HairType = HairType;
        }

        public void Fetch(bool ThrowStick)
        {
            if (ThrowStick == true)
            {
                Console.WriteLine("The dog goes to fetch the stick! Good dog!");
            }
            else
            {
                Console.WriteLine("The dog would love it if you throw the stick!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog goes *Woof woof*");
        }

        public void PrintDog()
        {
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Amount of legs: " + Legs);
            Console.WriteLine("Does it have wings: " + Wings);
            Console.WriteLine("What does it eat: " + Diet);
            Console.WriteLine("Is it a mammal: " + Mammal);
            Console.WriteLine("Is it long- or shorthair: " + HairType);
        }
    }
}

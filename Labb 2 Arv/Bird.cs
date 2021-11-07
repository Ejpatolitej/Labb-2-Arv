using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    public class Bird : Animal
    {
        public bool Flying;

        public Bird() : this(true) { Species = "Bird"; Legs = 2; Wings = true; Diet = "Seeds"; Mammal = false; }

        public Bird(bool Flying)
        {
            this.Flying = Flying;
        }

        public void WingFlap()
        {
            Console.WriteLine("The bird is flapping it's wings *flap flap*");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bird goes *Chirp chirp*");
        }

        public void PrintBird()
        {
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Amount of legs: " + Legs);
            Console.WriteLine("Does it have wings: " + Wings);
            Console.WriteLine("What does it eat: " + Diet);
            Console.WriteLine("Is it a mammal: " + Mammal);
            Console.WriteLine("Can it fly: " + Flying);
        }
    }
    public class Eagle : Bird
    {
        public int FreedomLevel;
        public Eagle(int freedomLevel)
        {
            this.FreedomLevel = freedomLevel;
            Species = "Eagle";
            Diet = "Smaller animals";
        }
        public void SymbolOfUSA()
        {
            if (FreedomLevel == 100)
            {
                Console.WriteLine("AMERICA! F#¤K YEAH!");
            }
            else
            {
                Console.WriteLine("America, Meh...");
            }
        }
        public void PrintEagle()
        {
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Amount of legs: " + Legs);
            Console.WriteLine("Does it have wings: " + Wings);
            Console.WriteLine("What does it eat: " + Diet);
            Console.WriteLine("Is it a mammal: " + Mammal);
            Console.WriteLine("Can it fly: " + Flying);
            Console.WriteLine("Freedom level: " + FreedomLevel + "%");
        }

    }
    public class Penguin : Bird
    {
        public bool Swimming = true;
        public Penguin()
        {
            Species = "Penguin";
            Diet = "Fish";
            Flying = false;
        }

        public void HappyFeet()
        {
            Console.WriteLine("Penguin can dance! Look at him tap his feet! *Tap tap*");
        }
        public void PrintPenguin()
        {
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Amount of legs: " + Legs);
            Console.WriteLine("Does it have wings: " + Wings);
            Console.WriteLine("What does it eat: " + Diet);
            Console.WriteLine("Is it a mammal: " + Mammal);
            Console.WriteLine("Can it fly: " + Flying);
            Console.WriteLine("Can it swim: " + Swimming);
        }
    }
}

using System;

namespace Labb_2_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal()
            {
                Species = "Monster",
                Legs = 10,
                Wings = true,
                Diet = "Humans",
                Mammal = true
            };
            animal.PrintAnimal();
            animal.MoveForward(animal.Species);
            animal.Eating(animal.Species);
            animal.Sleeping(animal.Species);
            animal.MakeSound();
            Console.WriteLine();

            Bird bird = new Bird();
            bird.PrintBird();
            bird.WingFlap();
            bird.MakeSound();
            Console.WriteLine();

            Penguin penguin = new Penguin();
            penguin.PrintPenguin();
            penguin.HappyFeet();
            Console.WriteLine();

            Eagle eagle = new Eagle(100);
            eagle.PrintEagle();
            eagle.SymbolOfUSA();
            Console.WriteLine();

            Fish fish = new Fish();
            fish.PrintFish();
            fish.MakeSound();
            fish.Swimming();
            Console.WriteLine();

            Dog dog = new Dog();
            dog.PrintDog();
            dog.MakeSound();
            dog.Fetch(true);
        }
    }
}

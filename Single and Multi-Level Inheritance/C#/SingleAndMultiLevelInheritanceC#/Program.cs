using System;

namespace InheritanceExample
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking...");
        }
    }

    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy is weeping...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started...\n");

            Dog dog = new Dog();
            Console.WriteLine("Single Inheritance Example:");
            dog.Eat();
            dog.Bark();

            Console.WriteLine();

            Puppy puppy = new Puppy();
            Console.WriteLine("Multi-Level Inheritance Example:");
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}

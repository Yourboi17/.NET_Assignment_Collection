using System;

interface IAnimal
{
    void Speak();
}

interface IMammal : IAnimal
{
    void Walk();
}

class Dog : IMammal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }

    public void Walk()
    {
        Console.WriteLine("The dog walks on four legs.");
    }
}

class Program
{
    static void Main()
    {
        IMammal myDog = new Dog();
        myDog.Speak();
        myDog.Walk();

        Console.ReadLine();
    }
}

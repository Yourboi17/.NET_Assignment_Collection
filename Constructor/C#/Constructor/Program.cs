using System;

class Person
{
    private string name;
    private int age;

    public Person()
    {
        name = "Unknown";
        age = 0;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person();
        Console.WriteLine("Using Default Constructor:");
        person1.DisplayDetails();

        Person person2 = new Person("Alice", 25);
        Console.WriteLine("\nUsing Parameterized Constructor:");
        person2.DisplayDetails();

        Console.ReadLine();
    }
}

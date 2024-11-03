using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add("Apple");
        arrayList.Add("Banana");
        arrayList.Add("Cherry");

        Console.WriteLine("ArrayList contents:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("Apple", 1);
        dictionary.Add("Banana", 2);
        dictionary.Add("Cherry", 3);

        Console.WriteLine("\nDictionary contents:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        Console.ReadLine();
    }
}

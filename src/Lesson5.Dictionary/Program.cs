﻿using System.Text;

namespace Lesson5.Dictionary;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Dictionary dictionary = new Dictionary();

        Console.WriteLine(dictionary["книга"]);
        Console.WriteLine(dictionary["дім"]);
        Console.WriteLine(dictionary["ручка"]);
        Console.WriteLine(dictionary["стіл"]);
        Console.WriteLine(dictionary["олівець"]);
        Console.WriteLine(dictionary["яблуко"]);
        Console.WriteLine(dictionary["сонце"]);

        Console.WriteLine(new string('-', 20));

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(dictionary[i]);
        }

        // Delay.
        Console.ReadKey();
    }
}
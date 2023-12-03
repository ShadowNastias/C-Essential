namespace Lesson4.Array;

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array N:");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[N];

        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 100);
        }

        int max = array.Max();
        int min = array.Min();

        int sum = array.Sum();
        double average = array.Average();

        Console.WriteLine($"Largest value: {max}");
        Console.WriteLine($"Smallest value: {min}");
        Console.WriteLine($"Total sum: {sum}");
        Console.WriteLine($"Average value: {average}");
        
        Console.WriteLine("Odd values in the array:");
        foreach (var value in array)
        {
            if (value % 2 != 0)
            {
                Console.WriteLine(value);
            }
        }
    }
}
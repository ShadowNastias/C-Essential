using System;
using System.Threading;

namespace Lesson13.Recursion;

class Program
{
    static void Main()
    {
        Console.WriteLine("Початок програми.");

        // Створюємо новий потік і викликаємо метод в ньому.
        Thread thread = new Thread(RecursiveMethod);
        thread.Start(1);

        // Чекаємо завершення потоку.
        thread.Join();

        Console.WriteLine("Кінець програми.");
    }

    static void RecursiveMethod(object data)
    {
        int depth = (int)data;
        Console.WriteLine($"Початок рекурсивного методу на глибині {depth}.");

        if (depth < 5) // Перевірка глибини рекурсії.
        {
            // Створюємо новий потік і викликаємо метод в ньому.
            Thread thread = new Thread(RecursiveMethod);
            thread.Start(depth + 1);

            // Чекаємо завершення нового потоку.
            thread.Join();
        }

        Console.WriteLine($"Кінець рекурсивного методу на глибині {depth}.");
    }
}
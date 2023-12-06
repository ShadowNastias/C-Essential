namespace Lesson16.CustomDate;

class Program
{
    static void Main()
    {
        CustomDate date1 = new CustomDate(1, 1, 2020);
        CustomDate date2 = new CustomDate(1, 1, 2021);

        int diff = date2 - date1;
        Console.WriteLine($"Difference between {date1} and {date2} is {diff} days.");

        CustomDate newDate = date1 + 30;
        Console.WriteLine($"{date1} plus 30 days is {newDate}.");
    }
}
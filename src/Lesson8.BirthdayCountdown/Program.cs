namespace Lesson8.BirthdayCountdown;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть дату народження (формат: рік-місяць-день): ");
        string input = Console.ReadLine();

        try
        {
            DateTime birthday = DateTime.Parse(input);
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            int daysUntilBirthday = (nextBirthday - today).Days;

            Console.WriteLine($"Днів до наступного дня народження: {daysUntilBirthday}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неправильний формат дати. Спробуйте ще раз.");
        }
    }
}
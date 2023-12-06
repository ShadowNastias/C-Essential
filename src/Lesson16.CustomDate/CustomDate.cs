namespace Lesson16.CustomDate;

class CustomDate
{
    public int Day { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }

    public CustomDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public static int operator -(CustomDate d1, CustomDate d2)
    {
        DateTime date1 = new DateTime(d1.Year, d1.Month, d1.Day);
        DateTime date2 = new DateTime(d2.Year, d2.Month, d2.Day);
        TimeSpan diff = date1 - date2;
        return Math.Abs(diff.Days);
    }

    public static CustomDate operator +(CustomDate d, int days)
    {
        DateTime date = new DateTime(d.Year, d.Month, d.Day);
        DateTime newDate = date.AddDays(days);
        return new CustomDate(newDate.Day, newDate.Month, newDate.Year);
    }

    public override string ToString()
    {
        return $"{Day:00}/{Month:00}/{Year}";
    }
}
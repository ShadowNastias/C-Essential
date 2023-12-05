namespace Lesson15.Worker;

struct Worker
{
    public string FullName; // Прізвище та ініціали
    public string Position; // Посада
    public int YearOfEmployment; // Рік надходження на роботу

    public Worker(string fullName, string position, int yearOfEmployment)
    {
        FullName = fullName;
        Position = position;
        YearOfEmployment = yearOfEmployment;
    }
}
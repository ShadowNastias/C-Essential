namespace Lesson8.Accountant;

class Program
{
    static void Main(string[] args)
    {
        Accountant acc = new Accountant();

        // Припустимо, менеджер відпрацював 170 годин цього місяця
        bool isEligibleForBonus = acc.AskForBonus(Post.Manager, 170);

        Console.WriteLine("Чи належить менеджеру премія: " + isEligibleForBonus);
    }
}
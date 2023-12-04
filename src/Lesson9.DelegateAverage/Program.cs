namespace DelegateAverage;

class Program
{
    // Делегат, що повертає значення типу int
    delegate int RandomNumberDelegate();

    static void Main(string[] args)
    {
        // Створення масиву делегатів
        RandomNumberDelegate[] delegates = new RandomNumberDelegate[]
        {
            () => new Random().Next(1, 100),
            () => new Random().Next(1, 100),
            () => new Random().Next(1, 100)
        };

        // Анонімний метод для обчислення середнього значення
        Func<RandomNumberDelegate[], double> averageCalculator = delegate(RandomNumberDelegate[] dels)
        {
            int sum = 0;
            foreach (var del in dels)
            {
                sum += del();
            }

            return sum / (double)dels.Length;
        };

        // Виклик анонімного методу та виведення результату
        double average = averageCalculator(delegates);
        Console.WriteLine($"Середнє арифметичне: {average}");
    }
}
namespace Lesson9.DelegateAverage;

class Program
{
    delegate int RandomNumberDelegate();

    static void Main(string[] args)
    {
        RandomNumberDelegate[] delegates = new RandomNumberDelegate[]
        {
            () => new Random().Next(1, 100),
            () => new Random().Next(1, 100),
            () => new Random().Next(1, 100)
        };

        Func<RandomNumberDelegate[], double> averageCalculator = delegate(RandomNumberDelegate[] dels)
        {
            int sum = 0;
            foreach (var del in dels)
            {
                sum += del();
            }

            return sum / (double)dels.Length;
        };

        double average = averageCalculator(delegates);
        Console.WriteLine($"Середнє арифметичне: {average}");
    }
}
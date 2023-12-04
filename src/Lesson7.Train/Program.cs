namespace Lesson7.Train;

class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[8];
        for (int i = 0; i < trains.Length; i++)
        {
            Console.WriteLine("Введіть назву пункту призначення:");
            string destination = Console.ReadLine();

            Console.WriteLine("Введіть номер поїзда:");
            int trainNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть час відправлення (гг:хх):");
            DateTime departureTime = DateTime.Parse(Console.ReadLine());

            trains[i] = new Train(destination, trainNumber, departureTime);
        }

        Array.Sort(trains, (train1, train2) => train1.TrainNumber.CompareTo(train2.TrainNumber));

        Console.WriteLine("Введіть номер поїзда для отримання інформації:");
        int searchNumber = int.Parse(Console.ReadLine());

        Train? searchTrain = trains.FirstOrDefault(t => t.TrainNumber == searchNumber);
        if (searchTrain.HasValue)
        {
            Console.WriteLine($"Поїзд {searchTrain.Value.TrainNumber}: {searchTrain.Value.Destination}, час відправлення {searchTrain.Value.DepartureTime}");
        }
        else
        {
            Console.WriteLine("Поїзд з таким номером не знайдено.");
        }
    }
}
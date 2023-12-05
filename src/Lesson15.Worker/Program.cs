namespace Lesson15.Worker;

class Program
{
    static void Main()
    {
        List<Worker> workers = new List<Worker>();

        Console.WriteLine("Enter information for 5 workers:");

        while (workers.Count < 5)
        {
            try
            {
                Console.Write("Enter full name: ");
                string fullName = Console.ReadLine();

                Console.Write("Enter position: ");
                string position = Console.ReadLine();

                Console.Write("Enter year of employment: ");
                if (!int.TryParse(Console.ReadLine(), out int yearOfEmployment) || yearOfEmployment < 1900 || yearOfEmployment > DateTime.Now.Year)
                {
                    throw new FormatException("Year of employment is not in a valid format.");
                }

                workers.Add(new Worker(fullName, position, yearOfEmployment));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        workers = workers.OrderBy(w => w.FullName).ToList();

        Console.Write("Enter the minimum number of years to display the worker: ");
        int years = int.Parse(Console.ReadLine());
        int currentYear = DateTime.Now.Year;

        foreach (var worker in workers)
        {
            if ((currentYear - worker.YearOfEmployment) > years)
            {
                Console.WriteLine($"{worker.FullName}, Position: {worker.Position}, Years of Work: {currentYear - worker.YearOfEmployment}");
            }
        }
    }
}
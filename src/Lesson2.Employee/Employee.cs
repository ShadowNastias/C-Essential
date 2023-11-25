namespace Lesson2.Employee
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string position;
        private int experience;
        
        public Employee(string firstName, string lastName, string position, int experience)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.experience = experience;
        }
        
        public double CalculateSalary()
        {
            double baseSalary = 10000; 
            double experienceCoefficient = 1 + experience * 0.05;
            return baseSalary * experienceCoefficient;
        }
        
        public double CalculateTax()
        {
            double salary = CalculateSalary();
            return salary * 0.18; // Suppose the tax is 18%
        }
        
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
            Console.WriteLine($"Tax: {CalculateTax()}");
        }
    }
}
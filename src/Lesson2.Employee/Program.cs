namespace Lesson2.Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(
                "John", 
                "Doe", 
                "Developer", 
                5);

            employee.DisplayEmployeeInfo();
        }
    }
}
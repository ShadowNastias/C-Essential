namespace Lesson2.User
{
    public class User
    { 
        private string Login { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        
        private readonly DateTime DateOfSurvey;
        
        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DateOfSurvey = DateTime.Now;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Date of Survey: {DateOfSurvey.ToShortDateString()}");
        }
    }
}
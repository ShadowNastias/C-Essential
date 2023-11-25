namespace Lesson2.User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("user123", "John", "Doe", 30);

            user.DisplayInfo();
        }
    }
}
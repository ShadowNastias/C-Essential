namespace Lesson1.AdressBook
{
    class Program
    { 
        static void Main(string[] args)
        {
            Address adress_1 = new Address(64300, "Ukraine", "Izium", "Slavinskaya", 18, 1);
            adress_1.ShowAdress();
        }
    }
}
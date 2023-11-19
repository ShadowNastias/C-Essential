namespace Lesson1.Rectangle
{
    class Program
    {
        // Defining the entry point of the program.
        static void Main(string[] args)
        {
            // Asking the user to enter the length of side 1.
            Console.Write("Ent1er the length of side 1: ");

            // Reading the user's input and converting it to a double.
            // Double format's like in our Area/PerimeterCalculator methods.
            double side1 = Convert.ToDouble(Console.ReadLine());

            // Asking the user to enter the length of side 1.
            Console.Write("Enter the length of side 2: ");

            // Converting it to a double.
            double side2 = Convert.ToDouble(Console.ReadLine());

            // Creating a new instance of the Lesson1.Rectangle class, passing the lengths of the sides as arguments.
            Rectangle rectangle = new Rectangle(side1, side2);

            // Displaying the area of the rectangle.
            Console.WriteLine($"Area: {rectangle.Area}");

            // Displaying the perimeter of the rectangle.
            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
        }
    }
}
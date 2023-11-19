namespace Lesson1.Rectangle
{

// Defining a public class with formulas for area and perimeter for rectangle.
    public class Rectangle
    {
        // Declaring private fields.
        private double side1;
        private double side2;

        // Defining a constructor for the Lesson1.Rectangle class.
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Defining public read-only properties (Area & Perimeter). Just to make code more readable.
        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        // Defining private methods (AreaCalculator & PerimeterCalculator) that calculates area and perimeter.
        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
}
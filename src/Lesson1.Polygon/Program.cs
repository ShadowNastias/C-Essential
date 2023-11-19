namespace Lesson1.Polygon
{
    class Program
    { 
        static void Main(string[] args)
        {
            // Creating points.
            Point point1 = new Point(0, 0, "Point1");
            Point point2 = new Point(0, 5, "Point2");
            Point point3 = new Point(5, 5, "Point3");

            // Creating a figure.
            Figure figure = new Figure(point1, point2, point3);

            // Calculating and displaying the perimeter.
            figure.PerimeterCalculator();
        }
    }
}
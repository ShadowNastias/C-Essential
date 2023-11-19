namespace Lesson1.Polygon
{
    public class Figure
    {
        private Point[] points;

        // Constructor for 3 points
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        // Constructor for 4 points
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        // Constructor for 5 points
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        double LengthSide(Point A, Point B)
        {
            // The difference between the x coordinates.
            double xDiff = B.X - A.X;

            // The difference between the y coordinates.
            double yDiff = B.Y - A.Y;

            // Calculation of the distance according to the formula.
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            // Loop through each pair of adjacent points and add the length of each side to the perimeter.
            for (int i = 0; i < points.Length; i++)
            {
                // Get the index of the next point, considering that after the last point we return to the first point.
                int nextIndex = (i + 1) % points.Length;

                // Add the length of the side to the perimeter.
                perimeter += LengthSide(points[i], points[nextIndex]);
            }

            Console.WriteLine($"The perimeter of the {points.Length}-sided polygon is: {perimeter}");
        }
    }
}
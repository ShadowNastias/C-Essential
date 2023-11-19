namespace Lesson1.Polygon
{
    public class Point
    {
        private int _x;
        private int _y;
        private string? _name;

        public Point(int x, int y, string name)
        {
            this._x = x;
            this._y = y;
            this._name = name;
        }

        // Defining public read-only properties (x, y & name). Just to make code more readable.
        public int X => _x;
        public int Y => _y;
        public string Name => _name;
    }
}
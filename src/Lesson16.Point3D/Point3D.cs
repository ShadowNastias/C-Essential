namespace Lesson16.Point3D;

struct Point3D
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point3D operator +(Point3D a, Point3D b)
    {
        return new Point3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}
namespace Lesson16.Point3D;

class Program
{
    static void Main()
    {
        Point3D point1 = new Point3D(1, 2, 3);
        Point3D point2 = new Point3D(4, 5, 6);

        Point3D sum = point1 + point2;
        Console.WriteLine($"{point1} + {point2} = {sum}");
    }
}
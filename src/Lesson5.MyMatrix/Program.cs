namespace Lesson5.MyMatrix;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Original matrix:");
        MyMatrix matrix = new MyMatrix(4, 5);
        matrix.DisplayMatrix();

        Console.WriteLine("\nMatrix after resizing to 3x3:");
        matrix.ChangeSize(3, 3);
        matrix.DisplayMatrix();

        Console.WriteLine("\nMatrix after resizing to 2x4:");
        matrix.ChangeSize(2, 4);
        matrix.DisplayMatrix();
    }
}
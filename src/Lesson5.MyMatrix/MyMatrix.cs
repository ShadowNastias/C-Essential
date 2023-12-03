namespace Lesson5.MyMatrix;

using System;

public class MyMatrix
{
    private int[,] matrix;

    public MyMatrix(int rows, int cols)
    {
        matrix = new int[rows, cols];
        FillMatrix();
    }

    public void FillMatrix()
    {
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(1, 10); // Random values between 1 and 10
            }
        }
    }

    public void ChangeSize(int newRows, int newCols)
    {
        var newMatrix = new int[newRows, newCols];
        for (int i = 0; i < Math.Min(newRows, matrix.GetLength(0)); i++)
        {
            for (int j = 0; j < Math.Min(newCols, matrix.GetLength(1)); j++)
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }
        matrix = newMatrix;
    }

    public void DisplayMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
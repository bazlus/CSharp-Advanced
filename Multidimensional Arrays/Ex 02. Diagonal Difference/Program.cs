using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int matrixSize = int.Parse(Console.ReadLine());
        var matrix = new double[matrixSize, matrixSize];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            var rowEl = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = rowEl[col];
            }
        }

        double primaryDiagonal = 0;
        double secondDiagonal = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            primaryDiagonal += matrix[row, row];
            secondDiagonal += matrix[row, matrix.GetLength(0) - 1 - row];
        }

        double absDiff = Math.Abs(primaryDiagonal - secondDiagonal);

        Console.WriteLine(absDiff);
    }
}


using System;
using System.Linq;

namespace Lab_Primary_Diagonal__
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixSize][];

            for (int i = 0; i < matrixSize; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int primaryDiagonalSum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                primaryDiagonalSum += matrix[i][i];
            }
            Console.WriteLine(primaryDiagonalSum);
        }
    }
}

using System;
using System.Linq;

namespace Lab_Sum_Matrix_Colums
{
    class Program
    {
        static void Main()
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[][] matrix = new int[matrixSizes[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            for (int col = 0; col < matrix[0].Length; col++)
            {
                double currentCol = 0;
                for (int row = 0; row < matrix.Length; row++)
                {
                    currentCol += matrix[row][col];
                }

                Console.WriteLine(currentCol);
            }
        }
    }
}

using System;
using System.Linq;

namespace Lab_Square_With_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var matrix = new int[matrixSizes[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            }

            int maxSquareSum = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.Length - 1 ; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1 ; col++)
                {

                    int currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] +
                                     matrix[row + 1][col + 1];
                    if (currentSum > maxSquareSum)
                    {
                        maxSquareSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol + 1]}\n{matrix[maxRow+1][maxCol]} {matrix[maxRow+1][maxCol+1]}\n{maxSquareSum}");
        }
    }
}

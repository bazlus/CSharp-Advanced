using System;
using System.Linq;

namespace Ex_04._Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new long[sizes[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
            }

            long maxSum = int.MinValue;
            long maxRowIndex = 0;
            long maxColIndex = 0;

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    long currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                     matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                                     matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                    if (currentSum > maxSum)
                    {
                        maxColIndex = col;
                        maxRowIndex = row;  
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);
            Console.WriteLine($"{matrix[maxRowIndex][maxColIndex]} {matrix[maxRowIndex][maxColIndex + 1]} {matrix[maxRowIndex][maxColIndex + 2]}\n{matrix[maxRowIndex + 1][maxColIndex]} {matrix[maxRowIndex + 1][maxColIndex + 1]} {matrix[maxRowIndex + 1][maxColIndex + 2]}\n{matrix[maxRowIndex + 2][maxColIndex]} {matrix[maxRowIndex + 2][maxColIndex + 1]} {matrix[maxRowIndex+ 2][maxColIndex+ 2]}");
        }
    }
}

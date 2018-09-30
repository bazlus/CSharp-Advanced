using System;
using System.Linq;

namespace Ex_03._Squares_in_Matrix
{
    class Program
    {
        public static string[][] matrix;
        static void Main(string[] args)
        {
            // Read sizes
            var sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            matrix = new string[sizes[0]][];

            // Fill up matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            // Find squares
            int countOfSquares = 0;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    if (isSquare(row,col))
                    {
                        countOfSquares++;
                    }
                }
            }

            Console.WriteLine(countOfSquares);
        }

        public static bool isSquare(int row, int col)
        {
            if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col] == matrix[row + 1][col + 1] && matrix[row][col] == matrix[row + 1][col])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

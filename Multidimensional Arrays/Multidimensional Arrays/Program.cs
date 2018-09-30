using System;
using System.Linq;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[][] matrix = new int[matrixSizes[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            }

            int sum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    sum += matrix[row][col];
                }
            }

            Console.WriteLine(matrixSizes[0]);
            Console.WriteLine(matrixSizes[1]);
            Console.WriteLine(sum);
        }
    }
}

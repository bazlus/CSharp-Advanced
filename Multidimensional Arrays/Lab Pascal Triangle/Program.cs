using System;
using System.Numerics;

namespace Lab_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            var matrix = new long[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++)
            {
                matrix[i] = new long[i+1];
            }

            long numberToAdd = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (col == 0 || col == matrix[row].Length - 1 || row == 1)
                    {
                        numberToAdd = 1;
                    }
                    else
                    {
                        numberToAdd = matrix[row - 1][col] + matrix[row - 1][col - 1];
                    }


                    matrix[row][col] = numberToAdd;

                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ',row));
            }

        }
    }
}

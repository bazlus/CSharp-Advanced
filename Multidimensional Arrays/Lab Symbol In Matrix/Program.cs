using System;

namespace Lab_Symbol_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            char toFind = Console.ReadLine()[0];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == toFind)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{toFind} does not occur in the matrix");
        }
    }
}

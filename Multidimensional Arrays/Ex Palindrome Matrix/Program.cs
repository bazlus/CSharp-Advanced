using System;
using System.Linq;

namespace Ex_Palindrome_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var matrix = new string[matrixSizes[0]][];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new string[matrixSizes[1]];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    string firstLast = alphabet[row].ToString();
                    string middle = alphabet[row + col].ToString();
                    matrix[row][col] = $"{firstLast}{middle}{firstLast}";
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ',row));
            }
        }
    }
}

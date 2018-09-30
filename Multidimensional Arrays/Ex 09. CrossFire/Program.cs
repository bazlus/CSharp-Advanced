using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ex_09._CrossFire
{
    class Program
    {
        public static int[][] matrix;
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            matrix = new int[sizes[0]][];
            InitaliazeMatrix(sizes, matrix);

            var input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                Shoot(input);
                ModifyMatrix(matrix);
                input = Console.ReadLine();

            }

            Print(matrix);
        }

        private static void ModifyMatrix(int[][] ints)
        {
            var queue = new Queue<int>();
            var zeros = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] != 0)
                    {
                        queue.Enqueue(matrix[row][col]);
                    }
                    else
                    {
                        zeros++;
                    }
                }
                matrix[row] = new int[matrix[row].Length - zeros];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = queue.Dequeue();
                }

                zeros = 0;
            }
        }

        private static void Shoot(string input)
        {
            var tokens = input.Split(' ').Select(int.Parse).ToArray();
            int targetRow = tokens[0];
            int targetCol = tokens[1];
            int radius = tokens[2];

            for (int row = targetRow ; row <= matrix.Length - 1; row++)
            {
                if (matri)
                {
                    
                }
                matrix[row][targetCol] = 0;
            }

            for (int row = targetRow - 1; row >= Math.Min(radius,matrix.Length-targetRow-1); row--)
            {
                matrix[row][targetCol] = 0;
            }

            for (int col = targetCol; col <= matrix[0].Length - 1; col++)
            {
                matrix[targetRow][col] = 0;
            }

            for (int col = targetCol - 1; col >= Math.Min(radius,matrix[0].Length-1-targetRow); col--)
            {
                matrix[targetRow][col] = 0;
            }
        }

        private static void InitaliazeMatrix(int[] sizes, int[][] matrix)
        {
            int counter = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[sizes[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = counter++;
                }
            }
        }

        private static void Print(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ',row));
            }
        }
    }
}

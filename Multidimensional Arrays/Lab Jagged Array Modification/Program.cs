using System;
using System.Linq;

namespace Lab_Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());
            var matrix = new int[matrixRows][];

            for (int i = 0; i < matrixRows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split(' ').ToArray();
                var operation = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                if (col < 0 || row < 0 || row >= matrixRows || col >= matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }

                if (operation == "Add")
                {
                    matrix[row][col] += value;
                }
                else
                {
                    matrix[row][col] -= value;
                }
                
                command = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}

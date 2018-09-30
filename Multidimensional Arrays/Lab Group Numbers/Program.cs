using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var matrix = new int[3][];
            int[] sizes = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                sizes[Math.Abs(numbers[i] % 3)]++;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[sizes[i]];
            }

            int[] nextIndexes = new int[3]{0,0,0};

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = Math.Abs(numbers[i] % 3);
                matrix[remainder][nextIndexes[remainder]++] = numbers[i];
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ', row));
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_08._Radioactive_Mutant_Vampire_Bunny
{
    class Program
    {
        public static int[] sizes;
        public static List<int[]> bunnyIndexes;
        static void Main(string[] args)
        {
              sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var liar = new char[sizes[0]][];
            bunnyIndexes = new List<int[]>();
            int[] playerIndex = new int[2];

            for (int i = 0; i < liar.Length; i++)
            {
                char[] elements = Console.ReadLine().ToCharArray();
                liar[i] = new char[elements.Length];
                for (int j = 0; j < sizes[1]; j++)
                {
                    liar[i][j] = elements[j];
                    if (elements[j] == 'B')
                    {
                        int[] currentBunnyIndex = new[] {i, j};
                        bunnyIndexes.Add(currentBunnyIndex);

                    }else if (elements[j] == 'P')
                    {
                        playerIndex[0] = i;
                        playerIndex[1] = j;
                    }
                }
            }

            var directions = Console.ReadLine().ToCharArray();

            foreach (var direction in directions)
            {
                var lastPlayerIndex = new int[] {playerIndex[0], playerIndex[1]};

                switch (direction)
                {
                    case 'U':
                        playerIndex[0] -= 1;
                        break;
                    case 'D':
                        playerIndex[0] += 1;
                        break;
                    case 'L':
                        playerIndex[1] -= 1;
                        break;
                    case 'R':
                        playerIndex[1] += 1;
                        break;
                }

                liar[lastPlayerIndex[0]][lastPlayerIndex[1]] = '.';

                if (playerIndex[0] < 0 || playerIndex[0] > sizes[0] || playerIndex[1] < 0 || playerIndex[1] > sizes[1])
                {
                    MultiplyBunnies(liar, bunnyIndexes);
                    Print(liar);
                    Console.WriteLine($"won: {lastPlayerIndex[0]} {lastPlayerIndex[1]}");
                    return;
                }
                else
                {
                    MultiplyBunnies(liar, bunnyIndexes);
                    if (liar[playerIndex[0]][playerIndex[1]] == 'B')
                    {

                        Print(liar);
                        Console.WriteLine($"dead: {playerIndex[0]} {playerIndex[1]}");
                        return;
                    }
                }

            }

        }

        private static void Print(char[][] liar)
        {
            for (int row = 0; row < liar.Length; row++)
            {
                for (int col = 0; col < liar[row].Length; col++)
                {
                    Console.Write(liar[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static void MultiplyBunnies(char[][] liar, List<int[]> bunnyIndexes)
        {
            int count = bunnyIndexes.Count;

            for (int i = 0; i < count; i++)
            {
                int row = bunnyIndexes[i][0];
                int col = bunnyIndexes[i][1];

                if (liar.Length - 1 > row)
                {
                    liar[row + 1][col] = 'B';
                    bunnyIndexes.Add(new int[] { row + 1, col });

                }

                if (row > 0)
                {
                    liar[row - 1][col] = 'B';

                    bunnyIndexes.Add(new int[] { row - 1, col });
                }

                if (col > 0)
                {
                    liar[row][col - 1] = 'B';

                    bunnyIndexes.Add(new int[] { row, col - 1 });
                }

                if (liar[0].Length - 1 > col)
                {
                    liar[row][col + 1] = 'B';

                    bunnyIndexes.Add(new int[] { row, col + 1 });
                }
            }
           
        }

        
    }
}

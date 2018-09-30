using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ex_07.__Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var firstJagged = new string[rows][];
            var seccondJagged = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                firstJagged[i] = Console.ReadLine().Split(' ').ToArray();
            }
            for (int i = 0; i < rows; i++)
            {
                seccondJagged[i] = Console.ReadLine().Split(' ').Reverse().ToArray();
            }


            if (AreMatching(firstJagged,seccondJagged))
            {
                PrintNewMatrix(firstJagged,seccondJagged);
            }
            else
            {
                int allEl = 0;
                for (int row = 0; row < firstJagged.Length; row++)
                {
                    allEl += firstJagged[row].Length + seccondJagged[row].Length;
                }
                Console.WriteLine($"The total number of cells is: {allEl}");
            }
        }

        private static void PrintNewMatrix(string[][] firstJagged, string[][] seccondJagged)
        {
            var resultRow = new string[firstJagged[0].Length + seccondJagged[0].Length];
            for (int row = 0; row < firstJagged.Length; row++)
            {
                resultRow = firstJagged[row].Concat(seccondJagged[row]).ToArray();
                Console.WriteLine($"[{string.Join(", ",resultRow)}]");

            }
        }

        private static bool AreMatching(string[][] firstJagged, string[][] seccondJagged)
        {
            int neededSize = firstJagged[0].Length + seccondJagged[0].Length;

            for (int row = 1; row < firstJagged.Length; row++)
            {
                if (firstJagged[row].Length + seccondJagged[row].Length != neededSize)
                {
                    return false;
                }
            }

            return true;


        }

        private static void Print(string[][] firstJagged, string[][] seccondJagged)
        {
            Console.WriteLine();
            foreach (var row in firstJagged)
            {
                Console.WriteLine(string.Join(' ', row));
            }

            foreach (var row in seccondJagged)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}

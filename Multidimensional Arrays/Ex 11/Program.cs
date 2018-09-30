 using System;
 using System.Linq;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var parking = new string[sizes[0], sizes[1]];

            var input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "stop")
            {
                int entryRow = int.Parse(input[0]);
                int targetRow = int.Parse(input[1]);
                int targetCol = int.Parse(input[2]);

                if (parking[targetRow,targetCol] != null)
                {
                    for (int col = 1; col < parking.GetLength(1); col++)
                    {
                        if (parking[targetRow,col] == null)
                        {
                            int cellMoves = Math.Abs(col - 0) + Math.Abs(targetRow - entryRow) + 1;
                            parking[targetRow, targetCol] = "car";
                            Console.WriteLine(cellMoves);
                        }
                    }
                }
                else
                {
                    int cellMoves = Math.Abs(targetCol - 0) + Math.Abs(targetRow - entryRow) + 1;
                    parking[targetRow, targetCol] = "car";
                    Console.WriteLine(cellMoves);
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}

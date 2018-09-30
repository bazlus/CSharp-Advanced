using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var snakeStr = Console.ReadLine();
            var shotParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            var stairsMatrix = new char[sizes[0]][];

            FillMatrix(stairsMatrix, sizes, snakeStr);

            Shoot(stairsMatrix, shotParams);

            RearrangeMatrix(stairsMatrix);


            Print(stairsMatrix);

        }

        private static void RearrangeMatrix(char[][] stairsMatrix)
        {
            var queue = new Queue<char>();
            int counter = 0;

            for (int col = 0; col < stairsMatrix[0].Length; col++)
            {

                for (int row = 0; row < stairsMatrix.Length; row++)
                {
                    if (stairsMatrix[row][col] != ' ')
                    {
                        queue.Enqueue(stairsMatrix[row][col]);
                    }
                    else
                    {
                        counter++;
                    }
                }

                for (int row = 0; row < counter; row++)
                {
                    stairsMatrix[row][col] = ' ';
                }

                for (int i = counter; i < stairsMatrix.Length; i++)
                {
                    stairsMatrix[i][col] = queue.Dequeue();
                }

                counter = 0;
            }
        }

        private static void Shoot(char[][] stairsMatrix, int[] shotParams)
        {
            int targetRow = shotParams[0];
            int targetCol = shotParams[1];
            int radius = shotParams[2];

            for (int row = 0; row < stairsMatrix.Length; row++)
            {
                for (int col = 0; col < stairsMatrix[row].Length; col++)
                {
                    bool isShot = Math.Pow((row - targetRow), 2) + Math.Pow((col - targetCol), 2) <=
                                  Math.Pow(radius, 2);

                    if (isShot)
                    {
                        stairsMatrix[row][col] = ' ';
                    }
                }
            }
        }

        private static void Print(char[][] stairsMatrix)
        {
            for (int row = 0; row < stairsMatrix.Length; row++)
            {
                for (int col = 0; col < stairsMatrix[row].Length; col++)
                {
                    Console.Write(stairsMatrix[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static void FillMatrix(char[][] stairsMatrix, int[] sizes, string snakeStr)
        {
            bool rightToLeft = true;
            var snakeStrCounter = 0;
            for (int row = sizes[0] - 1; row >= 0; row--)
            {
                stairsMatrix[row] = new char[sizes[1]];
                if (rightToLeft)
                {
                    for (int col = stairsMatrix[row].Length - 1; col >= 0; col--)
                    {
                        if (snakeStrCounter == snakeStr.Length)
                        {
                            snakeStrCounter = 0;
                        }

                        stairsMatrix[row][col] = snakeStr[snakeStrCounter];
                        snakeStrCounter++;
                    }
                }
                else
                {
                    for (int col = 0; col < stairsMatrix[row].Length; col++)
                    {
                        if (snakeStrCounter == snakeStr.Length)
                        {
                            snakeStrCounter = 0;
                        }

                        stairsMatrix[row][col] = snakeStr[snakeStrCounter];
                        snakeStrCounter++;
                    }
                }

                rightToLeft = !rightToLeft;
            }
        }
    }
}

using System;
using System.Linq;

namespace Ex_05._Rubiks_Matrix
{
    class Program
    {

        public static int[][] matrix;
        public static int[] sizes;
        static void Main()
        {
            sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            matrix = new int[sizes[0]][];
            int counter = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[sizes[1]];
                for (int j = 0; j < sizes[1]; j++)
                {
                    counter++;
                    matrix[i][j] = counter;
                }
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();
                string direction = tokens[1];
                int rowCol = int.Parse(tokens[0]);
                int moves = int.Parse(tokens[2]);
                MoveMatrix(direction,rowCol,moves);
            }

            int lastCounter = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    lastCounter++;
                    if (matrix[row][col] == lastCounter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int i = 0; i < matrix.Length; i++)
                        {
                            for (int j = 0; j < matrix[i].Length; j++)
                            {
                                if (matrix[i][j] == lastCounter)
                                {
                                    matrix[i][j] = matrix[row][col];
                                    matrix[row][col] = lastCounter;
                                    Console.WriteLine($"Swap ({row}, {col}) with ({i}, {j})");
                                    
                                }
                            }
                        }
                    }
                }
            }

        }

        public static void MoveMatrix(string direction, int rowCol, int moves)
        {
            if (direction == "down" || direction == "up")
            {
                int col = rowCol;
                

                if (direction == "down")
                {
                    
                    for (int i = 0; i < moves % matrix.Length; i++)
                    {
                        int lastEl = matrix[sizes[0] - 1][col];
                        for (int j = sizes[0] - 1; j >= 0; j--)
                        {
                            if (j == 0)
                            {
                                matrix[j][col] = lastEl;
                                break;
                            }
                            matrix[j][col] = matrix[j - 1][col];
                        }
                    }
                }
                else
                {
                    
                    for (int i = 0; i < moves % matrix.Length; i++)
                    {
                        int firstEl = matrix[0][col];
                        for (int j = 0 ; j < sizes[0]; j++)
                        {
                            if (j == sizes[0] - 1)
                            {
                                matrix[j][col] = firstEl;
                                break;
                            }
                            matrix[j][col] = matrix[j + 1][col];
                        }
                    }
                }
            }
            else
            {
                int row = rowCol;
                if (direction == "right")
                {
                    
                    for (int i = 0; i < moves % matrix[0].Length; i++)
                    {
                        int lastEl = matrix[row][sizes[1] - 1];
                        for (int j = sizes[1] - 1; j >= 0; j--)
                        {
                            if (j == 0)
                            {
                                matrix[row][j] = lastEl;
                                break;
                            }
                            matrix[row][j] = matrix[row][j - 1];
                        }
                    }
                }
                else
                {
                    
                    for (int i = 0; i < moves % matrix[0].Length; i++)
                    {
                        int firstEl = matrix[row][0];
                        for (int j = 0; j < sizes[1]; j++)
                        {
                            if (j == sizes[1] - 1)
                            {
                                matrix[row][j] = firstEl;
                                break;
                            }

                            matrix[row][j] = matrix[row][j + 1];
                        }
                    }

                   
                }
            }
        } 
    }
}

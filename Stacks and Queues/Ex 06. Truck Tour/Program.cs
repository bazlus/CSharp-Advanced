    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    namespace Ex_06._Truck_Tour
    {
        class Program
        {
            static int numberOfPumps;
            static Queue<BigInteger[]> pumps;
            static void Main(string[] args)
            {

                numberOfPumps = int.Parse(Console.ReadLine());
                pumps = new Queue<BigInteger[]>();

                for (int i = 0; i < numberOfPumps; i++)
                {
                    pumps.Enqueue(Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray());
                }

                for (int i = 0; i < pumps.Count; i++)
                {

                    if (isSolution())
                    {
                        Console.WriteLine(i);
                        return;
                    }

                    pumps.Enqueue(pumps.Dequeue());

                }
                
            }

            static bool isSolution()
            {
                BigInteger gasTank = 0;

                foreach (var stop in pumps)
                {
                    gasTank += stop[0] - stop[1];
                    if (gasTank < 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }

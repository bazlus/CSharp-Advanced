using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var setsLenght = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = setsLenght[0];
            int m = setsLenght[1];
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (firstSet.Contains(num))
                {
                    secondSet.Add(num);
                }
            }

            Console.WriteLine(string.Join(' ', secondSet));



        }
    }
}

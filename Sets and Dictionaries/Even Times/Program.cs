using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var oddSet = new HashSet<int>();
            var evenSet = new  HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (oddSet.Contains(num) == false)
                {
                    evenSet.Remove(num);
                    oddSet.Add(num);
                }
                else
                {
                    evenSet.Add(num);
                    oddSet.Remove(num);
                }
            }

            Console.WriteLine(string.Join(' ',evenSet));
        }
    }
}

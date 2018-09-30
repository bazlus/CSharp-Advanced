using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            FillWardrobe(n, wardrobe);

            var toFind = Console.ReadLine().Split().ToArray();
            string color = toFind[0];
            string item = toFind[1];

            foreach (var pair in wardrobe)
            {
                Console.WriteLine($"{pair.Key} clothes:");
                foreach (var currentItem in pair.Value)
                {
                    Console.Write($"* {currentItem.Key} - {currentItem.Value}");
                    if (color == pair.Key && item == currentItem.Key)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

        }

        private static void FillWardrobe(int n, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(" -> ").ToArray();
                string color = tokens[0];

                if (wardrobe.ContainsKey(color) == false)
                {
                    var innerDict = new Dictionary<string, int>();
                    wardrobe.Add(color, innerDict);
                }

                var clothes = tokens[1].Split(',').ToArray();

                foreach (var item in clothes)
                {
                    if (wardrobe[color].ContainsKey(item) == false)
                    {
                        wardrobe[color].Add(item, 1);
                    }
                    else
                    {
                        wardrobe[color][item]++;
                    }
                }
            }
        }
    }
}

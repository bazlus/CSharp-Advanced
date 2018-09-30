using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_logger
{
    public class VloggerStats
    {
        public int following { get; set; }
        public int followersCount { get; set; }
        public List<string> followers{ get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var vloggers = new Dictionary<string, VloggerStats>();

            while (command != "Statistics")
            {
                var tokens = command.Split(' ').ToArray();

                if (tokens[1] == "joined")
                {
                    string currentVlogger = tokens[0];

                    if (vloggers.ContainsKey(currentVlogger) == false)
                    {
                        var currentStats = new VloggerStats();
                        currentStats.followersCount = 0;
                        currentStats.following = 0;
                        currentStats.followers = new List<string>();
                        vloggers.Add(currentVlogger, currentStats);
                    }
                }
                else
                {
                    string currnetVlogger = tokens[0];
                    string toFollow = tokens[2];
                    if (vloggers.ContainsKey(currnetVlogger) && vloggers.ContainsKey(toFollow) && 
                        currnetVlogger != toFollow &&
                        vloggers[toFollow].followers.Contains(currnetVlogger) == false)
                    {
                        vloggers[currnetVlogger].following++;
                        vloggers[toFollow].followersCount++;
                        vloggers[toFollow].followers.Add(currnetVlogger);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            bool isFirst = true;
            int counter = 1;

            foreach (var vlogger in vloggers.OrderByDescending(v => v.Value.followersCount).ThenBy(v => v.Value.following))
            {
                if (isFirst == false)
                {
                    Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.followersCount} followers, {vlogger.Value.following} following");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.followersCount} followers, {vlogger.Value.following} following");
                    foreach (var follower in vlogger.Value.followers.OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }

                    isFirst = false;
                    counter++;
                }

            }
        }
    }
}

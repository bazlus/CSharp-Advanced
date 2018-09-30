using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    public class UserContestsStats
    {
        public Dictionary<string,int> Contests { get; set; }
        public int Score { get; set; }
    }
    
   
    class Program
    {
        public static Dictionary<string,string> contests { get; set; }
        public static Dictionary<string, UserContestsStats> users { get; set; }
        static void Main(string[] args)
        {
            users = new Dictionary<string, UserContestsStats>();
            contests = new Dictionary<string,string>();
            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                var tokens = input.Split(':');
                string contest = tokens[0];
                string password = tokens[1];

               contests.Add(contest,password);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                var tokens = input.Split("=>").ToArray();
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (ContestIsValid(contest) && PasswordIsValid(contest,password))
                {
                    if (users.ContainsKey(username) == false)
                    {
                        var currentStats = new UserContestsStats();
                        currentStats.Contests = new Dictionary<string, int>();
                        currentStats.Contests.Add(contest,points);
                        users.Add(username,currentStats);
                        users[username].Score += points;

                    }
                    else if (users[username].Contests.ContainsKey(contest) == false)
                    {
                        users[username].Contests.Add(contest,points);
                        users[username].Score += points;
                    }
                    else if (users[username].Contests[contest] < points)
                    {
                        int pointsToAdd = points - users[username].Contests[contest];
                        users[username].Contests[contest] = points;
                        users[username].Score += pointsToAdd;
                    }
                }

                input = Console.ReadLine();
            }

            int topUserScore = 0;
            string topUserName = "";

            foreach (var pair in users)
            {
                if (pair.Value.Score > topUserScore)
                {
                    topUserScore = pair.Value.Score;
                    topUserName = pair.Key;
                }
            }

            Console.WriteLine($"Best candidate is {topUserName} with total {topUserScore} points");
            Console.WriteLine("Ranking:");

            foreach (var pair in users.OrderBy(u => u.Key))
            {
                Console.WriteLine(pair.Key);
                foreach (var contest in pair.Value.Contests.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"# {contest.Key} -> {contest.Value}");
                }
            }



        }

        private static bool PasswordIsValid(string contest, string password)
        {
            return contests[contest] == password;
        }

        private static bool ContestIsValid(string contest)
        {
            return contests.ContainsKey(contest);
        }
    }
}

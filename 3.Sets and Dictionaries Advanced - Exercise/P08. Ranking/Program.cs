using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> contests = new Dictionary<string,string>();
            Dictionary<string,Dictionary<string,int>> participtains
                = new Dictionary<string,Dictionary<string,int>>();

            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] cmdArgs = input
                    .Split(':',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                contests.Add(contest, password);
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArgs = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                string username = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);

                if(contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!participtains.ContainsKey(username))
                    {
                        participtains[username] = new Dictionary<string,int>();
                    }
                    if (!participtains[username].ContainsKey(contest))
                    {
                        participtains[username][contest] = 0;
                    }
                    if(points > participtains[username][contest])
                    {
                        participtains[username][contest] = points;
                    }
                   
                }
                
            }

            int higgestScore = 0;
            string bestUser = string.Empty;

            foreach (var user in participtains)
            {
                int currentMaxPoints = 0;
                foreach(var data in user.Value)
                {
                    currentMaxPoints += data.Value; 
                }
                if (currentMaxPoints > higgestScore)
                {
                    higgestScore = currentMaxPoints;
                    bestUser = user.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestUser} with total {higgestScore} points.");
            Console.WriteLine($"Ranking:");
            foreach(var user in participtains.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach(var data in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {data.Key} -> {data.Value}");
                }
            }
        }
    }
}

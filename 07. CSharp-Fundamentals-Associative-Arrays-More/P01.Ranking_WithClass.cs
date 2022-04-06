using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking_WithClass
{
    class Contest
    {
        public Contest(string contests, string pass, string userName, int points)
        {
            this.Contests = contests;
            this.Pass = pass;
            this.UserName = userName;
            this.Points = points;
        }


        public string Contests { get; set; }

        public string Pass { get; set; }

        public string UserName { get; set; }

        public int Points { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dataDict = new Dictionary<string, string>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = data[0];
                string pass = data[1];

                dataDict.Add(contest, pass);
            }


            List<Contest> contestList = new List<Contest>();
            string command;
            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] commandArr = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = commandArr[0];
                string pass = commandArr[1];
                string userName = commandArr[2];
                int point = int.Parse(commandArr[3]);

                Contest currentContest = new Contest(contest, pass, userName, point);
                bool isPoint = true;
                if (dataDict.ContainsKey(contest) && dataDict[contest] == pass)
                {
                    if (contestList.Any(x => x.Contests == contest))
                    {
                        foreach (var item in contestList)
                        {
                            if (item.Contests == contest && item.UserName == userName && item.Points < point)
                            {
                                item.Points = point;
                                isPoint = false;
                                break;
                            }
                            if (item.Contests == contest && item.UserName == userName && item.Points >= point)
                            {
                                isPoint = false;
                            }
                            
                            
                        }
                        if (isPoint)
                        {
                            contestList.Add(currentContest);

                        }
                    }
                    else
                    {
                        contestList.Add(currentContest);
                    }
                }
            }

            PrintBestCandidate(contestList);

            List<Contest> printList = contestList
                .OrderBy(x => x.UserName)
                .ThenByDescending(x => x.Points)
                .ToList();
            Console.WriteLine("Ranking:");
            PrintAllCandidte(printList);
        }

        static void PrintBestCandidate(List<Contest> currentContest)
        {
            string name = string.Empty;
            int bestPoints = 0;

            for (int i = 0; i < currentContest.Count; i++)
            {
                string currentName = currentContest[i].UserName;
                int currentPoint = currentContest[i].Points;

                for (int j = i + 1; j < currentContest.Count; j++)
                {
                    if (currentContest[j].UserName == currentName)
                    {
                        currentPoint += currentContest[j].Points;
                    }
                }

                if (bestPoints < currentPoint)
                {
                    bestPoints = currentPoint;
                    name = currentName;
                }
            }

            Console.WriteLine($"Best candidate is {name} with total {bestPoints} points.");       
        }


        static void PrintAllCandidte(List<Contest> printList)
        {
            List<string> printingName = new List<string>();
            foreach (Contest item in printList)
            {
                string name = item.UserName;
                if (printingName.Contains(name))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{name}");
                    foreach (Contest contest in printList)
                    {
                        if (contest.UserName == name)
                        {
                            Console.WriteLine($"#  {contest.Contests} -> {contest.Points}");
                        }
                    }
                    printingName.Add(name);
                }
                
            }
        
        }

    }
}

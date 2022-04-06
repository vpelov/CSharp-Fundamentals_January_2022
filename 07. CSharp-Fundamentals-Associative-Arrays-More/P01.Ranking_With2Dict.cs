using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking_With2Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dataDict = new Dictionary<string, string>();
            string data = Console.ReadLine();
            while (data != "end of contests")
            {
                string[] dataArr = data
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = dataArr[0];
                string pass = dataArr[1];
                dataDict.Add(contest, pass);

                data = Console.ReadLine();
            }


            Dictionary<string, int> resultDict = new Dictionary<string, int>();
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "end of submissions")
                {
                    break;
                }

                string contest = command[0];
                string pass = command[1];
                string userName = command[2];
                int points = int.Parse(command[3]);

                if (dataDict.ContainsKey(contest) && dataDict[contest] == pass)
                {
                    string contestUser = contest + "!!!" + userName;
                    if (resultDict.ContainsKey(contestUser) && resultDict[contestUser] < points)
                    {
                        resultDict[contestUser] = points;
                    }
                    else if (resultDict.ContainsKey(contestUser) && resultDict[contestUser] >= points)
                    {
                        continue;
                    }
                    else
                    {
                        resultDict.Add(contestUser, points);
                    }
                }


            }

            PrintBestStudent(resultDict);
            PrintAllStudents(resultDict);            
        }


        static void PrintBestStudent(Dictionary<string, int> resultDict)
        {
            int point = 0;
            string bestUser = string.Empty;

            for (int i = 0; i < resultDict.Count; i++)
            {
                var currentDict = resultDict.ElementAt(i);  //KeyValuePair<TKey, TValue>
                string[] user = currentDict.Key
                    .Split("!!!", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currentUser = user[1];

                int currentPoint = currentDict.Value;

                for (int j = i + 1; j < resultDict.Count; j++)
                {
                    var currentDictSecond = resultDict.ElementAt(j);
                    string[] userSecond = currentDictSecond.Key
                        .Split("!!!", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string currentUserSecond = userSecond[1];
                    int pointSecond = currentDictSecond.Value;

                    if (currentUserSecond == currentUser)
                    {
                        currentPoint += pointSecond;
                    }
                }

                if (currentPoint > point)
                {
                    point = currentPoint;
                    bestUser = currentUser;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {point} points.");                  
        
        }


        static void PrintAllStudents(Dictionary<string, int> resultDict)
        {
            List<string> printName = new List<string>();

            Console.WriteLine("Ranking:");
            for (int i = 0; i < resultDict.Count; i++)
            {
                var keyValue = resultDict.ElementAt(i);
                string[] current = keyValue.Key
                    .Split("!!!", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = current[1];
                if (printName.Contains(name))
                {
                    continue;
                }

                string contest = current[0];
                int point = keyValue.Value;
                Console.WriteLine($"{name}");
                Console.WriteLine($"#  {contest} -> {point}");
                for (int j = i + 1 ; j < resultDict.Count; j++)
                {
                    var keyValueSecond = resultDict.ElementAt(j);
                    string[] currentSecond = keyValueSecond.Key
                        .Split("!!!", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string nameSecond = currentSecond[1];
                    string contestSecond = currentSecond[0];
                    int pointSecond = keyValueSecond.Value;

                    if (name == nameSecond)
                    {
                        Console.WriteLine($"#  {contestSecond} -> {pointSecond}");
                    }

                }
                printName.Add(name);
            }

            
        
        
        }


    }
}

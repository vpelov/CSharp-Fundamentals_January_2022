using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dataDwarfs = new Dictionary<string, int>();

            string data;
            while ((data = Console.ReadLine()) != "Once upon a time")
            {
                string[] command = data
                        .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                string name = command[0];
                string hatColor= command[1];
                int phisics = int.Parse(command[2]);

                string newName = hatColor + "!!!" + name;

                if (dataDwarfs.ContainsKey(newName) && dataDwarfs[newName] < phisics)
                {
                    dataDwarfs[newName] = phisics;
                }
                else if (!dataDwarfs.ContainsKey(newName))
                {
                    dataDwarfs.Add(newName, phisics);
                }
            }

            PrintDwarfs(dataDwarfs);
            
        }


        static void PrintDwarfs(Dictionary<string, int> dataDwarfs)
        {
            Dictionary<string, int> printDict = dataDwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in printDict)
            {
                string[] arr = item.Key
                    .Split("!!!", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string color = arr[0];
                string name = arr[1];
                Console.WriteLine($"({color}) {name} <-> {item.Value}");
            }
        }

    }
}

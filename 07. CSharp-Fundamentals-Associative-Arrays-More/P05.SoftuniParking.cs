using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.SoftuniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registerDict = new Dictionary<string, string>();

            int numberReg = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberReg; i++)
            {
                string[] commandArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string userName = commandArray[1];

                if (commandArray[0] == "register")
                {
                    if (registerDict.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {commandArray[2]}");
                        continue;
                    }
                    else
                    {
                        string plateNumber = commandArray[2];
                        registerDict.Add(userName, plateNumber);
                        Console.WriteLine($"{userName} registered {plateNumber} successfully");
                    }

                }
                else if (commandArray[0] == "unregister")
                {
                    if (!registerDict.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        registerDict.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (var item in registerDict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}

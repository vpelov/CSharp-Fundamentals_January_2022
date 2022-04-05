using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] keyArr = new string[] { "shards", "fragments", "motes" };
            Dictionary<string, int> keyDict = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["motes"] = 0,
                ["fragments"] = 0

            };

            bool isLegendaryItem = false;

            Dictionary<string, int> junkDict = new Dictionary<string, int>();

            while (true)
            {
                string[] inputData = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 1; i < inputData.Length; i += 2)  // Check
                {
                    if (keyDict.ContainsKey(inputData[i]))
                    {
                        keyDict[inputData[i]] += int.Parse(inputData[i - 1]);
                    }
                    else
                    {
                        if (junkDict.ContainsKey(inputData[i]))
                        {
                            junkDict[inputData[i]] += int.Parse(inputData[i - 1]);
                        }
                        else
                        {
                            junkDict.Add(inputData[i], int.Parse(inputData[i - 1]));
                        }
                    }

                    if (keyDict.ContainsKey(inputData[i]) && keyDict[inputData[i]] >= 250)
                    {
                        GetPrintLegendary(keyDict);   // Print Legendary material
                        keyDict[inputData[i]] -= 250;
                        isLegendaryItem = true;
                        break;
                    }
                }

                if (isLegendaryItem)
                {
                    break;
                }
            }

            GetPrintDict(keyDict);

            GetPrintDict(junkDict);

        }

        static void GetPrintLegendary(Dictionary<string, int> keyDict)
        {
            string legendaryItem = string.Empty;

            foreach (var item in keyDict)
            {
                if (item.Key == "shards")
                {
                    legendaryItem = "Shadowmourne";
                }
                else if (item.Key == "fragments")
                {
                    legendaryItem = "Valanyr";
                }
                else if (item.Key == "motes")
                {
                    legendaryItem = "Dragonwrath";
                }

                if (item.Value > 250)
                {
                    Console.WriteLine($"{legendaryItem} obtained!");
                    break;
                }
            }
        }

        static void GetPrintDict(Dictionary<string, int> printDict)
        {
            foreach (var item in printDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        
        }


    }
}


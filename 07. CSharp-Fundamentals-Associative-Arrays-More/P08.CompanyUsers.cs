using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyData = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArray = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string company = commandArray[0];
                string id = commandArray[1];

                if (!companyData.ContainsKey(company))
                {
                    List<string> currentList = new List<string>() { id };
                    companyData.Add(company, currentList);
                    commandArray = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    continue;
                }
                
                if(companyData.ContainsKey(company) && !companyData[company].Contains(id))
                {
                    companyData[company].Add(id);
                }

                command = Console.ReadLine();
            }


            foreach (var item in companyData)
            {
                Console.WriteLine(item.Key);

                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace P03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input
 
            Dictionary<string, List<string>> dataDic = new Dictionary<string, List<string>>();

            int numberWord = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberWord; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                if (dataDic.ContainsKey(key))
                {
                    dataDic[key].Add(value);
                }
                else
                {
                    List<string> synonym = new List<string>();
                    synonym.Add(value);

                    dataDic.Add(key, synonym);
                }
            }

            // Print

            foreach (var item in dataDic)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }


        }
    }
}

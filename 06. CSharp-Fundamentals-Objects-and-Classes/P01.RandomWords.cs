using System;
using System.Linq;

namespace P01.RandomWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomIndex = new Random();

            string[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();


            for (int i = 0; i < inputData.Length; i++)
            {
                int rnd = randomIndex.Next(0, inputData.Length);

                string wordTemp = inputData[i];
                inputData[i] = inputData[rnd];
                inputData[rnd] = wordTemp;

            }

            foreach (string item in inputData)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}

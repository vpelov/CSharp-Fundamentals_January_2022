using System;
using System.Linq;

namespace P04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] printData = inputData.Where(x => x.Length % 2 == 0).ToArray();

            foreach (string item in printData)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}

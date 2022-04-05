using System;
using System.Collections.Generic;
using System.Linq;


namespace P03.MergingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            int maxLengthList = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < maxLengthList; i++)
            {
                if (i < firstList.Count)
                {
                    resultList.Add(firstList[i]);
                }

                if (i < secondList.Count)
                {
                    resultList.Add(secondList[i]);
                }
            }

            Console.WriteLine(String.Join(" ", resultList));
        }
    }
}

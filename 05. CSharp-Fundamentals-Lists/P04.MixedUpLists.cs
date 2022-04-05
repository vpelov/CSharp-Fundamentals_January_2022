using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numberTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> zigZag = new List<int>();
            List<int> rangeList = new List<int>();

            int minSequense = Math.Min(numberOne.Count, numberTwo.Count);
            

            if (numberOne.Count > minSequense)
            {
                rangeList.Add(numberOne[numberOne.Count - 1]);
                rangeList.Add(numberOne[numberOne.Count - 2]);
            }
            else
            {
                rangeList.Add(numberTwo[0]);
                rangeList.Add(numberTwo[1]);
            }


            for (int i = 0; i < minSequense; i++)
            {

                for (int j = numberTwo.Count - 1 - i; j >= numberTwo.Count -1 - i; j--)
                {
                    zigZag.Add(numberOne[i]);
                    zigZag.Add(numberTwo[j]);
                }
            }

            rangeList.Sort();

            List<int> result = new List<int>();
            result = zigZag.Where(x => x > rangeList[0] && x < rangeList[1]).ToList();

            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

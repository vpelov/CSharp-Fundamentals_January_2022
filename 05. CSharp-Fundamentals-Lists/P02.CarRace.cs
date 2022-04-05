using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumber = Console.ReadLine().Split().Select(int.Parse).ToList();
            int middle = inputNumber.Count / 2;

            List<int> firstRaceList = new List<int>();
            List<int> secondRaceList = new List<int>();

            for (int i = 0; i < middle; i++)
            {
                firstRaceList.Add(inputNumber[i]);
            }

            for (int i = inputNumber.Count - 1; i > middle; i--)
            {
                secondRaceList.Add(inputNumber[i]);
            }

            double speedOne = GetSpeed(firstRaceList);
            double speedTwo = GetSpeed(secondRaceList);

            double winner = Math.Min(speedOne, speedTwo);

            if (speedOne > speedTwo)
            {
                Console.WriteLine($"The winner is right with total time: {speedTwo}");
            }
            else if (speedOne < speedTwo)
            {
                Console.WriteLine($"The winner is left with total time: {speedOne}");
            }


        }


        static double GetSpeed(List<int> speedList)
        {
            double sum = 0;

            for (int i = 0; i < speedList.Count; i++)
            {
                double currentNum = speedList[i];
                if (currentNum == 0)
                {
                    sum *= 0.8;
                }
                else
                {
                    sum += currentNum;
                }

            }


            return sum;
        }
    }
}

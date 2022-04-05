using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            List<int> currentDrum = drumSet;

            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                currentDrum = GetHitPower(currentDrum, hitPower);  //Remove hitPower

                for (int i = 0; i < currentDrum.Count; i++)          // check drumPower
                {
                    if (currentDrum[i] <= 0 && (drumSet[i] * 3) <= money)
                    {
                        currentDrum[i] = drumSet[i];
                        money -= drumSet[i] * 3;
                    }
                    else if (currentDrum[i] <= 0 && (drumSet[i] * 3) > money)
                    {
                        currentDrum.RemoveAt(i);
                        drumSet.RemoveAt(i);
                    }

                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", currentDrum));
            Console.WriteLine($"Gabsy has {money:f2}lv.");

        }


        static List<int> GetHitPower(List<int> inputList, int hitPower)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                result.Add(inputList[i] - hitPower);
            }
            return result;
        }
    }
}

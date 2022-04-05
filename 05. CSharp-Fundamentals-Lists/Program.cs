using System;
using System.Linq;

namespace _03_The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int indexEntryPosition = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int sumLeft = 0;
            int sumRight = 0;

            if (command == "cheap")
            {
                DestroingCheapStuff(items, indexEntryPosition);
            }
            if (command == "expensive")
            {
                DestroingExpensiveStuff(items, indexEntryPosition);
            }
        }

        static void DestroingCheapStuff(int[] items, int indexStart)
        {
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = indexStart - 1; i >= 0; i--)
            {
                if (items[i] < items[indexStart])
                {
                    sumLeft += items[i];
                }
            }
            for (int i = indexStart + 1; i < items.Length; i++)
            {
                if (items[i] < items[indexStart])
                {
                    sumRight += items[i];
                }
            }
            if (sumLeft < sumRight)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
            else if (sumLeft >= sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
        }

        static void DestroingExpensiveStuff(int[] items, int indexStart)
        {
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = indexStart - 1; i >= 0; i--)
            {
                if (items[i] >= items[indexStart])
                {
                    sumLeft += items[i];
                }
            }
            for (int i = indexStart + 1; i < items.Length; i++)
            {
                if (items[i] >= items[indexStart])
                {
                    sumRight += items[i];
                }
            }
            if (sumLeft < sumRight)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
            else if (sumLeft >= sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
        }
    }
}
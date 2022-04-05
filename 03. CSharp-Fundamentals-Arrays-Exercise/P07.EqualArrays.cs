using System;
using System.Linq;

namespace P07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isEqual = true;
            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isEqual = false;
                    break;
                }
                else
                {
                    sum += firstArray[i];
                }
            }

            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}

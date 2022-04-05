using System;
using System.Linq;

namespace P08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lengthFirstArray = firstArray.Length;

            for (int i = 0; i < lengthFirstArray - 1; i++)
            {
                int[] secondArray = new int[firstArray.Length - 1];

                for (int j = 0; j < secondArray.Length; j++)
                {
                    int digit = firstArray[j] + firstArray[j + 1];
                    secondArray[j] = digit;
                }
                firstArray = secondArray;
            }

            Console.WriteLine(String.Join(" ", firstArray));
        }
    }
}

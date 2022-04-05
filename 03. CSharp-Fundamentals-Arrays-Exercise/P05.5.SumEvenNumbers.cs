using System;
using System.Linq;

namespace P05._5.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;    

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] % 2 != 0)
                {
                    continue;
                }
                else
                {
                    sum += newArray[i];
                }
            }
            Console.WriteLine(sum);

        }
    }
}

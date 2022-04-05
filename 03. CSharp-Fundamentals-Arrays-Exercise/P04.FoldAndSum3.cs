using System;
using System.Linq;

namespace P04.FoldAndSum3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            GetFoldAndSum(vs);
        }

        static void GetFoldAndSum(int[] array)
        {
            int[] resultArray = new int[array.Length / 2];
            int indexOneCollection = (array.Length / 2 / 2);
            int indexOneSubstraction = ((array.Length / 2 / 2)- 1);
            int indexTwoCollectin = array.Length / 2;
            int indexTwoSubstraction = array.Length - 1;
            

            for (int i = 0; i < resultArray.Length / 2; i++)
            {
                resultArray[i] = array[indexOneCollection] + array[indexOneSubstraction];
                resultArray[indexOneCollection] = array[indexTwoCollectin] + array[indexTwoSubstraction];

                indexOneCollection++;
                indexOneSubstraction--;
                indexTwoCollectin++;
                indexTwoSubstraction--;

            }

            Console.WriteLine(String.Join(" ", resultArray));
        }
    }
}

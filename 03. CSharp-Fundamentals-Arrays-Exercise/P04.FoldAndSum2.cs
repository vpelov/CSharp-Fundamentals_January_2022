using System;
using System.Linq;

namespace P04.FoldAndSum2
{
    internal class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            int[] vs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            GetFoldAndSum(vs);
        }

        static void GetFoldAndSum(int[] array)
        {
            int[] resultArray = new int[array.Length / 2];
            int indexOne = (array.Length / 2 - 1);
            int indexTwo = array.Length / 2;
            int indexThree = array.Length;

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i < indexOne)
                {
                resultArray[i] = array[i] + array[indexOne];
                resultArray[resultArray.Length] = array[indexThree] + array[indexTwo];
                indexOne--;
                indexTwo++;
                indexThree--;
                }
                else
                {
                    break;
                }
            }
        }

    }
}

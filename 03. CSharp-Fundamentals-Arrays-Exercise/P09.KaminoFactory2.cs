using System;
using System.Linq;

namespace P09.KaminoFactory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LengthSequence = int.Parse(Console.ReadLine());
            string[] array = new string[LengthSequence];
            string inputStringarray = Console.ReadLine();

            int seriesNumber = 1;
            int leftIndex = int.MaxValue;
            int sumOfOnes = 0;
            string[] printArray = new string[LengthSequence];


            while (inputStringarray != "Clone them!")
            {
                array = inputStringarray.Split("!".ToCharArray().ToArray());

                int inSideLeftIndex = int.MaxValue;
                int inSideSumOfOnes = 0;
                int inSideSeriesNumber = 1;

                for (int i = 0; i < array.Length; i++)
                {
                    
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == "1")
                        {
                            inSideSumOfOnes++;
                        }

                        if (array[i] == array[j] && array[i] == "1")
                        {
                            inSideSeriesNumber++;
                            inSideLeftIndex = j - inSideSeriesNumber + 1;
                        }
                        else
                        {
                            i++;
                        }

                        if (inSideSeriesNumber > seriesNumber)
                        {
                            seriesNumber = inSideSeriesNumber;
                            leftIndex = inSideLeftIndex;
                        }
                    }

                }

                if (inSideSeriesNumber > seriesNumber)
                {
                    printArray = array;
                }
                else if (inSideSeriesNumber == seriesNumber)
                {
                    if (inSideLeftIndex < leftIndex)
                    {
                        printArray = array;
                    }
                }
                else if (inSideSeriesNumber == seriesNumber && inSideLeftIndex == leftIndex)
                {
                    if (inSideSumOfOnes > sumOfOnes)
                    {
                        printArray = array;
                    }
                }

                inputStringarray = Console.ReadLine();
            }



            Console.WriteLine(String.Join(" ", printArray));


        }
    }
}

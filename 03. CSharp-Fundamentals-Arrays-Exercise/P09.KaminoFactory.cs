using System;
using System.Linq;

namespace P09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] inputArray = new int[arrayLength];
            string input = Console.ReadLine();

            int[] printArray = new int[arrayLength];
            int numberSequence = 1;
            int index = int.MaxValue;
            int sum = 0;

            while (input != "Clone them!")
            {
                inputArray = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int i = 0; i < inputArray.Length; i++)
                {
                    int inputCountSequence = 1;
                    int InputIndex = int.MaxValue;
                    int InputSum = 0;

                    if (inputArray[i] == 1)
                    {
                        InputSum++;
                    }
                    else if (inputArray[i] == 0)
                    {
                        continue;
                    }

                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        if (inputArray[i] == inputArray[j] && inputArray[j] == 1)
                        {
                            inputCountSequence++;                            
                                InputIndex = i;
                            if (inputCountSequence > numberSequence)
                            {
                                printArray = inputArray;
                            }
                            else if (inputCountSequence == numberSequence && InputIndex < index)
                            {
                                printArray = inputArray;
                            }
                            else if (inputCountSequence == numberSequence && InputIndex == index && sum > InputSum)
                            {
                                printArray = inputArray;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else
                        {
                            i = j;
                            inputCountSequence = 1;
                        }
                    }


                    inputCountSequence = 1;
                    sum = InputSum;
                    index = InputIndex;
                }

               

                input = Console.ReadLine();
            }




            foreach (int item in printArray)
            {
                Console.Write($"{item} ");
            }


        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace P011.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //int[] array = inputArray.Where(x => x > 0).ToArray();
            //Console.WriteLine(String.Join(", ",array));

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArray = command.Split().ToArray();
                string currentCommand = commandArray[0];

                switch (currentCommand)
                {
                    case "exchange":
                        int index = int.Parse(commandArray[1]);
                        if (index < 0 || index > inputArray.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            inputArray = GetExchange(inputArray, index);
                        }
                        break;

                    case "max":
                        string evenOdd = commandArray[1];
                        int numberMax = GiveMeMaxEvenOdd(inputArray, evenOdd);

                        if (numberMax == int.MaxValue || numberMax == int.MinValue)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(numberMax);
                        }
                        break;

                    case "min":
                        string oddEven = commandArray[1];
                        int numberMin = GiveMeMinEvenOdd(inputArray, oddEven);

                        if (numberMin == int.MaxValue || numberMin == int.MinValue)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(numberMin);
                        }
                        break;

                    case "first":
                        int count = int.Parse(commandArray[1]);
                        string eOdd = commandArray[2];
                        GetMyFirstCount(inputArray, count, eOdd);
                        break;

                    case "last":
                        int countLast = int.Parse(commandArray[1]);
                        string oEven = commandArray[2];
                        GetMyLastCount(inputArray, countLast, oEven);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(String.Join(", ", inputArray));
            Console.WriteLine("]");
        }


        static int[] GetExchange(int[] array, int index)
        {
            int[] backArray = new int[array.Length];

            int count = 0;
            for (int i = index + 1; i < backArray.Length; i++)
            {
                backArray[count] = array[i];
                count++;
            }
            for (int i = 0; i <= index; i++)
            {
                backArray[count] = array[i];
                count++;
            }


            return backArray;
        }

        static int GiveMeMaxEvenOdd(int[] array, string evenOdd)
        {
            int index = int.MinValue;
            int maxNumber = int.MinValue;

            if (evenOdd == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] >= maxNumber)
                    {
                        maxNumber = array[i];
                        index = i;
                    }
                }
            }
            else if (evenOdd == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] >= maxNumber)
                    {
                        maxNumber = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int GiveMeMinEvenOdd(int[] array, string evenOdd)
        {
            int index = int.MaxValue;
            int minNumber = int.MaxValue;

            if (evenOdd == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] <= minNumber)
                    {
                        minNumber = array[i];
                        index = i;
                    }
                }
            }
            else if (evenOdd == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] <= minNumber)
                    {
                        minNumber = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static void GetMyFirstCount(int[] inputArray, int count, string evenOdd)
        {
            int[] printArray = new int[count];
            bool isPrint = true;
            if (count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (evenOdd == "even")
            {
                
                int currentCount = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2 == 0 && currentCount < count)
                    {
                        printArray[currentCount] = inputArray[i];
                        currentCount++;
                        isPrint = false;
                    }
                }

                if (isPrint)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    printArray = printArray.Where(x => x != 0).ToArray();
                    Console.Write("[");
                    Console.Write(String.Join(", ", printArray));
                    Console.Write("]");
                    Console.WriteLine();
                }


            }
            else if (evenOdd == "odd")
            {                
                int currentCount = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2 != 0 && currentCount < count)
                    {
                        printArray[currentCount] = inputArray[i];
                        currentCount++;
                        isPrint = false;
                    }
                }

                if (isPrint)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    printArray = printArray.Where(x => x != 0).ToArray();
                    Console.Write("[");
                    Console.Write(String.Join(", ", printArray));
                    Console.Write("]");
                    Console.WriteLine();
                }
            }


        }

        static void GetMyLastCount(int[] inputArray, int count, string evenOdd)
        {
            int[] printArray = new int[count];
            bool isPrint = true;
            if (count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (evenOdd == "even")
            {

                int currentCount = 0;
                for (int i = inputArray.Length - 1; i >= 0 ; i--)
                {
                    if (inputArray[i] % 2 == 0 && currentCount < count)
                    {
                        printArray[currentCount] = inputArray[i];
                        currentCount++;
                        isPrint = false;
                    }
                }

                if (isPrint)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    printArray = printArray.Where(x => x != 0).ToArray();                   
                    Console.Write("[");
                    Console.Write(String.Join(", ", printArray));
                    Console.Write("]");
                    Console.WriteLine();
                }


            }
            else if (evenOdd == "odd")
            {
                int currentCount = 0;
                for (int i = inputArray.Length - 1; i >= 0; i--)
                {
                    if (inputArray[i] % 2 != 0 && currentCount < count)
                    {
                        printArray[currentCount] = inputArray[i];
                        currentCount++;
                        isPrint = false;
                    }
                }

                if (isPrint)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    printArray = printArray.Where(x => x != 0).ToArray();
                    printArray.Reverse();
                    Console.Write("[");
                    Console.Write(String.Join(", ", printArray));
                    Console.Write("]");
                    Console.WriteLine();
                }
            }


        }
    }
    }

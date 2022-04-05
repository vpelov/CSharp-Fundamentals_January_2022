using System;
using System.Linq;
using System.Collections.Generic;

namespace P07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> compereList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numberList = compereList;

            string command = Console.ReadLine();
            int countPrint = 0;

            while (command != "end")
            {
                string[] commandArray = command.Split();
                switch (commandArray[0])
                {

                    case "Add":
                        int n = int.Parse(commandArray[1]);
                        numberList.Add(n);
                        countPrint++;
                        break;

                    case "Remove":

                        int x = int.Parse(commandArray[1]);
                        numberList.Remove(x);
                        countPrint++;
                        break;

                    case "RemoveAt":

                        int y = int.Parse(commandArray[1]);
                        numberList.RemoveAt(y);
                        countPrint++;
                        break;

                    case "Insert":
                        int num = int.Parse(commandArray[1]);
                        int index = int.Parse(commandArray[2]);
                        numberList.Insert(index, num);
                        countPrint++;
                        break;

                    case "Contains":

                        int number = int.Parse(commandArray[1]);
                        if (numberList.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "Filter":

                        int nums = int.Parse(commandArray[2]);
                        List<int> resultFilter = new List<int>();

                        switch (commandArray[1])
                        {
                            case "<":
                                resultFilter = numberList.FindAll(x => x < nums);
                                break;

                            case ">":
                                resultFilter = numberList.FindAll(x => x > nums);
                                break;

                            case "<=":
                                resultFilter = numberList.FindAll(x => x <= nums);

                                break;

                            case ">=":
                                resultFilter = numberList.FindAll(x => x >= nums);
                                break;

                        }
                        Console.WriteLine(String.Join(" ", resultFilter));
                        break;

                    case "PrintEven":

                        //List<int> evenList = numberList.FindAll(x => x % 2 == 0);   //First option 
                        //Console.WriteLine(String.Join(" ", evenList));

                        List<int> evenList = new List<int>();                        //Second option
                        for (int i = 0; i < numberList.Count; i++)
                        {
                            if (numberList[i] % 2 == 0)
                            {
                                evenList.Add(numberList[i]);
                            }
                        }
                        Console.WriteLine(String.Join(" ", evenList));
                        break;

                    case "PrintOdd":

                        //List<int> oddList = numberList.FindAll(x => x % 2 != 0);  // First option
                        //Console.WriteLine(String.Join(" ", oddList));

                        List<int> oddList = new List<int>();
                        for (int i = 0; i < numberList.Count; i++)                  // Second option
                        {
                            if (numberList[i] % 2 != 0)
                            {
                                oddList.Add(numberList[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", oddList));
                        break;

                    case "GetSum":

                        //int sum = numberList.Sum(number => number);        // First option
                        //Console.WriteLine(sum);

                        int sum = 0;                                         // Second option
                        for (int i = 0; i < numberList.Count; i++)
                        {
                            sum += numberList[i];
                        }
                        Console.WriteLine(sum);
                        break;

                }
                        command = Console.ReadLine();
            }

            if (countPrint > 0)
            {
                Console.WriteLine(String.Join(" ", numberList));
            }
        }
    }
}


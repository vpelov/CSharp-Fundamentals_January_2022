using System;
using System.Linq;
using System.Collections.Generic;

namespace P06.ListManipulationBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArray = command.Split().ToArray();

                if (commandArray[0] == "Add")
                {
                    int n = int.Parse(commandArray[1]);
                    numberList.Add(n);
                }
                else if (commandArray[0] == "Remove")
                {
                    int n = int.Parse(commandArray[1]);
                    numberList.Remove(n);
                }
                else if (commandArray[0] == "RemoveAt")
                {
                    int n = int.Parse(commandArray[1]);
                    numberList.RemoveAt(n);
                }
                else if (commandArray[0] == "Insert")
                {
                    int num = int.Parse(commandArray[1]);
                    int index = int.Parse(commandArray[2]);
                    numberList.Insert(index, num);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numberList)); 

        }
    }
}

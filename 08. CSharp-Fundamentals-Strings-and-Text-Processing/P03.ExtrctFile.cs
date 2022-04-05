using System;
using System.Linq;

namespace P03.ExtrctFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine()
                .Split('\\', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] name = inputData[inputData.Length - 1].Split('.', StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine($"File name: {name[0]}");
            Console.WriteLine($"File extension: {name[1]}");

        }
    }
}

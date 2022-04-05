using System;

namespace P01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeData = Console.ReadLine();

            CheckTypeData(typeData);
        }

        static void CheckTypeData(string text)
        {
            if (text == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number * 2);
            }
            else if (text == "real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number * 1.5:f2}");
            }
            else if (text == "string")
            {
                string inText = Console.ReadLine();
                Console.WriteLine($"${inText}$");
            }

        }

    }
}

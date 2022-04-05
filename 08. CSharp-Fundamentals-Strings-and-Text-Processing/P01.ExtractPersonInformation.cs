using System;
using System.Linq;

namespace P01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                string inputData = Console.ReadLine();
                int start = inputData.IndexOf('@');
                string textName = inputData.Substring(start + 1);
                int end = textName.IndexOf('|');

                textName = textName.Substring(0, end);

                string[] stringArray = inputData.Split('#').ToArray();
                string[] stringArray2 = stringArray[1].Split('*').ToArray();
                string age = stringArray2[0];

                Console.WriteLine($"{textName} is {age} years old.");

                number--;
            }




        }
    }
}

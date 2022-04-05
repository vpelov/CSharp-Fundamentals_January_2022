using System;

namespace P01.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

            while (inputString != "end")
            {
                string reverse = string.Empty;
                for (int i = inputString.Length - 1; i >= 0 ; i--)
                {
                    char current = inputString[i];
                    reverse += current;
                }

                Console.WriteLine($"{inputString} = {reverse}");

                inputString = Console.ReadLine();
            }


        }
    }
}

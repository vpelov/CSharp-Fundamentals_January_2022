using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i <= text.Length -1; i++)
            {
                char symbol = text[i];
                int x = (int)symbol;
                Console.WriteLine(x);
            }
            //char test = text[0];
            //int number = (int)(test);
            //Console.WriteLine(number);
        }
    }
}

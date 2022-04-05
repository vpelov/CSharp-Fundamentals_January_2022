using System;
using System.Text;

namespace P06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            StringBuilder currentBuilder = new StringBuilder(input);

            StringBuilder printBuilder = new StringBuilder();

            for (int i = 0; i < currentBuilder.Length; i++)
            {
                char currentCh = currentBuilder[i];
                if (i == 0)
                {
                    printBuilder.Append(currentCh);
                }
                else
                {
                    if (currentCh == printBuilder[i - 1])
                    {
                        currentBuilder.Remove(i,1);
                        i--;
                        continue;
                    }
                    else
                    {
                        printBuilder.Append(currentCh);
                    }
                }


            }
            

            Console.WriteLine(printBuilder);

        }
    }
}

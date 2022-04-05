using System;
using System.Linq;

namespace P09.KmainoFactory3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthArray = int.Parse(Console.ReadLine());
            string[] array = new string[lengthArray];
            string inputString = Console.ReadLine();

            int bigSequence = 0;

            while (inputString != "Close them!")
            {
                array = inputString.Split("!".ToCharArray()).ToArray();

                int sequence = 0;

                for (int i = 0; i < inputString.Length; i++)
                {
                    int currSequence = 1;

                    for (int j = 0; j < inputString.Length; j++)
                    {
                        if (array[i] == array[j] && array[i] == "1")
                        {
                            currSequence++;
                        }
                        else
                        {
                            i++;
                        }


                    }
                    if (currSequence > sequence)
                    {
                        sequence = currSequence;
                    }
                }



                inputString = Console.ReadLine();
            }


                Console.WriteLine(string.Join(" ", array));


        }
    }
}

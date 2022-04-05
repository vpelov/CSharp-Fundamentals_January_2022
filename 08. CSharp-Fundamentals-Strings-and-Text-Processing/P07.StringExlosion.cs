using System;
using System.Text;

namespace P07.StringExlosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputData = input.ToCharArray();
           
            StringBuilder printBuilder = new StringBuilder();

            for (int i = 0; i < inputData.Length; i++)
            {
                int powerExplosion = 0;

                if (inputData[i] != '>')
                {
                    printBuilder.Append(inputData[i]);
                }
                else
                {
                    printBuilder.Append(inputData[i]);
                    powerExplosion = (int)inputData[i + 1] - '0';  
                  
                    for (int j = i+1; j <= i + powerExplosion; j++)
                    {
                        if (inputData[j] == '>')
                        {
                            powerExplosion++;
                            powerExplosion += (inputData[j + 1] - '0');
                            printBuilder.Append(inputData[j]);
                        }
                    }
                }

                i += powerExplosion;

            }

            Console.WriteLine(String.Join("|", printBuilder));

        }
    }
}

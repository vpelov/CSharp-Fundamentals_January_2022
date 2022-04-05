using System;
using System.Numerics;

namespace P02FromLeftToTheRight
{
    internal class FromLeftToTheRight
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                string one = string.Empty;
                string two = string.Empty;
                string current = string.Empty;

                for (int j = 0; j < text.Length; j++)    // separated text
                {

                    if (text[j] == 32)
                    {
                        one = current;
                        current = string.Empty;
                        two = String.Empty;
                        continue;
                    }
                    current += text[j];
                    two = current;

                }

                BigInteger firstNumber = BigInteger.Parse(one);
                BigInteger secondNumber = BigInteger.Parse(two);


                if (firstNumber >= secondNumber)
                {
                    BigInteger result = 0;
                    for (int l = 0; l < one.Length; l++)
                    {
                        if (one[l] == 45)
                        {
                            continue;
                        }
                        result = result + BigInteger.Abs(int.Parse(one[l].ToString()));
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    BigInteger result = 0;
                    for (int k = 0; k < two.Length; k++)
                    {
                        if (two[k] == 45) 
                        {
                            continue;
                        }
                        result = result + BigInteger.Abs(int.Parse(two[k].ToString()));
                    }
                    Console.WriteLine(result);
                }
            }

        }
    }
}

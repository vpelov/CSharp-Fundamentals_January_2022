using System;
using System.Numerics;

namespace P11Snowballs
{
    internal class P11Snowballs
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger highestBall = int.MinValue;
            int snow = 0, time = 0, quality = 0; 

            for (int i = 0; i < number; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestBall)
                {
                    highestBall = snowballValue;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }

            }

            Console.WriteLine($"{snow} : {time} = {highestBall} ({quality})");

        }
    }
}

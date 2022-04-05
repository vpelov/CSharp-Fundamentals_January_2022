using System;

namespace P10.TopNumbre2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            GetTopNumber(number);

        }


        static void GetTopNumber(int number)
        {
           
            for (int i = 1; i <= number; i++)
            {
                if (IsDivideEigth(i) && IsLeastOneOdd(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool IsDivideEigth(int number)
        {
            int sum = 0;
            bool isDivide = false;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                isDivide = true;
            }
            return isDivide;
        }

        static bool IsLeastOneOdd(int number)
        {
            bool isOdd = false;

            while (number != 0)
            {
                if (number % 10 != 0 && (number % 10) % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
                number /= 10;
            }
            return isOdd;      
        
        }

    }
}

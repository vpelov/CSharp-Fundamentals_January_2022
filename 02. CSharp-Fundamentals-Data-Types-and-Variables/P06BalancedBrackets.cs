using System;

namespace P06BalancedBrackets
{
    internal class P06BalancedBrackets
    {
        static void Main(string[] args)
        {
            //int numberSymbol = int.Parse(Console.ReadLine());

            //bool isOpenBracket = false;
            //bool isClosedBracket = false;
            //int countOpen = 0;
            //int count = 0;

            //for (int i = 0; i < numberSymbol; i++)
            //{
            //    string inputCh = Console.ReadLine();

            //    if (inputCh.Length > 100 || inputCh.Length == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {

            //        if (inputCh.Length == 1)
            //        {
            //            int currentCh = char.Parse(inputCh);

            //            if (currentCh == 40 || currentCh == 41)
            //            {

            //                if (currentCh == 40 && countOpen == 0)   // "(" = 40
            //                {
            //                    isOpenBracket = true;
            //                    isClosedBracket = false;
            //                    countOpen++;
            //                }
            //                else if (currentCh == 40 && countOpen != 0)
            //                {
            //                    count = 1;
            //                    continue;
            //                }

            //                if (currentCh == 41 && countOpen == 1)    //   ")" = 41
            //                {
            //                    isClosedBracket = true;
            //                    countOpen = 0;
            //                }
            //                else if (currentCh == 41 && countOpen != 1)
            //                {
            //                    count = 1;
            //                    continue;
            //                }
            //            }
            //        }
            //    }
            //}

            //if (count == 1)
            //{
            //    Console.WriteLine("UNBALANCED");
            //}
            //else
            //{

            //    if (isClosedBracket == true && isOpenBracket == true)
            //    {
            //        Console.WriteLine("BALANCED");
            //    }
            //    else
            //    {
            //        Console.WriteLine("UNBALANCED");
            //    }
            //}
            Console.WriteLine("Input array lenght: ");
            int arrayLenght = int.Parse(Console.ReadLine());

            int[] arrayNew = new int[arrayLenght];

            Console.WriteLine($"Please insert {arrayLenght} elements :");

            for (int i = 0; i < arrayNew.Length; i++)
            {
                arrayNew[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Your {arrayLenght} elements is: ");

            for (int i = 0; i < arrayNew.Length; i++)
            {
                Console.Write($"{arrayNew[i]} ");
            }

            int number = 0;

            for (int i = 0; i < arrayNew.Length; i++)
            {
                number += arrayNew[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of eslements is: {number}");
        }
    }
}

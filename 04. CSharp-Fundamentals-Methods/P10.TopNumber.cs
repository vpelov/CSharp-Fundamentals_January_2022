using System;
using System.Linq;

namespace P10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] array = GetDivideEith(number);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

        }

        static int[] GetDivideEith(int num)
        { 
        int[] result = new int[num + 1];

            for (int i = 0; i <= num; i++)
            {
                int sum = 0;
                int g = i;
                while (g % 8 != 0)
                {
                    sum += g % 10;
                    g /= 10;
                }
                if (sum % 8 == 0)
                {
                result[i] = i;

                }
            }
            int[] result2 = new int[result.Length];
           
            for (int j = 0; j < result.Length; j++)
            {
                if (result[j] % 8 != 0)
                {
                    result2[j] = j;
                }               
            }

            int countNum = 0;
            for (int k = 0; k < result2.Length; k++)
            {
                if (result2[k] != 0)
                {
                    countNum++;
                }
            }


            int[] result3 = new int[countNum];
            int countArr = 0;
            for (int l = 0; l < result2.Length; l++)
            {
                int p = l;
                while (result2[p] % 10 != 0)
                {
                    int check = result2[p] % 10;
                    if (check % 2 != 0)
                    {
                        result3[countArr] = result2[l];
                        countArr++;
                        continue;
                    }
                }
            }

            return result3;




            //int[] result3 = new int[result2.Length];
            //int countOdd = 0;
            //for (int i = 0; i < result2.Length; i++)
            //{
            //    while (result2[i] % 10 != 0)
            //    {
            //        int check = result2[i] % 10;
            //        if (check % 2 != 0)
            //        {
            //            result3[countOdd] = result2[i];
            //            countOdd++;
            //        }

            //        result2[i] /= 10;
            //    }
            //}

            


        }

        //static void GetTopNuber(int num)
        //{
        //    for (int i = 1; i <= num; i++)
        //    {
        //    int sum = 0;
        //        string numberToString = i.ToString();
        //        for (int j = 0; j < numberToString.Length; j++)
        //        {
        //            sum += numberToString[j];
        //        }

        //        if (sum % 8 == 0)
        //        {
        //            string sumToString = sum.ToString();
        //            for (int k = 0; k < sumToString.Length; k++)
        //            {
        //                if (sumToString[k] % 2 != 0)
        //                {
        //                    Console.WriteLine(sum);
        //                }
        //            }
        //        }

        //    }


        //}
    }
}

﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

            List<int> numbers = inputString
                .Where(x => char.IsDigit(x))
                .Select(x => x.ToString())
                .Select(int.Parse)
                .ToList();

            List<string> text = inputString
                .ToCharArray()
                .Where(x => x < '0' || x > '9')
                .Select(x => x.ToString())
                .ToList();

            List<int> takeList = numbers
                .Where((x, index) => index % 2 == 0)
                .ToList();

            List<int> skipList = numbers
                .Where((x, index) => index % 2 != 0)
                .ToList();

            string result = string.Empty;
            int index = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = text
                    .Skip(index)
                    .Take(takeList[i])
                    .ToList();

                result += string.Concat(temp);
                index += takeList[i] + skipList[i];
            }

            Console.WriteLine(result);

        }
              
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> productsItem = new Dictionary<string, List<double>>();

            string[] inputData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (inputData[0] != "buy")
            {
                string key = inputData[0];
                double price = double.Parse(inputData[1]);
                double quantity = double.Parse(inputData[2]);


                if (!productsItem.ContainsKey(inputData[0]))
                {
                    List<double> currentList = new List<double> {price, quantity};
                    productsItem.Add(key, currentList);
                }
                else
                {

                    productsItem[key][0] = price;
                    productsItem[key][1] += quantity;
                }

                inputData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var item in productsItem)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }

        }
    }
}

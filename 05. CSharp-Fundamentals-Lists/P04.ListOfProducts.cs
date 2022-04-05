using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> productList = new List<string>();

            while (number > 0)
            {
                string products = Console.ReadLine();
                productList.Add(products);
                number--;
            }            

            productList.Sort();

            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productList[i]}");
            }
        }
    }
}

using System;

namespace P05.Orders
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            int quntity = int.Parse(Console.ReadLine());

            calculationOrders(product, quntity);  

        }

        static void calculationOrders(string name, double number)

        {
            switch (name)
            {
                case "coffee":
                    Console.WriteLine($"{number * 1.50:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{number * 1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{number * 1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{number * 2.00:f2}");
                    break;
            }
        }
    }
}

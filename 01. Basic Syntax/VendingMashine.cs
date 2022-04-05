using System;

namespace VendingMashine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double totalCoins = 0;

            while (coins != "Start")
            {
                double coin = double.Parse(coins);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                totalCoins += coin;                    
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                coins = Console.ReadLine();
            }

            string product = Console.ReadLine().ToLower();

            while (product != "end")
            {                       
                if (product != "nuts" && product != "water" && product != "crisps" && product != "soda" && product != "coke")
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine().ToLower();
                    continue;
                }

                if (product == "nuts" && totalCoins >= 2)
                {
                    totalCoins -= 2;
                    Console.WriteLine($"Purchased {product}");
                }
                else if (product == "water" && totalCoins >= 0.7)
                {
                    totalCoins -= 0.7;
                    Console.WriteLine($"Purchased {product}");
                }
                else if (product == "crisps" && totalCoins >= 1.5)
                {
                    totalCoins -= 1.5;
                    Console.WriteLine($"Purchased {product}");
                }
                else if (product == "soda" && totalCoins >= 0.8)
                {
                    totalCoins -= 0.8;
                    Console.WriteLine($"Purchased {product}");
                }
                else if (product == "coke" && totalCoins >= 1)
                {
                    totalCoins -= 1;
                    Console.WriteLine($"Purchased {product}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                    
                product = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {totalCoins:f2}");


        }
    }
}

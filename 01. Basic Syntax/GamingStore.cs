using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            //double OutFall4 = 39.99;
            //double CSOG = 15.99;
            //double ZplinterZell = 19.99;
            //double Honored2 = 59.99;
            //double RoverWatch = 29.99;
            //double RoverWatchOriginsEdition = 39.99;

            string gameBuy = Console.ReadLine();
            double costGame = 0;
            bool notMoney = true;

            while (gameBuy != "Game Time")
            {


                if (gameBuy != "OutFall 4" && gameBuy != "CS: OG" && gameBuy != "Zplinter Zell" && gameBuy != "Honored 2" && gameBuy != "RoverWatch" && gameBuy != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }

                if (gameBuy == "OutFall 4")
                {
                    if (currentBalance > 39.99)
                    {
                        currentBalance -= 39.99;
                        costGame += 39.99;
                        Console.WriteLine($"Bought {gameBuy}");
                    }
                    else if (currentBalance == 39.99)
                    {
                        costGame += 39.99;
                        Console.WriteLine($"Bought {gameBuy}");
                        Console.WriteLine("Out of money!");
                        notMoney = false;
                    }
                    else if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameBuy == "CS: OG")
                {
                    if (currentBalance > 15.99)
                    {
                        currentBalance -= 15.99;
                        costGame += 15.99;
                        Console.WriteLine($"Bought {gameBuy}");
                    }
                    else if (currentBalance == 15.99)
                    {
                        costGame += 15.99;
                        Console.WriteLine($"Bought {gameBuy}");
                        Console.WriteLine("Out of money!");
                        notMoney = false;
                    }
                    else if (currentBalance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameBuy == "Zplinter Zell")
                {
                    if (currentBalance > 19.99)
                    {
                        currentBalance -= 19.99;
                        costGame += 19.99;
                        Console.WriteLine($"Bought {gameBuy}");
                    }
                    else if (currentBalance == 19.99)
                    {
                        costGame += 19.99;
                        Console.WriteLine($"Bought {gameBuy}");
                        Console.WriteLine("Out of money!");
                        notMoney = false;
                    }
                    else if (currentBalance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameBuy == "Honored 2")
                {
                    if (currentBalance > 59.99)
                    {
                        currentBalance -= 59.99;
                        costGame += 59.99;
                        Console.WriteLine($"Bought {gameBuy}");
                    }
                    else if (currentBalance == 59.99)
                    {
                        costGame += 59.99;
                        Console.WriteLine($"Bought {gameBuy}");
                        Console.WriteLine("Out of money!");
                        notMoney = false;
                    }
                    else if (currentBalance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameBuy == "RoverWatch")
                {
                    if (currentBalance > 29.99)
                    {
                        currentBalance -= 29.99;
                        costGame += 29.99;
                        Console.WriteLine($"Bought {gameBuy}");
                    }
                    else if (currentBalance == 29.99)
                    {
                        costGame += 29.99;
                        Console.WriteLine($"Bought {gameBuy}");
                        Console.WriteLine("Out of money!");
                        notMoney = false;
                    }
                    else if (currentBalance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameBuy == "RoverWatch Origins Edition")
                {
                    if (currentBalance > 39.99)
                    {
                        currentBalance -= 39.99;
                        costGame += 39.99;
                        Console.WriteLine($"Bought {gameBuy}");
                    }
                    else if (currentBalance == 39.99)
                    {
                        costGame += 39.99;
                        Console.WriteLine($"Bought {gameBuy}");
                        Console.WriteLine("Out of money!");
                        notMoney = false;
                    }
                    else if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                gameBuy = Console.ReadLine();
                
            }

            if (notMoney)
            {
                Console.Write($"Total spent: ${costGame:f2}. ");
                Console.WriteLine($"Remaining: ${currentBalance:f2}");
            }


        }
    }
}

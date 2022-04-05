using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOrders = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            while (nOrders > 0)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int dayNumber = int.Parse(Console.ReadLine());
                int capsuleNumber = int.Parse(Console.ReadLine());

                double currentPrise = (dayNumber * capsuleNumber) * priceCapsule;
                Console.WriteLine($"The price for the coffee is: ${currentPrise:f2}");

                totalPrice += currentPrise;

                nOrders--;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");



        }
    }
}

using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;
            double dayPrice = 0;

            if (day == "Friday")
            {
                if (typeGroup == "Students")
                {
                    dayPrice = 8.45;
                }
                else if (typeGroup == "Business")
                {
                    dayPrice = 10.90;
                }
                else if (typeGroup == "Regular")
                {
                    dayPrice = 15.00;
                }
            }
            if (day == "Saturday")
            {
                if (typeGroup == "Students")
                {
                    dayPrice = 9.80;
                }
                else if (typeGroup == "Business")
                {
                    dayPrice = 15.60;
                }
                else if (typeGroup == "Regular")
                {
                    dayPrice = 20.00;
                }
            }
            if (day == "Sunday")
            {
                if (typeGroup == "Students")
                {
                    dayPrice = 10.46;
                }
                else if (typeGroup == "Business")
                {
                    dayPrice = 16.00;
                }
                else if (typeGroup == "Regular")
                {
                    dayPrice = 22.50;
                }
            }

            if (typeGroup == "Students" && numberPeople >= 30)
            {
                Console.WriteLine($"Total price: {(numberPeople * dayPrice) * 0.85:f2}");
            }
            else if (typeGroup == "Business" && numberPeople >= 100)
            {
                Console.WriteLine($"Total price: {(numberPeople * dayPrice) - (10 * dayPrice):f2}");
            }
            else if (typeGroup == "Regular" && numberPeople >= 10 && numberPeople <= 20)
            {
                Console.WriteLine($"Total price: {(numberPeople * dayPrice) * 0.95:f2}");
            }
            else
            {
                Console.WriteLine($"Total price: {numberPeople * dayPrice:f2}");
            }

        }
    }
}

using System;

namespace P01.DayOfWeek2
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int number = int.Parse(Console.ReadLine());

            string[] arrayDayWeek = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (number >= 1 && number <= arrayDayWeek.Length)
            {
                Console.WriteLine(arrayDayWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

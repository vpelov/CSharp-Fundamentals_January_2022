using System;

namespace P01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] dayArray = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int count = 1;

            if (number > 0 && number <= 7)
            {

                for (int i = 0; i < dayArray.Length; i++)
                {
                    if (count == number)
                    {
                        Console.WriteLine(dayArray[i]);
                    }

                    count++;
                }
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}

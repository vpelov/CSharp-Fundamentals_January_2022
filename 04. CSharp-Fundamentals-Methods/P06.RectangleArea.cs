using System;

namespace P06.RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int heigth= int.Parse(Console.ReadLine());

            int result = getArea(width, heigth);
            Console.WriteLine(result);

        }

        static int getArea(int numberOne, int numberTwo) 
        {
            int myltiply = numberOne * numberTwo;
            return myltiply;        
        }

    }
}

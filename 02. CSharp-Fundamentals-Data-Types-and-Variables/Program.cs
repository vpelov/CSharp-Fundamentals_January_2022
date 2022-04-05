using System;

namespace VolumeOfPyramyd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heigh = double.Parse(Console.ReadLine());
            double volume = ((lenght * width) * heigh) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}

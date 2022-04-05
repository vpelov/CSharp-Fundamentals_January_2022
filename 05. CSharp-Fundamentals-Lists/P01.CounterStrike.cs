using System;

namespace P01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string power = Console.ReadLine();

            bool isEnd = true;
            int count = 0;

            while (power != "End of battle")
            {
                int currentEnergy = Convert.ToInt32(power);

                if (count % 3 == 0)
                {
                    energy += count;
                }

                if (energy - currentEnergy >= 0)
                {
                    energy -= currentEnergy;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    isEnd = false;
                    break;
                }
                                                
                count++;
                power = Console.ReadLine();
            }

            if (isEnd)
            {
            Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
            }


        }
    }
}

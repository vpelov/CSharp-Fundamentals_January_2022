using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalLightsabersPrise = Math.Ceiling(studentsNumber * 1.1) * lightsabersPrice;
            double totalBeltPrice = (studentsNumber - (studentsNumber / 6)) * beltsPrice;


            double totalMoney = totalLightsabersPrise + totalBeltPrice + (studentsNumber * robePrice);

            
            if (totalMoney <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {totalMoney - money:f2}lv more.");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Snowwhite_WithClass
{
    class Dwarfs
    {
        public Dwarfs(string dwarfName, string dwarfHatColor, int dwarfPhisic)
        {
            this.DwarfName = dwarfName;
            this.DwarfHatColor = dwarfHatColor;
            this.DwarfPhisics = dwarfPhisic;
        }

        public string DwarfName { get; set; }

        public string DwarfHatColor { get; set; }

        public int DwarfPhisics { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dwarfs> dwarfsList = new List<Dwarfs>();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Once upon a time")
            {
                string[] command = inputLine
                    .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = command[0];
                string hatColor = command[1];
                int phisics = int.Parse(command[2]);

                Dwarfs currentDwarf = new Dwarfs(name, hatColor, phisics);

                if (dwarfsList.Any(x => x.DwarfName == name))
                {
                    Dwarfs current = dwarfsList.First(x => x.DwarfName == name);
                    if (current.DwarfHatColor == hatColor && current.DwarfPhisics < phisics)
                    {
                        current.DwarfPhisics = phisics;
                    }
                    else if (current.DwarfHatColor == hatColor && current.DwarfPhisics >= phisics)
                    {
                        continue;
                    }
                    else if (current.DwarfHatColor != hatColor)
                    {
                        dwarfsList.Add(currentDwarf);
                    }
                }
                else
                {
                    dwarfsList.Add(currentDwarf);
                }

            }
                       
            foreach (Dwarfs item in dwarfsList.OrderByDescending(x => x.DwarfPhisics).ThenByDescending(x => dwarfsList.Count(y => y.DwarfHatColor == x.DwarfHatColor)).ToList())
            {
                Console.WriteLine($"({item.DwarfHatColor}) {item.DwarfName} <-> {item.DwarfPhisics}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.DragonArmy
{
    class Dragon
    {
        public Dragon(string type, string name, int damage, int health, int armor)
        {
            this.Type = type;
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }

        public string Type { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dragon> dragonList = new List<Dragon>();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = command[0];
                string name = command[1];

                int damage;
                if (command[2].All(char.IsDigit))
                {
                    damage = int.Parse(command[2]);
                }
                else
                {
                    damage = 45;
                }

                int health;
                if (command[3].All(char.IsDigit))
                {
                   health = int.Parse(command[3]);
                }
                else
                {
                    health = 250;
                }

                int armor;
                if (command[4].All(char.IsDigit))
                {
                    armor = int.Parse(command[4]);
                }
                else
                {
                    armor = 10;
                }

                Dragon currentDragon = new Dragon(type, name, damage, health, armor);
                if (dragonList.Any(x => x.Name == name))
                {
                    Dragon workDragon = dragonList.First(x => x.Name == name);
                    if (workDragon.Type == type)
                    {
                        workDragon.Health = health;
                        workDragon.Armor = armor;
                        workDragon.Damage = damage;
                    }
                    else
                    {
                        dragonList.Add(currentDragon);
                    }

                }
                else
                {
                    dragonList.Add(currentDragon);
                }
            }

            List<string> typeList = new List<string>();
            foreach (Dragon item in dragonList)
            {
                if (typeList.Contains(item.Type))
                {
                    continue;
                }
                else
                {
                    typeList.Add(item.Type);
                }
            }

            for (int i = 0; i < typeList.Count; i++)
            {
                List<Dragon> typeDragon = new List<Dragon>();
                string currentType = typeList[i];
                foreach (Dragon item in dragonList)
                {
                    if (item.Type == currentType)
                    {
                        typeDragon.Add(item);
                    }
                }

                typeDragon = typeDragon.OrderBy(x => x.Name).ToList();

                Console.WriteLine($"{currentType}::({typeDragon.Average(x => x.Damage):f2}/{typeDragon.Average(x => x.Health):f2}/{typeDragon.Average(x => x.Armor):f2})");
                foreach (Dragon item in typeDragon)
                {
                    Console.WriteLine($"-{item.Name} -> damage: {item.Damage}, health: {item.Health}, armor: {item.Armor}");
                }
            }           
           
        }
    }
}

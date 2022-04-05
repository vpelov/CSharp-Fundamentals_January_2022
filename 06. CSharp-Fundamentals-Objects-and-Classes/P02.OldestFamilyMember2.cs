using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OldestFamilyMember2
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }


        
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> personList = new List<Person>();
            int numberPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberPeople; i++)
            {
                string[] inputData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputData[0];
                int age = int.Parse(inputData[1]);

                Person person = new Person(name, age);
                personList.Add(person);
                

            }
            GetOldest(personList);
        }


        static void GetOldest(List<Person> personList)
        {
            int bigAge = int.MinValue;
            string name = string.Empty;

            foreach (var item in personList)
            {
                if (item.Age > bigAge)
                {
                    bigAge = item.Age;
                    name = item.Name;
                }
            }

            Console.WriteLine($"{name} {bigAge}");
        
        }
    }
}

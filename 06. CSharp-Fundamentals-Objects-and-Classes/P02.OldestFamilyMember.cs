using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OldestFamilyMember
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


        public Person GetOldMember()
        {

            Person oldestPerson = Family.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestPerson;

        }
    }


    class Family
    {
        public Family(Person newPerson)
        {
            AllPerson.Add(newPerson);
        }

        public List<Person> AllPerson { get; set; } = new List<Person>();    
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}

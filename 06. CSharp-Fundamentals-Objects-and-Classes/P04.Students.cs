using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();
            string[] inputData = Console.ReadLine().Split().ToArray();

            while (inputData[0] != "end")
            {
                Student currentStudent = new Student();

                currentStudent.FirstName = inputData[0];
                currentStudent.LastName = inputData[1];
                currentStudent.Age = int.Parse(inputData[2]);
                currentStudent.HomeTown = inputData[3];

                allStudents.Add(currentStudent);

                inputData = Console.ReadLine().Split().ToArray();
            }

            string cityName = Console.ReadLine();

            for (int i = 0; i < allStudents.Count; i++)
            {
                if (cityName == allStudents[i].HomeTown)
                {
                    Console.WriteLine($"{allStudents[i].FirstName} {allStudents[i].LastName} is {allStudents[i].Age} years old.");
                }
            }


        }
    }
}

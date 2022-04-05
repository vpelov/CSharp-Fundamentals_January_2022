using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.Students_2._0
{
    class Students
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown{ get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Students> allStudentsList = new List<Students>();

            string[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (inputData[0] != "end")
            {
                Students currentStudent = new Students();

                currentStudent.FirstName = inputData[0];
                currentStudent.LastName = inputData[1];
                currentStudent.Age = int.Parse(inputData[2]);
                currentStudent.HomeTown = inputData[3];

                if (allStudentsList.Count == 0)
                {
                    allStudentsList.Add(currentStudent);
                }
                else
                {
                    for (int i = 0; i < allStudentsList.Count; i++)
                    {
                        if (currentStudent.FirstName == allStudentsList[i].FirstName && currentStudent.LastName == allStudentsList[i].LastName)
                        {
                            allStudentsList.RemoveAt(i);
                            allStudentsList.Add(currentStudent);
                            break;
                        }
                        else if (i == allStudentsList.Count - 1)
                        {
                            allStudentsList.Add(currentStudent);
                            break;

                        }
                    }
                }
              
                inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }


            string cityName = Console.ReadLine();

            for (int i = 0; i < allStudentsList.Count; i++)
            {
                if (cityName == allStudentsList[i].HomeTown)
                {
                    Console.WriteLine($"{allStudentsList[i].FirstName} {allStudentsList[i].LastName} is {allStudentsList[i].Age} years old.");
                }
            }
        }  
    }
}



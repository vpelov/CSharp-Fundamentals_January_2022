using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesReg = new Dictionary<string, List<string>>();

            string[] inputData = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (inputData[0] != "end")
            {
                string coursesName = inputData[0];
                string studentName = inputData[1];

                if (!coursesReg.ContainsKey(coursesName))
                {
                    List<string> currentList = new List<string>() {studentName};
                    coursesReg.Add(coursesName, currentList);
                }
                else
                {
                    coursesReg[coursesName].Add(studentName);
                }

                inputData = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }


            foreach (var item in coursesReg)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var student in item.Value)
                {                    
                    Console.WriteLine($"-- {student}");                    
                }

                //for (int i = 0; i < item.Value.Count; i++)           // Valid Too
                //{
                //    Console.WriteLine($"-- {item.Value[i]}");
                //}
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentData = new Dictionary<string, List<double>>();

            int numberStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberStudent; i++)                       // Read input
            {
                string studentName = Console.ReadLine();
                double gradeStudent = double.Parse(Console.ReadLine());

                if (studentData.ContainsKey(studentName))
                {
                    studentData[studentName].Add(gradeStudent);
                }
                else
                {
                    List<double> currentListGrade = new List<double>() {gradeStudent};
                    studentData.Add(studentName, currentListGrade);
                }
            }


            Dictionary<string, double> printDict = new Dictionary<string, double>();

            foreach (var item in studentData)
            {
                double average = item.Value.Average();
                if (average >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {average:f2}");
                }
            }

        }
    }
}

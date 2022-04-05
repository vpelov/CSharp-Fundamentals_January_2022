using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CompanyRoster
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;

            this.Salary = salary;

            this.Department = department;
        }

        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department{ get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Read data

            List<Employee> employeeList = new List<Employee>();
            int numberEmploey = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberEmploey; i++)
            {
                string[] inputData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Employee currentEmploer = new Employee(inputData[0], double.Parse(inputData[1]), inputData[2]);

                employeeList.Add(currentEmploer);
            }

            // Caclulate

            Dictionary<string, List<double>> emploeeDict = new Dictionary<string, List<double>>();

            for (int i = 0; i < employeeList.Count; i++)
            {
                string newDepartment = employeeList[i].Department;
                double newSalary = employeeList[i].Salary;

                if (!emploeeDict.ContainsKey(newDepartment))
                {
                    emploeeDict[newDepartment] = new List<double>();
                }
                emploeeDict[(newDepartment)].Add(newSalary);
            }

            string departmentHighAverageSalary = emploeeDict.OrderByDescending(x => x.Value.Average()).First().Key;

            // Print

            employeeList = employeeList
                .Where(x => x.Department == departmentHighAverageSalary)
                .OrderByDescending(x => x.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {departmentHighAverageSalary}");

            foreach (var item in employeeList)
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }
        }
    }
}

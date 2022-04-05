using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SpeedRasing
{
    class Car
    {
        public Car(string model, decimal fuelAmount, decimal fuelPerKilometers)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelPerKilometers = fuelPerKilometers;
        }

        public string Model { get; set; }

        public decimal FuelAmount { get; set; }

        public decimal FuelPerKilometers { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCars = int.Parse(Console.ReadLine());
            List<Car> dataCars = new List<Car>();

            for (int i = 0; i < numberCars; i++)
            {
                string[] inputData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = inputData[0];
                decimal fuelAmount = decimal.Parse(inputData[1]);
                decimal fuelPerKilo = decimal.Parse(inputData[2]);

                Car currentCar = new Car(model, fuelAmount, fuelPerKilo);
                dataCars.Add(currentCar);
            }


            Dictionary<string, decimal> carTraveled = new Dictionary<string, decimal>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArray = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string carModel = commandArray[1];
                decimal distanceOfKm = decimal.Parse(commandArray[2]);

                for (int i = 0; i < dataCars.Count; i++)
                {
                    if (dataCars[i].Model == carModel)
                    {
                        decimal needFuel = distanceOfKm * dataCars[i].FuelPerKilometers;
                        if (needFuel > dataCars[i].FuelAmount)
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                            break;
                        }
                        else
                        {
                            dataCars[i].FuelAmount -= needFuel;
                            if (carTraveled.ContainsKey(dataCars[i].Model))
                            {
                                carTraveled[dataCars[i].Model] += distanceOfKm;
                            }
                            else
                            {
                                carTraveled.Add(dataCars[i].Model, distanceOfKm);
                            }
                            break;
                        }
                    }
                }


                command = Console.ReadLine();
            }
            N

            foreach (var car in dataCars)
            {
                if (carTraveled.ContainsKey(car.Model))
                {
                    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {carTraveled[car.Model]}");
                }
                else
                {
                    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {0}");

                }
            }
        }
    }
}

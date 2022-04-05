using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.VenhicleCataloque
{
    class Truck
    {

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

        public Truck(string Brand, string Model, int Weight)
        {
            this.Brand = Brand;

            this.Model = Model;

            this.Weight = Weight;
        }
    }

    class Car
    {

        public Car(string nameBrand, string nameModel, int powerHorse)
        {
            this.Brand = nameBrand;

            this.Model = nameModel;

            this.HorsePower = powerHorse;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

    }

    class Collection
    {
        public List<string> CarCollection { get; set; }

        public List<string> TruckCollection { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Car> carCataloque = new List<Car>();
            List<Truck> truckCataloque = new List<Truck>();


            while (command != "end")
            {
                string[] inputCommand = command.Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputCommand[0] == "Car")
                {
                    Car currentCar = new Car(inputCommand[1], inputCommand[2], int.Parse(inputCommand[3]));

                    carCataloque.Add(currentCar);

                }
                else if (inputCommand[0] == "Truck")
                {
                    Truck currentTruck = new Truck(inputCommand[1], inputCommand[2], int.Parse(inputCommand[3]));
                    truckCataloque.Add(currentTruck);
                }

                command = Console.ReadLine();
            }

            carCataloque = carCataloque.OrderBy(car => car.Brand).ToList();
            truckCataloque = truckCataloque.OrderBy(truck => truck.Brand).ToList();


            if (carCataloque.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car cars in carCataloque)
                {
                    Console.WriteLine($"{cars.Brand}: {cars.Model} - {cars.HorsePower}hp");
                }
            }

            if (truckCataloque.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truks in truckCataloque)
                {
                    Console.WriteLine($"{truks.Brand}: {truks.Model} - {truks.Weight}kg");
                }

            }
        }
    }
}

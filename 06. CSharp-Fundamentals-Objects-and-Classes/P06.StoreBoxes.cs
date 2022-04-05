using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.StoreBoxes
{
    class Box
    {
        public int SerialNumber { get; set; }

        public string Item { get; set; }

        public double Quantity { get; set; }

        public double Price { get; set; }

        public double TotalPrice{ get; set; }
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            List<Box> allBox = new List<Box>();

            string[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (inputData[0] != "end")
            {
                Box currentBox = new Box();

                currentBox.SerialNumber = int.Parse(inputData[0]);
                currentBox.Item = inputData[1];
                currentBox.Quantity = double.Parse(inputData[2]);
                currentBox.Price = double.Parse(inputData[3]);
                currentBox.TotalPrice = currentBox.Quantity * currentBox.Price;


                allBox.Add(currentBox);

                inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            List<Box> printBox = allBox.OrderByDescending(x => x.TotalPrice).ToList();


            for (int i = 0; i < allBox.Count; i++)
            {
                Console.WriteLine($"{printBox[i].SerialNumber}");
                Console.WriteLine($"-- {printBox[i].Item} - ${printBox[i].Price:f2}: {printBox[i].Quantity}");
                Console.WriteLine($"-- ${printBox[i].TotalPrice:f2}");
                   
            }            
        }
    }
}



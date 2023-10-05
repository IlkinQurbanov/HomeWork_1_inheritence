using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Audi", "A6", 10000, 50);

            
            Console.WriteLine(car.Brand); 
            Console.WriteLine(car.Model); 
            Console.WriteLine(car.Mileage); 
            Console.WriteLine(car.FuelCapacity);

           
            car.AddFuel(20);

          
            Console.WriteLine(car.FuelCapacity);

        }
    }

   
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }

        public Vehicle(string brand, string model, int mileage)
        {
            Brand = brand;
            Model = model;
            Mileage = mileage;
        }
    }

   
    public class Car : Vehicle
    {
        public int FuelCapacity { get; set; }

        public Car(string brand, string model, int mileage, int fuelCapacity) : base(brand, model, mileage)
        {
            FuelCapacity = fuelCapacity;
        }


        public void AddFuel(int liters)
        {
            if (liters <= FuelCapacity)
            {
                FuelCapacity += liters;
            }
        }

    }
}

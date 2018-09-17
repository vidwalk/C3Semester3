using System;
using System.Collections.Generic;

namespace Exercise3._9
{
    class Car{
        String color;
        int engineSize;
        double fuelEconomy;

        public double FuelEconomy { get => fuelEconomy; set => fuelEconomy = value; }
        public int EngineSize { get => engineSize; set => engineSize = value; }
        public string Color { get => color; set => color = value; }
        public override String ToString()
        {
            return "Color: " + Color + " EngineSize: " + EngineSize + " FuelEconomy: " + FuelEconomy + " ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(){Color = "Black", EngineSize = 2, FuelEconomy = 6};
            Car car2 = new Car(){Color = "Red", EngineSize = 4, FuelEconomy = 5.5};
            Car car3 = new Car(){Color = "Black", EngineSize = 4, FuelEconomy = 9};
            List<Car> cars = new List<Car>(){car1, car2, car3};
            Predicate<Car> colorFinder = (Car c) => {return c.Color == "Black"; };
            List<Car> carsResults = cars.FindAll(colorFinder);
            System.Console.WriteLine("Predicate expression");
            foreach(Car i in carsResults)
            {
                System.Console.WriteLine(i.ToString());
            }
            System.Console.WriteLine("Lambda expression Color");
            List<Car> carsResults2 = cars.FindAll((Car c) => c.Color == "Red");
            foreach(Car i in carsResults2)
            {
                System.Console.WriteLine(i.ToString());
            }
            System.Console.WriteLine("Lambda expression EngineSize");
            List<Car> carsResults3 = cars.FindAll((Car c) => c.EngineSize > 2);
            foreach(Car i in carsResults3)
            {
                System.Console.WriteLine(i.ToString());
            }
            System.Console.WriteLine("Lambda expression FuelEconomy");
            List<Car> carsResults4 = cars.FindAll((Car c) => c.FuelEconomy < 7);
            foreach(Car i in carsResults4)
            {
                System.Console.WriteLine(i.ToString());
            }
            System.Console.WriteLine("Lambda expression FuelEconomy and Color");
            List<Car> carsResults5 = cars.FindAll((Car c) => c.FuelEconomy < 7 && c.Color == "Black");
            foreach(Car i in carsResults5)
            {
                System.Console.WriteLine(i.ToString());
            }
        }
    }
}

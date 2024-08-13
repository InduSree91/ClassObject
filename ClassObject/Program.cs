using System;

namespace ClassObject
{
    class Program
    {

        static void Main(string[] args)
        {
            Car myCar = new Car { Brand = "Toyota", Model = "Corolla", Year = 2024 };
            myCar.Start();
        }    
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Car has Started");
        }

    }
}
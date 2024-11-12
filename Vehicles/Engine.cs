using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal abstract class Engine
    {
        public bool Running { get; set; }
        public int Horsepower { get; set; }
        public FuelType FuelType { get; set; }

        public Engine(int horsepower, FuelType fuelType)
        {
            Horsepower = horsepower;
            FuelType = fuelType;
        }

        public void Start()
        {
            Running = true;
            Console.WriteLine("Engine is running");
        }
    }

    public enum FuelType
    {
        Unleaded,
        Leaded,
        Diesel
    }
}

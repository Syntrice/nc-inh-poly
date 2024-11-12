using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal abstract class Vehicle
    {
        public Engine EngineType {  get; set; }

        public string MakeName { get; set; }
        public string Model {  get; set; }
        public int Speed { get; set; }

        public Vehicle(string model, string makeName, Engine engineType)
        {
            Model = model;
            MakeName = makeName;
            EngineType = engineType;
        }

        public void StartEngine()
        {
            EngineType.Start();
        }

        public void Drive()
        {
            if (EngineType.Running)
            {
                Accelerate();
            }
            else
            {
                Console.WriteLine($"{MakeName} {Model} is not running.");
            }
        }

        public abstract void Accelerate();


    }
}

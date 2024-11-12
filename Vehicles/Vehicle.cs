using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal abstract class Vehicle
    {
        Engine EngineType {  get; set; }

        public string MakeName { get; set; }
        public string Model {  get; set; }
        public int Speed { get; set; }

        public Vehicle(string model, string makeName, Engine engineType)
        {
            Model = model;
            MakeName = makeName;
            EngineType = engineType;
        }

    }
}

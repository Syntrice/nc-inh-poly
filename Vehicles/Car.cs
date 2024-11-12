using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Car : Vehicle
    {
        public Car(string model, string makeName) : base(model, makeName, new CarEngine(150, FuelType.Diesel))
        {

        }

    }
}

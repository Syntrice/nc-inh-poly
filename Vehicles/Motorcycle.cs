using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string model, string makeName, bool hasSidecar) : base(model, makeName, new MotorcycleEngine(90, FuelType.Unleaded))
        {
            HasSidecar = hasSidecar;
        }

        public bool HasSidecar { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    public abstract class Shape3D
    {
        public Shape BaseShape { get; }

        public Shape3D(Shape baseShape)
        {
            BaseShape = baseShape;
        }

        public abstract double CalculateVolume();

    }
}

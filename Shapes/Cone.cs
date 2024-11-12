using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Cone : Shape3D
    {
        public double Height { get; set; }

        public Cone(Circle circle, double height) : base(circle)
        {
            Height = height;
        }

        public override double CalculateVolume()
        {
            return (BaseShape.CalculateArea() * Height) / 3;
        }
    }
}

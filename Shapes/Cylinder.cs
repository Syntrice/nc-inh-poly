using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cylinder : Shape3D
    {
        public double Height { get; }

        public Cylinder(Circle circle, double height) : base(circle)
        {
            Height = height;
        }

        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
        }
    }
}

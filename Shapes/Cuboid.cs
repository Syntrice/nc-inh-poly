using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cuboid : Shape3D
    {
        public double Height {  get; }

        public Cuboid(Rectangle rectangle, double height) : base(rectangle)
        {
            Height = height;
        }
        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
        }
    }
}

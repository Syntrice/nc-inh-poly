using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : Shape3D
    {

        public Sphere(Circle circle) : base(circle)
        {
            
        }

        public override double CalculateVolume()
        {
            // cast base shape to circle
            Circle circle = (Circle) BaseShape;

            return (Math.PI * Math.Pow(circle.Radius, 3) * 4) / 3;
        }
    }
}

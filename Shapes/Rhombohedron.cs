using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rhombohedron : Shape3D
    {
        public double Height { get; }
        public Rhombohedron(Rhombus rhombus, double height) : base(rhombus)
        {
            Height = height;
        }

        public override double CalculateVolume()
        {
            return Height * BaseShape.CalculateArea();
        }
    }
}

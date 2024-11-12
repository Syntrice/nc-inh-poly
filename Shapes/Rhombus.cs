using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rhombus : Square
    {
        public double Angle1 { get; }
        public double Angle2 { get; }

        public Rhombus(double size, double angle1) : base(size)
        {

            Math.Clamp(angle1, 0.01, 179.99);
            Angle1 = angle1;
            Angle2 = 180 - angle1;
        }

        public override double CalculateArea()
        {
            return (Size * Size);
        }
    }
}

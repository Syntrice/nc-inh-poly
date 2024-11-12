using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Prism : Shape3D
    {
        public double Height { get; }


        public Prism(Shape shape, double height) : base(shape) 
        {
            Height = height;    
        }

        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Prism : Shape3D
    {
        public double Height { get; set; }

        // update to use any base shape
        public Prism(Triangle triangle, double height) : base(triangle) 
        {
            Height = height;    
        }

        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Rectangle
    {
        public double Size { get; set; }
        public Square(double size) : base(size, size)
        {
            Size = size;
        }
    }
}

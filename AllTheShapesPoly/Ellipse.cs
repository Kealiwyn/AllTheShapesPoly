using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheShapesPoly
{
    class Ellipse : Rectangle
    {
        public override double Area {
            get
            {
                return Math.PI * Width * Height;
            }
        }

        public Ellipse(double height, double width) : base(height, width)
        {
            Height = height;
            Width = width;
        }
    }
}

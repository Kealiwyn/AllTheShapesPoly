using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheShapesPoly
{
    class Diamond : Rectangle
    {
        public override double Area { 
            get
            {
                return Width * Height;
            }
        }

        public Diamond(double height, double width) : base("Diamond", height, width)
        {
            Height = height;
            Width = width;
        }
    }
}

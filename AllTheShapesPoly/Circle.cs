using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheShapesPoly
{
    class Circle : Square
    {
        public override double Area {
            get
            {
                return Length * Length * Math.PI;
            }
        }

        public Circle(double length) : base("Circle", length)
        {
            Length = length;
        }
    }
}

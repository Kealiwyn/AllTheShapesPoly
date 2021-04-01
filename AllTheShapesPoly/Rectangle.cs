using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheShapesPoly
{
    class Rectangle : Shape
    {
        protected double Width { get; set; }
        protected double Height { get; set; }
        public override double Area { 
            get
            {
                return Width * Height;
            }
        }

        public Rectangle(double height, double width): base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public Rectangle(string name, double height, double width) : base(name)
        {
            Height = height;
            Width = width;
        }
    }
}

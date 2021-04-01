using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheShapesPoly
{
    abstract class Shape
    {
        public string Name { get; protected set; }
        public abstract double Area { get; }

        public Shape(string name) 
        {
            Name = name;
        }

        public override string ToString()
        {
            return String.Format($"Shape name: {Name,-10} => Area: {Area}");
        }
    }
}

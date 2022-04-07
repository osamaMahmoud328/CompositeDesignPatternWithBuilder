using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    //the Component
    public abstract class DrawingElement
    {
        public DrawingElement(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void Display(int indent);
    }
}

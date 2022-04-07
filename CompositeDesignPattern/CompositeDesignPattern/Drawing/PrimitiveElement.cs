using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string elementName) : base(elementName)
        {

        }
        public override void Display(int indent)
        {
            Console.WriteLine(new String('-',indent) + " "+ Name ); 
        }
    }
}

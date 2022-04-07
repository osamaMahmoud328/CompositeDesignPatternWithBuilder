using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class CompositeElement : DrawingElement
    {

        public List<DrawingElement> ShapesList { get; } = new List<DrawingElement>();
        public CompositeElement(string compositName) : base(compositName)
        {

        }

        public void AddShape(DrawingElement shape)
        {
            ShapesList.Add(shape);
        }
        public void RemoveShape(DrawingElement shape)
        {
            ShapesList.Remove(shape);
        }
        public override void Display(int indent)
        {
            Console.WriteLine(new String('-' , indent) + "+" + Name);

            foreach (var shape in ShapesList)
            {
                shape.Display(indent +2);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Drawing
{
    public class DrawingBuilder
    {
        private CompositeElement CurrentShape;
        public DrawingBuilder(string rootShape)
        {
            RootShape = new CompositeElement(rootShape);
            this.CurrentShape = this.RootShape;
        }


        public CompositeElement RootShape { get; }

        public void AddCompositeShape(string elementName)
        {
            var compositShape = new CompositeElement(elementName);  
            this.CurrentShape.AddShape(compositShape);
            this.CurrentShape = compositShape;
        }

        public void AddPrimitiveElement(string elementName)
        {
            this.CurrentShape.AddShape(new PrimitiveElement(elementName));
        }
        public void SetCurrentShape(string shapeName)
        {
            var tempShape = this.RootShape;
            var shapesStack = new Stack<CompositeElement>();
            shapesStack.Push(tempShape);
            while (shapesStack.Any())
            {
                var currentStackElement = shapesStack.Pop();
                if (currentStackElement.Name == shapeName)
                {
                    this.CurrentShape = currentStackElement;
                    return;
                }
                foreach (var item in currentStackElement.ShapesList.OfType<CompositeElement>())
                {
                    shapesStack.Push(item);   
                }
            }
            throw new InvalidOperationException($"Shape name '{shapeName}' not found!");

        }
    }
}

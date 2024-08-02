using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBIApp
{
    internal class InterfaceRelationshipDemo1
    {
        static void Main(string[] args)
        {
            PaintAppl paint = new PaintAppl();
            paint.Draw(new Rectangle());
            paint.Draw(new Circle());
            paint.Draw(new Line());
            Console.ReadLine();
        }

        class PaintAppl
        {
            public void Draw(IShape shape)
            {
                shape.DrawShape();
            }
        }

        interface IShape
        {
            void DrawShape();
        }

        class Rectangle : IShape
        {
            public void DrawShape()
            {
                Console.WriteLine(  "Inside Rectangle DrawShape method");
            }
        }

        class Circle : IShape 
        {
            public void DrawShape()
            {
                Console.WriteLine("Inside Circle DrawShape method");
            }
        }

        class Line : IShape
        {
            public void DrawShape()
            {
                Console.WriteLine("Inside Line DrawShape method");
            }
        }

    }
}

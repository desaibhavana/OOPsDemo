using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBIApp
{
    internal class InterfaceRelationshipDemo
    {
        static void Main(string[] args)
        {
            PaintAppl paint = new PaintAppl();
            paint.Draw(new Rectangle());
            paint.Draw(new Circle());
            paint.Draw(new Line());
            Console.ReadLine();
            
        }
    }

    class PaintAppl
    {
        public void Draw(Rectangle rectangle)
        {
            rectangle.DrawRectangle();
        }

        public void Draw(Circle circle)
        {
            circle.DrawCircle();    
        }

        public void Draw (Line line)
        {
            line.DrawLine();
        }

    }

    class Rectangle
    {
        public void DrawRectangle()
        {
            Console.WriteLine("inside Rectangle Draw method");
        }
    }

    class Circle
    {
        public void DrawCircle()
        {
            Console.WriteLine("Inside Circle draw method");
        }

    }

    class Line
    {
        public void DrawLine()
        {
            Console.WriteLine("Inside Line draw method");
        }
    }
}

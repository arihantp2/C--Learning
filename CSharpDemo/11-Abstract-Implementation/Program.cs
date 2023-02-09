using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Abstract_Implementation
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;

        public abstract double GetArea();    
    }

    public class Rectangle : Figure
    {
        public Rectangle(double Width,double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
    public class Cone : Figure
    {
        public Cone(double Radius,double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    class TestFigures
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(15);
            Cone cn = new Cone(10, 25);

            Console.WriteLine("Area of rectangle =  "+ r.GetArea());
            Console.WriteLine("Area of Circle =  " + c.GetArea());
            Console.WriteLine("Area of Cone =  " + cn.GetArea());

            Console.ReadLine();
        }
    }
}

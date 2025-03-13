using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Three
{
    public class Circle :Shape, ICalculateArea
    {
        public double Radius { get; set; }
        public Circle(double radius, string name) : base(name)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }
    
    }


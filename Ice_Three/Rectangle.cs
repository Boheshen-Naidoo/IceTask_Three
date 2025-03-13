using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Three
{
    public class Rectangle : Shape, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width, string name) : base(name)
        {
            Length = length;
            Width = width;
        }
        public double CalculateArea()
        {
            return Length * Width;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }
}

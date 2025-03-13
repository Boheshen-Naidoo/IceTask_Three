namespace Ice_Three
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Rectangle rectangle = new Rectangle(8, 12, "Rectangle");
            rectangle.Display();
            Circle circle = new Circle(3, "Circle");
            circle.Display();
        }
    }
}

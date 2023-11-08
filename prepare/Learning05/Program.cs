using System;
using System.Drawing;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Red", 3);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Blue", 4,5);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Green", 6);
        shapes.Add(circle1);

        foreach  (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color}: shape has an area of {area}");
        }
    }
}
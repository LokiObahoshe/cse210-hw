using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        Square square = new Square("blue", 5);
        _shapes.Add(square);

        Rectangle rectangle = new Rectangle("purple", 8, 9);
        _shapes.Add(rectangle);

        Circle circle = new Circle("yellow", 2);
        _shapes.Add(circle);

        Console.Clear();
        foreach (Shape shapes in _shapes)
        {
            string color = shapes.GetColor();
            double area = shapes.GetArea();
            string shapeType = shapes.GetShapeType();

            Console.WriteLine($"The {color} {shapeType} has an area of {area}");
        }

    }
}
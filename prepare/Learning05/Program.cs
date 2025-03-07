using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle("Red", 10, 20));
        shapes.Add(new Circle("Green", 5));
        shapes.Add(new Square("Blue", 10));
        shapes.Add(new Rectangle("Violet", 5, 7));
        shapes.Add(new Circle("Yellow", 3));
        shapes.Add(new Square("Orange", 8));
        shapes.Add(new Circle("Black", 6));

        Rectangle s1 = new Rectangle("Purple", 10, 20);
        shapes.Add(s1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Shape Color: " + shape.GetColor()); 
            Console.WriteLine("Shapes Area: " + shape.GetArea());
        }
    }
}
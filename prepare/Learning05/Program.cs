using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();

        Circle c1 = new Circle("Black", 5);
        shapes.Add(c1);

        Rectangle r1 = new Rectangle("Blue", 2, 3);
        shapes.Add(r1);

        Square s1 = new Square("Green", 5);
        shapes.Add(s1);

        foreach (Shape forma in shapes)
        {
            string color = forma.GetColor;
            double area = forma.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area} units");
        }
        Console.WriteLine();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // ===========================================================================================
        
        // Create a list of Shape objects
        // Polymorphism in action: the list holds the base type (Shape)
        // but can store any derived class (Square, Rectangle, Circle)
        List<Shape> shapes = new List<Shape>();

        // Add different kinds of shapes to the same list
        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("blue", 4, 6));
        shapes.Add(new Circle("green", 3));

        // Iterate through the list using the base class type
        // Each call to GetArea() will automatically use the correct
        // version of the method depending on the actual object type
        // THIS is polymorphism: same line of code, different behavior
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
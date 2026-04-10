// Circle inherits from Shape — it IS a shape
public class Circle : Shape
{
    // A circle only needs a radius
    private float _radius;

    // Constructor accepts color and radius
    // ": base(color)" passes the color up to the parent Shape constructor
    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    // Override the abstract method from Shape
    // Area of a circle = PI * radius * radius
    // Math.PI returns a double, so we cast it to float
    public override float GetArea()
    {
        return (float)Math.PI * _radius * _radius;
    }
}
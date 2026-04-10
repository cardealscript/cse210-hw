// Rectangle inherits from Shape — it IS a shape
public class Rectangle : Shape
{
    // A rectangle needs two sides: length and width
    private float _length;
    private float _width;

    // Constructor accepts color, length, and width
    // ": base(color)" passes the color up to the parent Shape constructor
    public Rectangle(string color, float length, float width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override the abstract method from Shape
    // Area of a rectangle = length * width
    public override float GetArea()
    {
        return _length * _width;
    }
}
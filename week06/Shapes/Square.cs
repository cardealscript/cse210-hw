// Square inherits from Shape — it IS a shape
public class Square : Shape
{
    // A square only needs one side since all sides are equal
    private float _side;

    // Constructor accepts color and side length
    // ": base(color)" passes the color up to the parent Shape constructor
    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    // Override the abstract method from Shape
    // Area of a square = side * side
    public override float GetArea()
    {
        return _side * _side;
    }
}
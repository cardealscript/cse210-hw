// Base class for all shapes
// Declared as abstract because we can't calculate the area of a generic shape
public abstract class Shape
{
    // Stores the color of the paper the shape is cut from
    private string _color;

    // Constructor: every shape must have a color when created
    public Shape(string color)
    {
        _color = color;
    }

    // Getter method to return the color
    public string GetColor()
    {
        return _color;
    }

    // Abstract method: no body here because each shape calculates area differently
    // Every child class is FORCED to override and implement this method
    public abstract float GetArea();
}
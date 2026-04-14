// Derived class for cycling activity
// Stores the speed in miles per hour
public class Cycling : Activity
{
    // The speed of cycling in miles per hour
    private double _speed;

    // Constructor: accepts date, minutes, and speed
    // Passes date and minutes up to the base class constructor
    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // Distance (miles) = (speed / 60) * minutes
    public override double GetDistance()
    {
        return (_speed / 60) * GetMinutes();
    }

    // Returns speed directly since it is stored
    public override double GetSpeed()
    {
        return _speed;
    }

    // Pace (min per mile) = 60 / speed
    public override double GetPace()
    {
        return 60 / _speed;
    }
}
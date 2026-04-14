// Derived class for running activity
// Stores the distance run in miles
public class Running : Activity
{
    // The distance covered during the run in miles
    private double _distance;

    // Constructor: accepts date, minutes, and distance
    // Passes date and minutes up to the base class constructor
    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Returns the distance directly since it is stored
    public override double GetDistance()
    {
        return _distance;
    }

    // Speed (mph) = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    // Pace (min per mile) = minutes / distance
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}
// Derived class for swimming activity
// Stores the number of laps completed in the pool
public class Swimming : Activity
{
    // The number of laps completed (each lap = 50 meters)
    private int _laps;

    // Constructor: accepts date, minutes, and number of laps
    // Passes date and minutes up to the base class constructor
    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // Distance (miles) = laps * 50 / 1000 * 0.62
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;
    }

    // Speed (mph) = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Pace (min per mile) = minutes / distance
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
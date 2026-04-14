// Base abstract class for all activity types
// Contains shared attributes: date and duration
public abstract class Activity
{
    // The date of the activity (e.g., "03 Nov 2022")
    private string _date;

    // The duration of the activity in minutes
    private int _minutes;

    // Constructor: every activity needs a date and duration
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Getter for minutes — needed by derived classes for calculations
    public int GetMinutes()
    {
        return _minutes;
    }

    // Abstract methods: each activity calculates these differently
    // Every derived class is FORCED to implement these
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary is defined ONLY here in the base class
    // It calls the abstract methods above — polymorphism in action!
    // Derived classes do NOT need to override this
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) " +
               $"- Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}
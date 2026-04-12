// Base abstract class for all goal types
// Contains shared attributes and behaviors that every goal has
public abstract class Goal
{
    // The name of the goal (e.g., "Run a marathon")
    protected string _name;

    // A short description of the goal
    protected string _description;

    // Points earned each time this goal is recorded
    protected int _points;

    // Constructor: every goal needs a name, description, and point value
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Returns the name of the goal
    public string GetName()
    {
        return _name;
    }

    // Abstract method: each goal type records progress differently
    // Every child class is FORCED to implement this
    public abstract int RecordEvent();

    // Virtual method: returns a string showing goal status for display
    // ChecklistGoal will override this to show extra info (e.g., 3/10)
    public virtual string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }

    // Abstract method: returns a string representation for saving to file
    public abstract string GetStringRepresentation();
}
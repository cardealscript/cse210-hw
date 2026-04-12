// A goal that never ends — you keep earning points every time you record it
// Example: "Read scriptures" — every time you do it, you get points forever
public class EternalGoal : Goal
{
    // Constructor: accepts name, description, and points
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    // Every time this goal is recorded, points are awarded
    // It never gets marked as complete
    public override int RecordEvent()
    {
        return _points;
    }

    // Always shows [ ] because eternal goals are never "done"
    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }

    // Returns a string to save to file
    // Format: EternalGoal:name,description,points
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}
// A goal that can only be completed once
// Example: "Run a marathon" — complete it, get points, done!
public class SimpleGoal : Goal
{
    // Tracks whether this goal has been completed or not
    private bool _isComplete;

    // Constructor: accepts name, description, and points
    // _isComplete starts as false by default (not yet completed)
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Records the goal as complete and returns the points earned
    // Once complete, it cannot be recorded again
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        // If already complete, no points are awarded
        return 0;
    }

    // Shows [X] if complete, [ ] if not
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    // Returns a string to save to file
    // Format: SimpleGoal:name,description,points,isComplete
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}
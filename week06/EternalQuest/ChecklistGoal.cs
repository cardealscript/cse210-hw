// A goal that must be completed a certain number of times
// Example: "Attend the temple 10 times" — bonus points on the last time!
public class ChecklistGoal : Goal
{
    // How many times the goal has been completed so far
    private int _amountCompleted;

    // How many times it needs to be completed in total
    private int _target;

    // Bonus points awarded when the target is reached
    private int _bonus;

    // Constructor: accepts name, description, points, target, and bonus
    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Records one completion of this goal
    // Returns points + bonus if target is reached
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            // Check if the target has just been reached — award bonus!
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        // Already completed — no more points
        return 0;
    }

    // Overrides to show progress (e.g., Completed 3/10 times)
    // This is why only ChecklistGoal overrides GetDetailsString
    public override string GetDetailsString()
    {
        string status = _amountCompleted >= _target ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_amountCompleted}/{_target} times";
    }

    // Returns a string to save to file
    // Format: ChecklistGoal:name,description,points,target,bonus,amountCompleted
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}
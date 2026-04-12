// EXTRA FEATURE: A goal that SUBTRACTS points for bad habits
// Example: "Ate junk food" — lose 50 points!
public class NegativeGoal : Goal
{
    // Constructor: accepts name, description, and points to lose
    public NegativeGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    // Returns NEGATIVE points — penalizes the user
    public override int RecordEvent()
    {
        return -_points;
    }

    // Always shows [ ] — bad habits are never "done"
    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description}) ⚠️  -{_points} pts";
    }

    // Returns a string to save to file
    // Format: NegativeGoal:name,description,points
    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_name},{_description},{_points}";
    }
}
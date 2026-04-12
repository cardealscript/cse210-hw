using System;
using System.Collections.Generic;
using System.IO;

// This class manages everything: goals list, score, levels, saving and loading
public class GoalManager
{
    // List that holds all the goals (polymorphism: stores any Goal type)
    private List<Goal> _goals;

    // The user's current score
    private int _score;

    // The user's name
    private string _playerName;

    // Random object for surprise bonus feature
    private Random _random;

    // Constructor: initializes the list, score, and player name
    public GoalManager(string playerName)
    {
        _goals = new List<Goal>();
        _score = 0;
        _playerName = playerName;
        _random = new Random();
    }

    // ─────────────────────────────────────────
    // LEVEL SYSTEM (EXTRA FEATURE for 100%)
    // Every 1000 points = 1 level up
    // ─────────────────────────────────────────

    // Returns the current level based on score
    private int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    // Returns a title based on the current level
    private string GetLevelTitle()
    {
        int level = GetLevel();
        if (level <= 2)  return "🌱 Apprentice";
        if (level <= 4)  return "⚔️  Warrior";
        if (level <= 6)  return "🧙 Mage";
        if (level <= 8)  return "🦅 Champion";
        if (level <= 10) return "🏆 Legend";
        return "✨ Eternal Master";
    }

    // Displays the player's current score and level
    public void DisplayScore()
    {
        Console.WriteLine($"\n👤 Player: {_playerName}");
        Console.WriteLine($"⭐ Score : {_score} points");
        Console.WriteLine($"🎮 Level : {GetLevel()} — {GetLevelTitle()}");
    }

    // ─────────────────────────────────────────
    // GOAL MANAGEMENT
    // ─────────────────────────────────────────

    // Adds a new goal to the list
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Displays all goals with their current status
    public void DisplayGoals()
    {
        Console.WriteLine("\n📋 Your Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("  No goals yet. Start adding some!");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            // Polymorphism: calls the correct GetDetailsString for each goal type
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Records an event for a selected goal and adds the points earned
    public void RecordEvent()
    {
        DisplayGoals();

        if (_goals.Count == 0) return;

        Console.Write("\nWhich goal did you accomplish? (enter number): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        // Polymorphism: RecordEvent behaves differently for each goal type
        int pointsEarned = _goals[index].RecordEvent();

        // EXTRA FEATURE: random surprise bonus (10% chance)
        int surpriseBonus = 0;
        if (pointsEarned > 0 && _random.Next(1, 11) == 1)
        {
            surpriseBonus = 100;
            Console.WriteLine("🎉 SURPRISE BONUS! You earned an extra 100 points!");
        }

        _score += pointsEarned + surpriseBonus;

        if (pointsEarned < 0)
        {
            Console.WriteLine($"😬 Recorded. You lost {Math.Abs(pointsEarned)} points.");
        }
        else if (pointsEarned == 0)
        {
            Console.WriteLine("⚠️  This goal is already complete or has no points.");
        }
        else
        {
            Console.WriteLine($"✅ Great job! You earned {pointsEarned} points!");
        }

        // Show updated score and level
        DisplayScore();
    }

    // ─────────────────────────────────────────
    // SAVE AND LOAD
    // ─────────────────────────────────────────

    // Saves all goals and score to a text file
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // First line: player name and score
            outputFile.WriteLine($"{_playerName},{_score}");

            // Each following line: one goal's string representation
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"💾 Goals saved to {filename}");
    }

    // Loads goals and score from a text file
    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("❌ File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        // First line: player name and score
        string[] header = lines[0].Split(",");
        _playerName = header[0];
        _score = int.Parse(header[1]);

        // Remaining lines: each goal
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            // Split on colon to get type and details
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] details = parts[1].Split(",");

            // Factory pattern: create the correct goal type based on the saved type
            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                if (bool.Parse(details[3])) goal.RecordEvent(); // restore completion
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    details[0], details[1],
                    int.Parse(details[2]),
                    int.Parse(details[3]),
                    int.Parse(details[4])
                );
                // Restore how many times it was completed
                int completed = int.Parse(details[5]);
                for (int j = 0; j < completed; j++) goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (type == "NegativeGoal")
            {
                _goals.Add(new NegativeGoal(details[0], details[1], int.Parse(details[2])));
            }
        }

        Console.WriteLine($"📂 Goals loaded from {filename}");
        DisplayScore();
    }

    // ─────────────────────────────────────────
    // CREATING NEW GOALS (user input)
    // ─────────────────────────────────────────

    // Guides the user through creating a new goal
    public void CreateGoal()
    {
        Console.WriteLine("\nWhat type of goal?");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Negative Goal (bad habit) ⚠️");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Name of goal: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times to complete: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else if (choice == "4")
        {
            _goals.Add(new NegativeGoal(name, description, points));
        }

        Console.WriteLine("✅ Goal created!");
    }
}
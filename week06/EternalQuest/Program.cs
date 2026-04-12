using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        // =====================================================
        // Eternal Quest Program
        // Extra features added for 100%:
        // 1. Level system (every 1000 pts = level up with title)
        // 2. Negative Goals (lose points for bad habits)
        // 3. Surprise bonus (10% chance of extra 100 points)
        // =====================================================

        Console.WriteLine("Welcome to Eternal Quest! 🌟");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        GoalManager manager = new GoalManager(name);

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n========== MENU ==========");
            Console.WriteLine("1. Display Score");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")      manager.DisplayScore();
            else if (choice == "2") manager.DisplayGoals();
            else if (choice == "3") manager.CreateGoal();
            else if (choice == "4") manager.RecordEvent();
            else if (choice == "5")
            {
                Console.Write("Filename to save: ");
                string filename = Console.ReadLine();
                manager.SaveGoals(filename);
            }
            else if (choice == "6")
            {
                Console.Write("Filename to load: ");
                string filename = Console.ReadLine();
                manager.LoadGoals(filename);
            }
            else if (choice == "7") running = false;
            else Console.WriteLine("Invalid option, try again.");
        }

        Console.WriteLine("\nGoodbye! Keep working on your Eternal Quest! 🌟");

    }
}
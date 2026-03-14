// Exceeds requirements:
// - Added error handling in Load() to prevent crashes when file is not found
// - Added friendly welcome message

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal!");

        // =============================================

        Journal journal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\n=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                journal.Save();
            }
            else if (choice == "4")
            {
                journal.Load();
            }
            else if (choice != "5")
            {
                Console.WriteLine("Invalid option, try again.");
            }
        }

        Console.WriteLine("Goodbye!");

    }
}
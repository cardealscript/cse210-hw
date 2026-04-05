// EXTRAS PARA 100%:
// 1. Prompts e perguntas não se repetem até todos terem sido usados
// 2. Log guardado em ficheiro "log.txt" com data, atividade e duração
// 3. Menu opção 4 para ver o histórico de atividades

using System;
using System.IO;

class Program
{
    static void LogActivity(string activityName, int duration)
    {
        string entry = $"{DateTime.Now:dd/MM/yyyy HH:mm} - {activityName} - {duration} seconds";
        File.AppendAllText("log.txt", entry + Environment.NewLine);
    }

    static void ShowLog()
    {
        Console.Clear();
        Console.WriteLine("=== Activity Log ===\n");
        if (File.Exists("log.txt"))
            Console.WriteLine(File.ReadAllText("log.txt"));
        else
            Console.WriteLine("No activities logged yet.");
        Console.WriteLine("\nPress Enter to return...");
        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Program ===\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. View Activity Log");
            Console.WriteLine("  5. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
                LogActivity("Breathing Activity", b.GetDuration());
            }
            else if (choice == "2")
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
                LogActivity("Reflection Activity", r.GetDuration());
            }
            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity();
                l.Run();
                LogActivity("Listing Activity", l.GetDuration());
            }
            else if (choice == "4")
            {
                ShowLog();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}
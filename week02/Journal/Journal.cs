using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // lista que guarda todas as entradas
    private List<Entry> _entries = new List<Entry>();

    // lista de prompts (perguntas)
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?"
    };

    private Random _random = new Random();

    public void AddEntry()
    {
        // escolhe um prompt aleatório
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        // cria uma nova entrada e adiciona à lista
        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.GetSaveLine());
            }
        }
        Console.WriteLine("Journal saved!");
    }

    public void Load()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        // verifica se o ficheiro existe antes de carregar
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found! Please check the filename.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry(parts[1], parts[2], parts[0]);
            _entries.Add(entry);
        }
        Console.WriteLine("Journal loaded!");
    }
}
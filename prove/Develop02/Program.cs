using System;
using System.Collections;
using System.Security.Principal;
using System.Transactions;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("welcome to your personal lif library");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display personal life library");
            Console.WriteLine("3. SAve to file");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("make a selection(1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    journal.AddEntry(new Entry(date, prompt, response));
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    string saveFile = "Journal.csv";
                    journal.SaveToFile(saveFile);
                    Console.WriteLine($"Saved to {saveFile}");
                    break;
                case "4":
                    string loadFile = "Journal.csv";
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine($"Loaded from {loadFile}");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine();
        }
    }
}
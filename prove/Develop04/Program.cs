using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. QUIT");
        Console.Write("Select an activity (1-4): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                new BreathingActivity().Run();
                break;
            case "2":
                new ReflectionActivity().Run();
                break;
            case "3":
                new ListingActiviy().Run();
                break;
            case "4":
                Console.WriteLine("BYE BYE!");
                return;
            default:
                Console.WriteLine("Invalid choice.");
                thread.Sleep(1000);
                break;
        }
    }
}
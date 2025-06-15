using system;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "List 10 things you are grateful for.",
        "Write down 5 goals you want to achieve this year.",
        "List 3 things that make you happy.",
        "Write down 5 people who inspire you and why.",
        "List 10 achievements you are proud of."
    };
    public ListingActivity()
        : base("listing Activity", "This activity will help you reflect on the good things in your life by listing them out. Clear your mind and focus on the positive aspects.") { }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Length)]);
        Countdown(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }
        Console.WWriteLine("\nYou Listed {items.Count} items:");
        End();
    }    
}   

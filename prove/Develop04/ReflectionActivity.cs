using System;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Think of a time when you felt proud of yourself.",
        "Reflect on a challenge you overcame.",
        "Consider a person who has had a significant impact on your life.",
        "Think about a moment that made you feel grateful.",
        "Reflect on a lesson you learned the hard way."
    };
    private string[] _questions = {
        "What did you learn from this experience?",
        "How did this situation change you?",
        "What would you do differently if you faced this again?",
        "How can you apply this lesson in your life now?",
        "What are you grateful for in this situation?"
    };
    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Length)]);
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.WriteLine(question);
            ShowSpinner(5);
            elapsed += 5;
        }
        End();
    }
   
}
using System;
using System.Collections.Generic;


public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "What are you grateful for?",
        "What was a challenge you faced today?",
        "What is something you want to improve on?",
        "What made you smile today?",
        "What is a goal you have for tomorrow?"
    };
    public string GetRandomPrompt()
    {
        Random rand= new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}
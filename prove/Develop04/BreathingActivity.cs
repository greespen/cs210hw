using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        Start();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            CountDown(4);
            elapsed += 4;
            if (elapsed >= _duration) break;
            Console.WriteLine("Breathe out...");
            CountDown(6);
            elapsed += 6;

        }
        End();

    }
}
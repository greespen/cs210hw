using system;
using System.Threading;

public abstract class MindfulnessActivity
{
    private string _name;
    private string _description;
    protected int _duratrion;

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"STARTING {_name.Toupper()}");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the duration in seconds:");
        _duratrion = int.Parse(Console.ReadLine());
        Console.WriteLine($"Have Fun!....");
        ShowSpinner(3);
    }
    public void End()
    {
        Console.WriteLine($"\n Great Job!");
        Console.WriteLine($"You Completed {_name} for {_duratrion} seconds.");
        ShowSpinner(3);
    }
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("|/-\\"[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b");

        }

    }
    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public abstract void Run();
}
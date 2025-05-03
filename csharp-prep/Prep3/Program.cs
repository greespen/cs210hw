using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 10);
        int guess;

        do
        {
            Console.Write("Guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess != magicNumber)
            {
                Console.WriteLine("Nope");
            }
            else
            {
                Console.WriteLine("Yay, that was it!");
            }
        } while (guess != magicNumber);
    }
}
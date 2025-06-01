using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma 7", 24);
        string text = "And see that ye have faith, hope, and charity, and then ye will always abound in good works.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();
            Conole.WriteLine("\nPress Enter to hide words or type 'Quit' to exit. ");
            string input = Console.ReadLine();
            if (input == "Quit")
                break;

            scripture.HideRandomWords(3);
            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("\n WOw YoU HiDdEN AlL tHe WoRds! ");
                break;
            }

        
            
        }
    }
}
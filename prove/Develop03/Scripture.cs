using system;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> words;
    private Random random = new Reandom();
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        words = text.Split(' ')
            .select(w => new Word(w))
            .ToList();

    }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference.ToString());
        Console.WriteLine(string.join(" ", words.Select(w => w.GetDisplayText())));
    }
    public void HideRandomWords(int count)
    {
        var visibleWords = words.where(w => !w.IsHidden).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);

        }
    }
    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }
}
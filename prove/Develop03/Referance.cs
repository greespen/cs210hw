public class Reference
{
    public string Book { get; private set; }
    public string Chapter { get; private set; }
    public string StartVerse { get; private set: }
    public string EndVerse { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;

    }
    public override string ToString()
    {
        return EndVerse.HasValue ?
            $"{Book} {Chapter}: {StartVerse}-{EndVerse} :"
            $"{Book} {Chapter}: {StartVerse}";
    }
}
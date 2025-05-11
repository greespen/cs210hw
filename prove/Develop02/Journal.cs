using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry); 
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry.Date}: {entry.Prompt} - {entry.Response}"); 
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Prompt,Response");

            foreach (Entry entry in entries)
            {
                string safeDate = EscapeForCsv(entry.Date);
                string safePrompt = EscapeForCsv(entry.Prompt);
                string safeResponse = EscapeForCsv(entry.Response);
                writer.WriteLine($"{safeDate},{safePrompt},{safeResponse}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] fields = ParseCsvLine(line);

                if (fields.Length == 3)
                {
                    string date = fields[0];
                    string prompt = fields[1];
                    string response = fields[2];
                    entries.Add(new Entry(date, prompt, response));
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    private string EscapeForCsv(string field)
    {
        if (field.Contains("\"") || field.Contains(",") || field.Contains("\n")) 
        {
            field = field.Replace("\"", "\"\"");
            return $"\"{field}\"";
        }
        return field;
    }

    private string[] ParseCsvLine(string line)
    {
        List<string> result = new List<string>();
        bool inQuotes = false;
        string current = "";

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (inQuotes)
            {
                if (c == '"')
                {
                    if (i + 1 < line.Length && line[i + 1] == '"') 
                    {
                        current += '"';
                        i++;
                    }
                    else
                    {
                        inQuotes = false;
                    }
                }
                else
                {
                    current += c;
                }
            }
            else
            {
                if (c == ',')
                {
                    result.Add(current);
                    current = "";
                }
                else if (c == '"')
                {
                    inQuotes = true;
                }
                else
                {
                    current += c;
                }
            }
        }

        result.Add(current);
        return result.ToArray();
    }
}
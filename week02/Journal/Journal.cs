using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    public PromptGenerator _promptGen = new PromptGenerator();

    public void Write(Entry newEntry)
    {
        Console.WriteLine("Enter the date: ");
        newEntry.Date = Console.ReadLine();

        newEntry.Prompt = _promptGen.GetPrompt();
        Console.WriteLine($"{newEntry.Prompt}");
        newEntry.Content = Console.ReadLine();

        _entryList.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entryList)
        {
            entry.Display();
        }
    }

    public void Save(string fileName)
    {
        List<string> jsonEntries = new List<string>();
        foreach (Entry entry in _entryList)
        {
            string jsonEntry = JsonSerializer.Serialize(entry);
            jsonEntries.Add(jsonEntry);
        }

        string jsonString = JsonSerializer.Serialize(jsonEntries);
        File.WriteAllText($"{fileName}.json", jsonString);
    }

    public void Load(string fileName)
    {
        string jsonString = File.ReadAllText($"{fileName}.json");
        List<string> jsonEntries = new List<string>();
        jsonEntries = JsonSerializer.Deserialize<List<string>>(jsonString);

        _entryList.Clear();

        foreach (string jsonEntry in jsonEntries)
        {
            Entry newEntry = JsonSerializer.Deserialize<Entry>(jsonEntry);
            _entryList.Add(newEntry);
        }
    }
}

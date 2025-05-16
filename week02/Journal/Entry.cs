public class Entry
{
    public string Content { get; set; }
    public string Date { get; set; }
    public string Prompt { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Date}\nPrompt: {Prompt}\n{Content}\n");   
    }
}
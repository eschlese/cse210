public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What were three blessings I saw in my life today?", "Who was I able to serve today? If no one, who could I serve and why?"};
    public Random random = new Random();

    public string GetPrompt()
    {
        int randomNumber = random.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
}
using Microsoft.VisualBasic;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartMsg();
        Console.WriteLine();
        SetDuration();
        Console.Clear();

        DisplayPrompt();
        Console.WriteLine("\nPonder on the following questions that relate to this experience.");
        Console.WriteLine("Get ready...\n");
        DisplaySpinner(5);

        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(_duration);

        while (current < future)
        {
            DisplayQuestion();
            Console.WriteLine();
            DisplaySpinner(6);

            current = DateTime.Now;
        }

        Console.Clear();
        DisplayEndMsg();
    }

    public string GetRanPrompt()
    {
        Random ran = new Random();

        return _prompts[ran.Next(_prompts.Count)];
    }

    public string GetRanQuestion()
    {
        Random ran = new Random();

        return _questions[ran.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRanPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRanQuestion());
    }
}
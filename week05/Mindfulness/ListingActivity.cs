class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartMsg();
        Console.WriteLine();
        SetDuration();
        Console.Clear();

        DisplayPrompt();
        Console.WriteLine("Get ready to list items. You may start in: ");
        DisplayCountDown(5);

        GetUserList();

        Console.WriteLine($"You entered {_count} items!");
        DisplaySpinner(6);

        Console.Clear();
        DisplayEndMsg();
    }

    public string GetRanPrompt()
    {
        Random ran = new Random();

        return _prompts[ran.Next(_prompts.Count)];
    }
    
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRanPrompt());
    }

    public List<string> GetUserList()
    {
        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(_duration);
        string response = "";
        List<string> responses = new List<string>();

        while (current < future)
        {
            Console.WriteLine();
            response = Console.ReadLine();
            responses.Add(response);

            current = DateTime.Now;
        }

        _count = responses.Count;

        return responses;
    }
}
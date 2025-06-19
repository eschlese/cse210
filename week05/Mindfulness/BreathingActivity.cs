class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartMsg();
        Console.WriteLine();
        SetDuration();
        Console.Clear();

        Console.WriteLine("Get ready...\n");
        DisplaySpinner(5);

        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(_duration);

        while (current < future)
        {
            Console.WriteLine("\nBreathe in...");
            DisplayCountDown(6);
            Console.WriteLine("Breathe out...");
            DisplayCountDown(6);

            current = DateTime.Now;
        }

        Console.Clear();
        DisplayEndMsg();
    }
}
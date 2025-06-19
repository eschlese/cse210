using System.Globalization;
using System.Runtime.Versioning;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartMsg()
    {
        Console.WriteLine($"Welcome to the {_name}!\n\n{_description}");
    }

    public void DisplayEndMsg()
    {
        Console.WriteLine("Well done!\n");
        DisplaySpinner(4);
        Console.WriteLine($"You've successfully completed {_duration} seconds of the {_name}!\n");
        DisplaySpinner(4);
    }

    public void DisplaySpinner(int seconds)
    {
        List<string> frames = new List<string> { "-", "/", "|", "\\" };
        Animate(frames, seconds);
    }

    public void DisplayCountDown(int seconds)
    {
        List<string> frames = new List<string>();
        int count = 1;
        while (count <= seconds)
        {
            frames.Insert(0, count.ToString());
            count++;
        }

        Animate(frames, seconds, 1000);

    }

    private void Animate(List<string> frames, int length, int framerate = 500)
    {
        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(length);
        int frame = 0;

        while (current < future)
        {
            Console.Write(frames[frame]);
            Thread.Sleep(framerate);
            Console.Write("\b \b");
            frame++;

            if (frame >= frames.Count)
            {
                frame = 0;
            }
        }
    }

    public void SetDuration()
    {
        Console.WriteLine("How long (in seconds) would you like to do this activity? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }
}
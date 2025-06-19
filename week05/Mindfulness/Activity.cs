class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartMsg()
    {
        Console.WriteLine("Get Ready!");
    }

    public void DisplayEndMsg()
    {
        Console.WriteLine("You did it!");
    }

    public void DisplaySpinner(int seconds)
    {

    }

    public void DisplayCountDown(int seconds)
    {
        
    }
}
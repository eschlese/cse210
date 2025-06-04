using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a scripture: ");
        string scriptureStr = Console.ReadLine();
        Console.WriteLine("Please enter the book name: ");
        string book = Console.ReadLine();
        Console.WriteLine("Please enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the verse number. If multiple, seperate with hyphen ('4-9'): ");
        string verse = Console.ReadLine();

        Reference reference = new Reference(book, chapter, verse);
        Scripture scripture = new Scripture(reference, scriptureStr);

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplay());
            Console.WriteLine(scripture.GetDisplay());
            Console.WriteLine("\nPress enter to continue. Enter q to quit: ");

            string input = Console.ReadLine().ToLower();

            if (input.Equals("q") | scripture.IsAllHidden())
            {
                running = false;
            }
            else
            {
                scripture.HideWord();
                scripture.HideWord();
            }

        }
    }
}
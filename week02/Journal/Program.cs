using System;

class Program
{
    static void Main(string[] args)
    {
        //For exceeding expectations, this program saves and loads JSON files, and uses the JsonSerializer. 
        Journal journal = new Journal();
        string input = "";

        while (input != "5")
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("Enter: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Entry newEntry = new Entry();
                journal.Write(newEntry);
            }

            else if (input == "2")
            {
                journal.DisplayAll();
            }

            else if (input == "3")
            {
                Console.WriteLine("Enter filename (do not include file extension): ");
                string fileName = Console.ReadLine();
                journal.Load(fileName);
            }

            else if (input == "4")
            {
                Console.WriteLine("Enter filename (do not include file extension): ");
                string fileName = Console.ReadLine();
                journal.Save(fileName);
            }

            else if (input != "5")
            {
                Console.WriteLine("Sorry, I don't understand.");
            }
        }
    }
}
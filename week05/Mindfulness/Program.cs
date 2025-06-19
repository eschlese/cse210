using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathe = new BreathingActivity();
                breathe.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }
            else if (choice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == 4)
            {
                running = false;
            }

            Console.Clear();
        }
    }
}
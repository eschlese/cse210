using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the student's grade? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! The student has passed.");
        }
        else
        {
            Console.WriteLine("The student has failed, but there is always next time!");
        }

        string sign = "";
        if (grade >= 97 || grade < 60)
        {
            sign = "";
        }
        else if (grade % 10 >= 7)
        {
            sign = "+";
        }
        else if (grade % 10 <= 3)
        {
            sign = "-";
        }

        Console.WriteLine($"The student's letter grade is {letter}{sign}.");
        
    }
}
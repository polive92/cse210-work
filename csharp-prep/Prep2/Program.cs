using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";

        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)

        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your current grade is: {grade}");

        if (percent >= 70)
        {
            Console.WriteLine("YOU PASSED!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Maybe next time!");
        }
    }
}
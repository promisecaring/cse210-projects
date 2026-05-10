using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the grade sign (+ or -)
        string sign = "";
        int lastDigit = percentage % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            // A can only be A or A-
            if (lastDigit < 3 && percentage < 100)
            {
                sign = "-";
            }
        }

        // Display the final grade
        Console.WriteLine($"Your grade is {letter}{sign}");

        // Determine pass/fail status
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard and you'll do better next time.");
        }
    }
}
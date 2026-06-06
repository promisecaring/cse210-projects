using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "Who are your heroes?"
    };

    Random rand = new Random();

    public ListingActivity()
        : base(
            "Listing Activity",
            "List as many positive things as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\n{prompt}");

        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("\nStart listing:");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");

        DisplayEndingMessage();
    }
}
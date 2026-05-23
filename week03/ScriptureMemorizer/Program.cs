using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text =
            "Trust in thy Lord with all your heart and lean not on your own understanding";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllHidden())
                break;

            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        scripture.Display();
    }
}

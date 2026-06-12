using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(
                new ChecklistGoal(
                    name,
                    desc,
                    points,
                    target,
                    bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();

        Console.Write("Select Goal: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[choice].RecordEvent();

        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}
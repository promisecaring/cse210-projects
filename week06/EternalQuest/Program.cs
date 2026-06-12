// To exceeded requirements:
// I dded a leveling system.
// A user gains a new level for every 1000 points earned.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();

            manager.DisplayPlayerInfo();

            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.CreateGoal();
                    break;

                case 2:
                    manager.ListGoalDetails();
                    break;

                case 3:
                    manager.SaveGoals();
                    break;

                case 4:
                    manager.LoadGoals();
                    break;

                case 5:
                    manager.RecordEvent();
                    break;
            }

            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new();
        manager.LoadGoals();

        string input = "";
        while (input != "6")
        {
            Console.WriteLine("\\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoals(); break;
                case "3": manager.RecordEvent(); break;
                case "4": manager.DisplayScore(); break;
                case "5": manager.SaveGoals(); break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void CreateGoal()
    {
        
    }

    public void ListGoals()
    {

    }

    public void RecordEvent()
    {

    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current score: {_score}");
    }

    public void SaveGoals()
    {
        using StreamWriter sw = new("goals.txt");
        sw.WriteLine(_score);
        foreach (var g in _goals)
            sw.WriteLine(g.Serialize());
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
            _goals.Add(Goal.Deserialize(lines[i]));
    }
}

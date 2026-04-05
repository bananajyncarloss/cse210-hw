using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordGoal(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;
        Console.WriteLine($"You earned {points} points!");
    }

    public void ShowScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
    public void Save(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
                sw.WriteLine(g.GetSaveString());
        }
    }

    public void ShowLevel()
    {
        int level = _score / 1000;
        Console.WriteLine($"Level: {level}");
    }
    public void Load(string file)
    {
        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "Simple")
                _goals.Add(new SimpleGoal(parts[1], "", int.Parse(parts[2]),
                    bool.Parse(parts[3])));

            else if (parts[0] == "Eternal")
                _goals.Add(new EternalGoal(parts[1], "", int.Parse(parts[2])));

            else if (parts[0] == "Checklist")
                _goals.Add(new ChecklistGoal(parts[1], "", int.Parse(parts[2]),
                    int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));


        }
    }
}
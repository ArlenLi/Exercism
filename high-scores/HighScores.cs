using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scores;
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {
        return scores.Last();
    }

    public int PersonalBest()
    {
        return scores.Max();
    }

    public List<int> PersonalTopThree()
    {
        scores.Sort((a, b) => b.CompareTo(a));
        return scores.Take(3).ToList();
    }
}
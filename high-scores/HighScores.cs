using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> scores;
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return scores.Select(i => i).ToList();
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
        var descendingScores = scores.OrderByDescending(s => s);
        return descendingScores.Take(3).ToList();
    }
}
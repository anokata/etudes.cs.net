using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _highschores;

    public HighScores(List<int> list)
    {
        _highschores = list;
    }

    public List<int> Scores() =>_highschores;

    public int Latest() => _highschores.Last();

    public int PersonalBest() => _highschores.Max();

    public List<int> PersonalTopThree() => _highschores.OrderByDescending(x => x).Take(3).ToList();
}
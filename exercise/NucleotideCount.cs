using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var nucleotides = new Dictionary<char, int> {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach (var group in sequence.ToCharArray().GroupBy(c => c).Select(g => new {key = g.Key, count = g.Count()}))
        {
            if (!("ACGT".Contains(group.key))) throw new ArgumentException("Invalide nucleotide");
            nucleotides[group.key] = group.count;
        }
        return nucleotides;
    }
}
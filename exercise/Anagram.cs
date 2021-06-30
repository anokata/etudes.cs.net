using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{

    private string word;

    public Anagram(string baseWord)
    {
        word = baseWord;
    }

    public bool isAnagram(string a, string b)
        => (a.ToLower() == b.ToLower()) ? false : dictEqual(countChars(a), countChars(b));

    private Dictionary<char, int> countChars(string a)
    => a.ToLower().ToCharArray()
            .GroupBy(c => c)
            .Select(g => new {key = g.Key, count = g.Count()})
            .ToDictionary(g => g.key, g => g.count);

    private bool dictEqual<K, V>(Dictionary<K, V> adic, Dictionary<K, V> bdic)
    => adic.Count == bdic.Count && !adic.Except(bdic).Any();

    public string[] FindAnagrams(string[] potentialMatches)
        => potentialMatches.Where(s => isAnagram(word, s)).ToArray<string>();
}
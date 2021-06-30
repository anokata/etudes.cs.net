using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string acronim = "";
        phrase = phrase.Replace('-', ' ');
        Regex rgx = new Regex("[^a-zA-Z ]");
        phrase = rgx.Replace(phrase, "");
        foreach (string word in phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries)) 
        {
            acronim += word.ToUpper()[0];
        }
        return acronim;
    }
}
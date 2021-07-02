using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        bool []letters = new bool[26];
        foreach (char letter in word.ToLower())
        {
            if (Char.IsLetter(letter)) 
            {
                if (letters[letter - 'a']) return false;
                letters[letter - 'a'] = true;
            }
        }
        return true;
    }
}

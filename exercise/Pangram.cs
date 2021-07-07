using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (input.Length < 26) return false;
        bool[] lettersFlags = FlaggifyLetters(input.ToLower());

        foreach (bool flag in lettersFlags) {
            if (!flag) return false;
        }

        return true;
    }

    private static bool[] FlaggifyLetters(string input) {
        bool[] lettersFlags = new bool[26];
        foreach (char letter in input) {
            if (Char.IsLetter(letter))
                lettersFlags[letter - 'a'] = true;
        }
        return lettersFlags;
    }
}

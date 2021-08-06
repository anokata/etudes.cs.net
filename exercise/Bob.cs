using System;
using System.Collections.Generic;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if (String.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        if (IsQuestion(statement) && IsgibberishShouting(statement))
            return "Calm down, I know what I'm doing!";
        if (IsBang(statement) || IsgibberishShouting(statement))
            return "Whoa, chill out!";
        if (IsQuestion(statement))
            return "Sure.";
        return "Whatever.";
    }

    private static bool IsQuestion(string s)
    {
        return s.EndsWith('?');
    }

    private static bool IsBang(string s)
    {
        return s.EndsWith('!') && s.IndexOf("Hi") < 0;
    }

    private static bool IsgibberishShouting(string s)
    {
        return s.Any(Char.IsUpper) && !(s.Any(Char.IsLower));
    }
}
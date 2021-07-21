using System;
using System.Collections.Generic;
using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        return String.Join("", text.ToCharArray().Select(c => shiftChar(c, shiftKey)));
    }

    private static char shiftChar(char c, int key)
    {
        if (Char.IsLower(c))
            return (char)('a' + (c - 'a' + key) % 26);
        if (Char.IsUpper(c))
            return (char)('A' + (c - 'A' + key) % 26);
        return c;
    }
}
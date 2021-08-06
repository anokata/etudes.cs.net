using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
        => new String(input.Reverse().ToArray());
}
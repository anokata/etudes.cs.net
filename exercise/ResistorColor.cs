using System;

enum ColorCodes 
{
    black = 0,
    brown,
    red,
    orange,
    yellow,
    green,
    blue,
    violet,
    grey,
    white,
}

public static class ResistorColor
{
    public static int ColorCode(string color) => (int) Enum.Parse(typeof(ColorCodes), color.ToLower());

    public static string[] Colors() => Enum.GetNames(typeof(ColorCodes));
}
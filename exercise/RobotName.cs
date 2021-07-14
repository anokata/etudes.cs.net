using System;
using System.Collections.Generic;

public class Robot
{
    private string name = String.Empty;
    private static HashSet<string> names = new HashSet<string>();
    private const string NAMECHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private Random rand;

    public Robot()
    {
        rand = new Random();
        newName();
    }
    
    private char generateRandomChar() => NAMECHARS[rand.Next(0, NAMECHARS.Length)];
    private string generateThreeNumberStr() => String.Format("{0:000}", rand.Next(1000));

    private void newName()
    {

        string newname;
        do {
            newname = $"{generateRandomChar()}{generateRandomChar()}{generateThreeNumberStr()}";
        } while (names.Contains(newname));

        name = newname;
        names.Add(name);
    }

    public string Name
    {
        get => name;
    }

    public void Reset()
    {
        newName();
    }
}
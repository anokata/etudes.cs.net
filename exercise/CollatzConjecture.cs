using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();
        int steps = 0;
        while (number != 1)
        {
            number = MakeStep(number);
            steps++;
        }
        return steps;
    }

    private static int MakeStep(int number) 
    {
        if (number % 2 == 0) return number / 2;
        return number * 3 + 1;
    }
}
using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();
        if (number == 1) return Classification.Deficient;
        int maxDivisor = (int)(number / 2);
        int divisorsSum = 1;  // All dived by 1;
        for (int divisor = 2; divisor <= maxDivisor; divisor++)
        {
            if (number % divisor == 0)
            {
                divisorsSum += divisor;
            }
            if (divisorsSum > number) return Classification.Abundant;
        }
        if (divisorsSum == number) return Classification.Perfect;
        return Classification.Deficient;
    }
}

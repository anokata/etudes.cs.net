using System;
using System.Linq;
using System.Collections.Generic;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        // Using collections
        return (int) Math.Pow(Enumerable.Range(1, max).Sum(), 2);
        // Using Math and brain
        //return (int) Math.Pow(((max+1)*max)/2, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        // Using collections
        return Enumerable.Range(1, max).Select(x => x* x).Sum();
        // Using Math and brain
        //return ((2*max+1)*(max+1)*max)/6;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
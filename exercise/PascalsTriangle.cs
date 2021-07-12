using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        int[][] triangle = new int[rows][];
        for (int r = 0; r < rows; r++)
        {
            triangle[r] = new int[r+1];
            for (int c = 0; c < r+1; c++)
            {
                triangle[r][c] = (int) binominal(r, c);
            }
        }
        return triangle;
    }

    public static long binominal(int n, int k) => factorial(n)/(factorial(k)*factorial(n-k));

    public static long factorial(int n)
    {
        long f = 1;
        if (n < 2) return f;
        for (int i = 2; i <= n; i++) f *= i;
        return f;
    }

}
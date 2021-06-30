using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distanceToCenter = Math.Sqrt(x*x + y*y);
        if (distanceToCenter > 10) return 0;
        if (distanceToCenter > 5) return 1;
        if (distanceToCenter > 1) return 5;
        return 10;
    }
}

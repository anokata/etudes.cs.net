using System;

public static class Triangle
{

    public static bool IsCorrectTriangle(double side1, double side2, double side3)
    {
        if (side1 <= 0) return false;
        if (side2 <= 0) return false;
        if (side3 <= 0) return false;
        if (side1 + side2 < side3) return false;
        if (side3 + side2 < side1) return false;
        if (side1 + side3 < side2) return false;
        return true;
    }
    public static bool IsScalene(double side1, double side2, double side3)
    {
        return IsCorrectTriangle(side1, side2, side3) && (side1 != side2 && side2 != side3 && side1 != side3);
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        return IsCorrectTriangle(side1, side2, side3) && (side1 == side2 || side2 == side3 || side1 == side3);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        return IsCorrectTriangle(side1, side2, side3) && side1 == side2 && side2 == side3;
    }
}
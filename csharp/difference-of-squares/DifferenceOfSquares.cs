using System;

public static class Squares
{
    public static int SquareOfSums(int max)
    {
        return (int)Math.Pow((max * (max + 1)) / 2, 2);
    }

    public static int SumOfSquares(int max)
    {
        return (int)(Math.Pow(max, 3) / 3 + Math.Pow(max, 2) / 2 + max / 6.0);
    }

    public static int DifferenceOfSquares(int max)
    {
        return SquareOfSums(max) - SumOfSquares(max);
    }
}
using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        return 1ul << (n-1);
    }

    public static ulong Total()
    {
        return ulong.MaxValue;
    }
}
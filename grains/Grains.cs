using System;

public static class Grains
{
    public static readonly int SizeOfChessBoard = 64;
    public static ulong Square(int n)
    {
        if(n < 1 || n > SizeOfChessBoard)
            throw new ArgumentOutOfRangeException();
        var result = (ulong)Math.Pow(2, (double)(n-1));
        return result;
    }

    public static ulong Total()
    {
        ulong total = 0;
        for(int i = 1; i <= SizeOfChessBoard; i ++) {
            total += Square(i);
        }
        return total;
    }
}
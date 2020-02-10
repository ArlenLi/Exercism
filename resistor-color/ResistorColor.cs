using System;

public static class ResistorColor
{
    public static string[] ColorBand = Colors();
    public static int ColorCode(string color)
    {
        for(int i = 0; i < ColorBand.Length; i++) {
            if(ColorBand[i] == color.ToLowerInvariant()) 
                return i;
        }
        return -1;
    }

    public static string[] Colors()
    {
        return new String[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    }
}
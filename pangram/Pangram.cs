using System.Linq;

public static class Pangram
{
    private const string alphabetsInLowercase = "abcdefghijklmnopqrstuvwxzy";

    public static bool IsPangram(string text) {
        return alphabetsInLowercase.All(text.ToLowerInvariant().Contains);
    }
}

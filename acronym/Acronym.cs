using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Linq;
using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var rx = new Regex(@"[A-Za-z0-9_']+", RegexOptions.None);
        var matches = rx.Matches(phrase);
        var result = "";
        foreach(Match word in matches)
            result += GetFirstUppercaseAlphanumber(word.Value);
        return result;
    }

    private static string GetFirstUppercaseAlphanumber(string word) {
        foreach(var c in word) {
            if(c != '_' && c != '\'')
                return c.ToString().ToUpperInvariant();
        }
        return "";
    }
}
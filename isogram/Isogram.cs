using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var wordList = word.ToLowerInvariant().ToList();
        wordList.RemoveAll(c => c == ' '|| c== '-');
        return wordList.Distinct().Count() == wordList.Count();
    }
}

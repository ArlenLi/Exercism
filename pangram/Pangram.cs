using System.Linq;
using System.Collections.Generic;
using System;

public static class Pangram
{
    private static List<int> AllLowerCaseAlphabets;
    public static bool IsPangram(string input)
    {
        AllLowerCaseAlphabets = CreateAListOfAllLowercaseAlphabets();
        var list = CreateAListOfAllLowercaseAlphabets();
        foreach(char c in input) {
            RemoveCorrespondingLowercaseAlphabeFromList(c);
            if(!AllLowerCaseAlphabets.Any()) 
                return true;
        }
        return false;
    }

    private static List<int> CreateAListOfAllLowercaseAlphabets() {
        var list = new List<int>();
        for(int i = 97; i <= 122; i++) {
            list.Add(i);
        }
        return list;
    }

    private static void RemoveCorrespondingLowercaseAlphabeFromList(char c) {
        if(WhetherLetterIsAlphabet(c)) {
            AllLowerCaseAlphabets.Remove((int)Char.ToLower(c));
        }
    }

    private static bool WhetherLetterIsAlphabet(char c) {
        return ((int)c >=  65 && (int)c <= 122) ? true : false;
    }
}

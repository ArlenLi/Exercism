using System.Linq;
using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        // if(!sequence.Distinct().All(s => "ACGT".Contains(s))) {
        //     throw new ArgumentException();
        // }

        if(sequence.Except("ACGT").Any()) {
            throw new ArgumentException();
        }
        var nucleotideCountDic = new Dictionary<char, int> {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach(var character in sequence) {

            nucleotideCountDic[character] = ++nucleotideCountDic[character];
        }
        return nucleotideCountDic;
    }
}
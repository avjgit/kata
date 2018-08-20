using System;
using System.Collections.Generic;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        bool IsSeparator(char x) => char.IsPunctuation(x) || char.IsSeparator(x) || char.IsWhiteSpace(x);
        string uniformlySeparatedString = phrase.Replace()
        string [] words = phrase.Split(' ')
    }
}
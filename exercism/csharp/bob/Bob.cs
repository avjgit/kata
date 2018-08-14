using System;
using System.Collections.Generic;
using System.Linq;

public static class Bob
{
    private enum Meaning
    {
        Question,
        Yelling,
        QuestionYelling,
        Uninformative,
        Other
    }

    private static readonly Dictionary<Meaning, string> bobsCommunication = new Dictionary<Meaning, string>()
    {
        {Meaning.Question,  "Sure."},
        {Meaning.Yelling,  "Whoa, chill out!"},
        {Meaning.QuestionYelling,  "Calm down, I know what I'm doing!"},
        {Meaning.Uninformative,  "Fine. Be that way!"},
        {Meaning.Other, "Whatever."}
    };

    private static bool IsUninformative(string statement)
    {
        return String.IsNullOrWhiteSpace(statement);
    }

    private static bool IsQuestion(string statement)
    {
        return statement.TrimEnd().EndsWith("?");
    }

    private static bool IsYelling(string statement)
    {
        var letters = statement.Where(char.IsLetter).ToList();
        return letters.Any() && letters.All(char.IsUpper);
    }

    private static Meaning IdentifyMeaning(string statement)
    {
        if (IsUninformative(statement))
            return Meaning.Uninformative;

        if (IsQuestion(statement) && IsYelling(statement))
            return Meaning.QuestionYelling;

        if (IsYelling(statement))
            return Meaning.Yelling;

        if (IsQuestion(statement))
            return Meaning.Question;

        return Meaning.Other;
    }


    public static string Response(string statement)
    {
        return bobsCommunication[IdentifyMeaning(statement)];
    }
}
using System.Collections.Generic;

public static class BracketPush
{
    private static bool IsOpening(this char c) =>
        new List<char> { '[', '{', '(' }.Contains(c);

    private static bool IsClosing(this char c) =>
        new List<char> { ']', '}', ')' }.Contains(c);

    private static bool Matches(this char c, char x) =>
        new Dictionary<char, char>
        {
            { '[', ']' },
            { '{', '}' },
            { '(', ')' }
        }[x] == c;

    public static bool IsPaired(string input)
    {
        var braces = new Stack<char>();
        foreach (var c in input)
        {
            if (c.IsOpening())
            {
                braces.Push(c);
            }
            if (c.IsClosing())
            {
                if (braces.Count == 0) return false;
                var previous = braces.Pop();
                if (!c.Matches(previous)) return false;
            }
        }
        return braces.Count == 0;
    }
}

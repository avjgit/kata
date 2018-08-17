using System;
using System.Collections.Generic;

public static class TwelveDays
{
    private static string Amount(this int i)
    {
        switch (i)
        {
            case 1: return "a";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            default: return i.ToString();
        }
    }
    
    private static string Order(this int i)
    {
        switch (i)
        {
            case 1: return "first";
            case 2: return "second";
            case 3: return "third";
            case 4: return "fourth";
            case 5: return "fifth";
            case 6: return "sixth";
            case 7: return "seventh";
            case 8: return "eighth";
            case 9: return "ninth";
            case 10: return "tenth";
            case 11: return "eleventh";
            case 12: return "twelfth";
            default: return i.ToString();
        }
    }

    public class ChristmasDay
    {
        private Dictionary<int, string> GiftForDay = new Dictionary<int, string>()
        {
            {1, "Partridge in a Pear Tree"},
            {2, "Turtle Doves"},
            {3, "French Hens"},
            {4, "Calling Birds"},
            {5, "Gold Rings"},
            {6, "Geese-a-Laying"},
            {7, "Swans-a-Swimming"},
            {8, "Maids-a-Milking"},
            {9, "Ladies Dancing"},
            {10, "Lords-a-Leaping"},
            {11, "Pipers Piping"},
            {12, "Drummers Drumming"}
        };
        private readonly int day;

        public ChristmasDay(int day)
        {
            this.day = day;
        }
        
        private string Gifts()
        {
            string firstDayPrefix(int _i, int _day) => _i == 1 && _day > 1 ? "and " : "";

            var gifts = new List<string>();
            for (int i = day; i >= 1; i--)
            {
                gifts.Add($"{firstDayPrefix(i, day)}{i.Amount()} {GiftForDay[i]}");
            }
            return String.Join(", ", gifts);
        }

        public override string ToString()
        {
            return $"On the {day.Order()} day of Christmas my true love gave to me, {Gifts()}.";
        }
    }


    public static string Recite(int verseNumber)
    {
        return new ChristmasDay(verseNumber).ToString();
    }

    public static string Recite(int startVerse, int endVerse)
    {
        var verses = new List<string>();
        for (int i = startVerse; i <= endVerse; i++)
        {
            verses.Add(Recite(i));
        }
        return string.Join("\n", verses);
    }
}
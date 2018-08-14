using System;

public static class TwelveDays
{
    // my own little https://github.com/Humanizr/Humanizer :)
    public class Number
    {
        public int Value { get; set; }

        public Number(int value)
        {
            Value = value;
        }

        public string Amount
        {
            get
            {
                switch (Value)
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
                    case 12: return "tvelve";
                    default: return base.ToString();
                }
            }
        }

        public string Order
        {
            get
            {

                switch (Value)
                {
                    case 1: return "first";
                    case 2: return "second";
                    case 3: return "third";
                    case 4: return "fourth";
                    case 5: return "fivth";
                    case 6: return "sixth";
                    case 7: return "seventh";
                    case 8: return "eighth";
                    case 9: return "ninth";
                    case 10: return "tenth";
                    case 11: return "eleventh";
                    case 12: return "tvelfth";
                    default: return base.ToString();
                }
            }
        }
    }

    public class ChristmasDay
    {
        private Number day;

        private string Gift
        {
            get
            {
                switch (day.Value)
                {
                    case 01: return "Partridge in a Pear Tree";
                    case 02: return "Turtle Doves";
                    case 03: return "French Hens";
                    case 04: return "Calling Birds";
                    case 05: return "Gold Rings";
                    case 06: return "Geese-a-Laying";
                    case 07: return "Swans-a-Swimming";
                    case 08: return "Maids-a-Milking";
                    case 09: return "Ladies Dancing";
                    case 10: return "Lords-a-Leaping";
                    case 11: return "Pipers Piping";
                    case 12: return "Drummers Drumming";
                    default: return String.Empty;
                }
            }
        }

        public ChristmasDay(int dayNr)
        {
            day = new Number(dayNr);
        }

        private string DayIntro() => $"On the {day.Order} day of Christmas my true love gave to me, ";
        private string GiftOfTheDay() => $"{day.Amount} {Gift}";
        private string PreviousDaysGifts()

        public override string ToString()
        {
            return $"On the {day.Order} day of Christmas my true love gave to me, {day.Amount} {Gift}.";
        }
    }



    public static string Recite(int verseNumber)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static string Recite(int startVerse, int endVerse)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
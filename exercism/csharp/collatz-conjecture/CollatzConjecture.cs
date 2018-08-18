using System;

public static class CollatzConjecture
{
    static bool IsEven(this int x) => x % 2 == 0;

    public static int Steps(int number)
    {
        if (number < 1) throw new ArgumentException();

        int result = number;
        int stepsCount = 0;

        while (result > 1)
        {
            result = result.IsEven()
                ? result / 2
                : result * 3 + 1;

            stepsCount++;
        }
        return stepsCount;
    }
}
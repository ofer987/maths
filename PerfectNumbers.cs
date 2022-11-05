namespace Maths;

public class PerfectNumbers
{
    public static IEnumerable<int> GetAll(int start, int end)
    {
        if (start < 1)
        {
            throw new ArgumentException("Should be positive", nameof(start));
        }

        if (end < 1)
        {
            throw new ArgumentException("Should be positive", nameof(end));
        }

        if (end < start)
        {
            throw new ArgumentOutOfRangeException(nameof(end), end, $"Should be same or larger than {start}");
        }

        for (var i = start; i <= end; i += 1)
        {
            if (IsPerfect(i))
            {
                yield return i;
            }
        }
    }

    public static bool IsPerfect(int number)
    {
        if (number < 1)
        {
            throw new ArgumentException("Should be positive", nameof(number));
        }

        var sum = GetDividends(number)
            .Sum();

        return sum == number;
    }

    public static IEnumerable<int> GetDividends(int number)
    {
        if (number < 1)
        {
            throw new ArgumentException("Should be positive", nameof(number));
        }

        int endIteration;
        if (number % 2 == 0)
        {
            endIteration = number / 2;
        }
        else
        {
            endIteration = (number - 1) / 2;
        }

        for (var i = 1; i <= endIteration; i += 1)
        {
            if (number % i == 0)
            {
                yield return i;
            }
        }
    }
}

namespace Maths;

public class PrimeNumbers
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
            if (IsPrime(i))
            {
                yield return i;
            }
        }
    }

    public static bool IsPrime(int number)
    {
        if (number < 1)
        {
            throw new ArgumentException("Should be positive", nameof(number));
        }

        if (number < 3)
        {
            return false;
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

        for (var i = 2; i <= endIteration; i += 1)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

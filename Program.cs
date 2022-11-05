namespace Maths;

public class Program
{
    public static int Main(string[] args)
    {
        int start;
        int end;

        if (args.Length == 0)
        {
            return 0;
        }
        else if (args.Length == 1)
        {
            start = int.Parse(args[0]);
            end = int.Parse(args[0]);
        }
        else
        {
            start = int.Parse(args[0]);
            end = int.Parse(args[1]);
        }

        foreach (var prime in PrimeNumbers.GetAll(start, end))
        {
            Console.WriteLine(prime);
        }

        return 0;
    }
}

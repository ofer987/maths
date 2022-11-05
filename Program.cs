namespace Maths;

public enum Operations { PrimeNumbers = 0, PerfectNumbers }

public class Program
{
    public static int Main(string[] args)
    {

        if (args.Length == 0)
        {
            Console.WriteLine("Specify either");
            Console.WriteLine();

            var i = 1;
            foreach (var operation in Enum.GetNames<Operations>())
            {
                Console.WriteLine($"{i}. {operation}");

                i += 1;
            }

            return 0;
        }

        var selectedOperation = Enum.Parse<Operations>(args[0]);

        switch (selectedOperation)
        {
            case Operations.PrimeNumbers:
                PrintPrimeNumbers(args);
                break;
            case Operations.PerfectNumbers:
                PrintPerfectNumbers(args);
                break;
        }

        return 0;
    }

    private static void PrintPrimeNumbers(string[] args)
    {
        int start;
        int end;

        if (args.Length == 2)
        {
            start = int.Parse(args[1]);
            end = int.Parse(args[1]);
        }
        else
        {
            start = int.Parse(args[1]);
            end = int.Parse(args[2]);
        }

        var count = 0;
        var sum = 0;
        foreach (var prime in PrimeNumbers.GetAll(start, end))
        {
            count += 1;
            sum += prime;
            Console.WriteLine(prime);
        }

        Console.WriteLine();
        Console.WriteLine($"The total of the first {count} prime numbers is {sum}");
    }

    private static void PrintPerfectNumbers(string[] args)
    {
        int start;
        int end;

        if (args.Length == 2)
        {
            start = int.Parse(args[1]);
            end = int.Parse(args[1]);
        }
        else
        {
            start = int.Parse(args[1]);
            end = int.Parse(args[2]);
        }

        var count = 0;
        var sum = 0;
        foreach (var perfect in PerfectNumbers.GetAll(start, end))
        {
            count += 1;
            sum += perfect;
            Console.WriteLine(perfect);
        }

        Console.WriteLine();
        Console.WriteLine($"The total of the first {count} perfect numbers is {sum}");
    }
}

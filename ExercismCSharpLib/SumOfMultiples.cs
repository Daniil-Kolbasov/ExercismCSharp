using System.Diagnostics;

namespace ExercismCSharpLib;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) =>
        Enumerable
            .Range(0, max)
            .Where(item => multiples.Any(item2 => (item2 != 0) && item % item2 == 0))
            .Sum();
}

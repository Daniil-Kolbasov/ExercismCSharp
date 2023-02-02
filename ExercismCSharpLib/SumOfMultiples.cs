using System.Diagnostics;

namespace ExercismCSharpLib;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) =>
        multiples
            .SelectMany(multiple => Enumerable.Range(1, max - 1)
            .Where(n => multiple != 0 && n % multiple == 0))
            .Distinct()
            .Sum();
}

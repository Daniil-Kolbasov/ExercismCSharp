using System.Diagnostics;

namespace ExercismCSharpLib;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) =>
        Enumerable.Range(1, max -1).Where(i => IsDivide(multiples, i)).Sum();

    private static bool IsDivide(IEnumerable<int> multiples, int i)
    {
        foreach (int item in multiples)
        {
            if (item == 0)
                return false;
            if (i % item == 0)
                return true;
        }

        return false;
    }
}

namespace ExercismCSharpLib;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        for (int a = 1; a <= sum / 3; a++)
        {
            for (int b = a + 1, c = sum - a - b; b < c; b++, c--)
            {
                if (a * a + b * b == c * c)
                    yield return (a, b, c);
            }
        }
    }

    public static IEnumerable<(int a, int b, int c)> GeometricMethod(int sum)
    {
        int a, b, c;

        for (int m = 2; m < sum; m++)
        {
            for (int n = 1; n < m; n++)
            {
                c = m * m + n * n;
                if (c > sum)
                    break;

                a = 2 * m * n;
                b = m * m - n * n;

                if (a > b)
                    (b, a) = (a, b);

                if (a + b + c == sum)
                    yield return (a, b, c);
            }
        }
    }
}

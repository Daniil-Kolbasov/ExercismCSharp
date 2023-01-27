namespace ExercismCSharpLib;

public static class DifferenceOfSquares
{
    #region 1 iteration
    //public static int CalculateSquareOfSum(int max)
    //{
    //    int result = 0;
    //    for (int i = 1; i <= max; i++)
    //        result += i;
    //    result *= result;
    //    return result;
    //}

    //public static int CalculateSumOfSquares(int max)
    //{
    //    int result = 0;
    //    for (int i = 1; i <= max; i++)
    //        result += i * i;
    //    return result;
    //}

    //public static int CalculateDifferenceOfSquares(int max)
    //{
    //    return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    //}
    #endregion

    #region 2 iteration
    private static int Square(this int i) => i * i;

    public static int CalculateSquareOfSum(int max) => Enumerable.Range(1, max).Sum().Square();

    public static int CalculateSumOfSquares(int max) => Enumerable.Range(1, max).Sum(i => i.Square());

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    #endregion

    #region anderson1se's solution
    //public static int CalculateSquareOfSum(int max)
    //    => (int)Math.Pow((max * (max + 1)) / 2, 2);
    //public static int CalculateSumOfSquares(int max)
    //    => (max * (max + 1) * (2 * max + 1)) / 6;
    //public static int CalculateDifferenceOfSquares(int max)
    //    => Math.Abs(CalculateSumOfSquares(max) - CalculateSquareOfSum(max));
    #endregion
}

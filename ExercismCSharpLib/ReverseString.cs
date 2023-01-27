namespace ExercismCSharpLib;

public class ReverseString
{
    #region Approach: Span<T> (best performance)
    public static string Reverse(string input)
    {
        Span<char> chars = new char[input.Length];
        for (var i = 0; i < input.Length; i++)
        {
            chars[input.Length - 1 - i] = input[i];
        }
        return new string(chars);
    }
    #endregion

    #region Approach: Array.Reverse() (very similar performance to the Span<T>)
    //public static string Reverse(string input)
    //{
    //    char[] charArray = input.ToCharArray();
    //    Array.Reverse(charArray);
    //    return new(charArray);
    //}
    #endregion

    #region Approach: LINQ (slowest and allocates the most memory)
    //public static string Reverse(string input)
    //{
    //    return new string(input.Reverse().ToArray());
    //}

    // Approach: StringBuilder
    //public static string Reverse(string input)
    //{
    //    var chars = new StringBuilder();
    //    for (var i = input.Length - 1; i >= 0; i--)
    //    {
    //        chars.Append(input[i]);
    //    }
    //    return chars.ToString();
    //}
    #endregion

    #region Approach: StringBuilder (slightly better, but still quite a bit slower than the two top-performing approaches)
    //public static string Reverse(string input)
    //{
    //    var chars = new StringBuilder();
    //    for (var i = input.Length - 1; i >= 0; i--)
    //    {
    //        chars.Append(input[i]);
    //    }
    //    return chars.ToString();
    //}
    #endregion
}

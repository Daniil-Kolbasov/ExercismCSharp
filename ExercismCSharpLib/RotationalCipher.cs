using System.Text.RegularExpressions;

namespace ExercismCSharpLib;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey) =>
        Regex.Replace(text, @"[a-zA-Z]", c =>
        {
            char[] charArray = c.ToString().ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                char d = Char.IsUpper(charArray[i]) ? 'A' : 'a';
                charArray[i] = (char)((((charArray[i] + shiftKey) - d) % 26) + d);
            }
            return new(charArray);
        });

    #region Hayashida Katsutoshi's Solution
    //public static string Rotate(string text, int shiftKey)
    //{
    //    char Rotate(char c)
    //    {
    //        if (!char.IsLetter(c))
    //            return c;
    //        int b = char.IsLower(c) ? 'a' : 'A';
    //        return (char)(b + ((c - b + shiftKey) % 26));
    //    }
    //    return new string(text.Select(Rotate).ToArray());
    //}
    #endregion
}

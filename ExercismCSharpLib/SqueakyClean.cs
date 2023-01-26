using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharpLib;

public static class SqueakyClean
{
    public static string Clean(string identifier)
    {
        bool isUpper = false;
        char[] temp = identifier.ToCharArray();

        for (int i = 0; i < temp.Length; i++)
        {
            if (isUpper)
            {
                temp[i] = char.ToUpper(temp[i]);
                isUpper = false;
            }

            if (temp[i] == '-')
                isUpper = true;
        }

        identifier = new(temp);

        return new(identifier
            .Replace(" ", "_")
            .Replace("\0", "CTRL")
            .Where(c => char.IsLetter(c) && !(c >= '\u03B1' && c <= '\u03C9') || c == '_')
            .ToArray());
    }

    #region edgarrunnman's solution

    //public static string Clean(string identifier)
    //{
    //    identifier = Regex.Replace(identifier, @"\s", "_");
    //    identifier = Regex.Replace(identifier, "\\0", "CTRL");
    //    identifier = Regex.Replace(identifier, @"-\D", new MatchEvaluator(ToCamelCase));
    //    return Regex.Replace(identifier, @"[α-ω]|\d|\W", "");
    //}
    //private static string ToCamelCase(Match match) => match.Value[1].ToString().ToUpper();
    #endregion

    #region danieldietrich's solution
    //private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');
    //public static string Clean(string identifier)
    //{
    //    var stringBuilder = new StringBuilder();
    //    var isAfterDash = false;
    //    foreach (var c in identifier)
    //    {
    //        stringBuilder.Append(c switch
    //        {
    //            _ when IsGreekLowercase(c) => default,
    //            _ when isAfterDash => char.ToUpperInvariant(c),
    //            _ when char.IsWhiteSpace(c) => '_',
    //            _ when char.IsControl(c) => "CTRL",
    //            _ when char.IsLetter(c) => c,
    //            _ => default,
    //        });
    //        isAfterDash = c.Equals('-');
    //    }
    //    return stringBuilder.ToString();
    //}
    #endregion
}
using System.Text.RegularExpressions;

namespace ExercismCSharpLib;

public static class Acronym
{
    #region My Code
    public static string Abbreviate(string phrase)
    {
        string result = string.Empty;

        foreach (Match match in Regex.Matches(phrase, @"[A-Za-z']+"))
            result += char.ToUpper(match.Value[0]);

        return result;
    }
    #endregion

    #region bgraf' solution
    //public static string Abbreviate(string phrase) =>
    //Strings.Concat(Regex.Split(phrase, "[^A-Za-z']+")
    //    .Select(s => char.ToUpper(s[0])));
    #endregion

    #region Mirsait's solution
    //public static string Abbreviate(string phrase)
    //{
    //    char[] separators = { ' ', '-', '_' };
    //    var abb = Strings.Join("", phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => x[0]));
    //    return abb.ToUpper();
    //}
    #endregion
}

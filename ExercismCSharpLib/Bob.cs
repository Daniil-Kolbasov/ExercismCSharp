namespace ExercismCSharpLib;

public static class Bob
{
    public static string Response(string statement)
    {
        if (IsNoAppeal(statement))
            return "Fine. Be that way!";

        if (IsShout(statement))
            if (IsQuestion(statement))
                return "Calm down, I know what I'm doing!";
            else
                return "Whoa, chill out!";

        if (IsQuestion(statement))
            return "Sure.";

        return "Whatever.";
    }

    #region bobahop's solution
    //private static readonly string[] answers = { "Whatever.", "Sure.", "Whoa, chill out!", "Calm down, I know what I'm doing!" };

    //// private static bool isShout(string input) => input.Any(c => char.IsLetter(c)) && input.ToUpper() == input;

    //public static string Response(string statement)
    //{
    //    var input = statement.TrimEnd();
    //    if (input == "") return "Fine. Be that way!";
    //    var isShout = input.Any(char.IsLetter) && input.ToUpper() == input ? 2 : 0;
    //    var isQuestion = input.EndsWith('?') ? 1 : 0;
    //    return answers[isShout + isQuestion];
    //    // switch ((input.EndsWith('?'), isShout(input)))
    //    // {
    //    //     case (true, true): return "Calm down, I know what I'm doing!";
    //    //     case (_, true): return "Whoa, chill out!";
    //    //     case (true, _): return "Sure.";
    //    //     default: return "Whatever."; 
    //    // }
    //}
    #endregion

    private static bool IsShout(string statement)
    {
        if (statement.Any(char.IsLetter))
        {
            if (statement.Any(char.IsLower))
                return false;
        }
        else
            return false;

        return true;

        //bool isUppercase = false;
        //foreach (var c in statement)
        //{
        //    if (Char.IsLower(c))
        //        return false;
        //    if (Char.IsLetter(c))
        //        isUppercase = true;
        //}

        //return isUppercase;
    }

    private static bool IsQuestion(string statement)
    {
        if (statement.TrimEnd(' ', '\r', '\n', '\t').EndsWith('?'))
            return true;
        else
            return false;
    }

    private static bool IsNoAppeal(string statement)
    {
        foreach (var c in statement)
            if (char.IsLetter(c) || char.IsDigit(c) || c == '?')
                return false;

        return true;
    }
}
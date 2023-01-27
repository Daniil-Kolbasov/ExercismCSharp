namespace ExercismCSharpLib;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        return str.Substring(str.IndexOf(delimiter) + delimiter.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstDel, string secondDel)
    {
        str = str.Remove(0, str.IndexOf(firstDel) + firstDel.Length);
        str = str.Remove(str.IndexOf(secondDel));
        return str;
    }

    // TODO: define the 'Message()' extension method on the `string` type
    static string[] logLevel = { "INFO", "WARNING", "ERROR" };
    public static string Message(this string str)
    {
        foreach (var item in logLevel)
        {
            if (str.Contains(item))
            {
                str = str.Remove(0, item.Length + 3);
                break;
            }
        }
        return str.Trim(' ', '\r', '\n', '\t');
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        foreach (var item in logLevel)
        {
            if (str.Contains(item))
            {
                str = item;
                break;
            }
        }
        return str.Trim(' ', '\r', '\n', '\t');
    }
}

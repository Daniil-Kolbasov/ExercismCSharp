namespace ExercismCSharpLib;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        List<char> letters = new();
        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                if (letters.Contains(char.ToLower(c)))
                    return false;
                else
                    letters.Add(char.ToLower(c));
            }
        }

        return true;
    }
}

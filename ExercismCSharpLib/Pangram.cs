namespace ExercismCSharpLib;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        return bitFieldAproach(input);
    }

    private static bool myAproach(string input)
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        foreach (char c in alphabet)
        {
            if (!input.Contains(c, StringComparison.CurrentCultureIgnoreCase)) return false;
        }
        return true;
    }

    private static bool bitFieldAproach(string input)
    {
        int phrasemask = 0;
        foreach (char letter in input)
        {
            // a-z
            if (letter > 96 && letter < 123)
                phrasemask |= 1 << letter - 'a';
            // A - Z
            else if (letter > 64 && letter < 91)
                phrasemask |= 1 << letter - 'A';
        }
        //26 binary 1s
        return phrasemask == 67108863;
    }

    private static bool lowercasedAproach(string input)
    {
        const string Letters = "abcdefghijklmnopqrstuvwxyz";
        var lowerCaseInput = input.ToLower();
        return Letters.All(letter => lowerCaseInput.Contains(letter));
    }

    private static bool caseInsensitiveComparisonAproach(string input)
    {
        return "abcdefghijklmnopqrstuvwxyz".All(c => input.Contains(c, StringComparison.CurrentCultureIgnoreCase));
    }
}

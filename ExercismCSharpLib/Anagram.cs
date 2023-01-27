namespace ExercismCSharpLib;

public class Anagram
{
    #region My code
    private readonly string _baseWord;
    public Anagram(string baseWord)
    {
        _baseWord = baseWord.ToLower();
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> anagramList = new();
        string baseSet = string.Concat(_baseWord.OrderBy(c => c));

        foreach (string word in potentialMatches)
        {
            if (_baseWord != word.ToLower())
            {
                string wordSet = string.Concat(word.ToLower().OrderBy(c => c));

                if (baseSet == wordSet)
                    anagramList.Add(word);
            }
        }

        return anagramList.ToArray();
    }
    #endregion

    #region mstange22's solution
    //private readonly string baseWord;

    //public Anagram(string baseWord)
    //{
    //    this.baseWord = baseWord.ToLower();
    //}

    //public string[] FindAnagrams(string[] potentialMatches) =>
    //    potentialMatches
    //        .Where(s => isAnagram(s.ToLower()))
    //        .ToArray();

    //private bool isAnagram(string candidate) =>
    //    candidate == baseWord ? false : (
    //        string.Concat(candidate.OrderBy(c => c)) == string.Concat(baseWord.OrderBy(c => c))
    //    );
    #endregion
}

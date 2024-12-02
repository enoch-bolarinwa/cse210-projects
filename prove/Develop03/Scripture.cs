public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(word => new Word(word))
                     .ToList();
    }

    public bool HideRandomWords(int count)
    {
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();

        if (!visibleWords.Any())
            return false;

        var random = new Random();
        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }

        return true;
    }

    public override string ToString()
    {
        string scriptureText = string.Join(' ', _words);
        return $"{_reference}\n{scriptureText}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideRandomWords(int numberToHide)
    {
        // Get indices of all visible words
        var visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }

        // If no visible words remain, return
        if (visibleIndices.Count == 0) return;

        // Determine how many words to hide
        int wordsToHide = Math.Min(numberToHide, visibleIndices.Count);

        // Randomly select and hide words
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = _random.Next(visibleIndices.Count);
            _words[visibleIndices[randomIndex]].Hide();
            visibleIndices.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string wordText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
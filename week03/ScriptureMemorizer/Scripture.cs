class Scripture
{
    private Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count = 2)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        var random = new Random();
        for (int i = 0; i < Math.Min(count, visibleWords.Count); i++)
        {
            visibleWords[random.Next(visibleWords.Count)].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{Reference}\n" + string.Join(" ", Words);
    }

    public bool IsFullyHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}
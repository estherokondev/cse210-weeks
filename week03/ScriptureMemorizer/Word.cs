class Word
{
    private string Original { get; }
    public bool IsHidden { get; private set; } = false;

    public Word(string original)
    {
        Original = original;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Original.Length) : Original;
    }
}
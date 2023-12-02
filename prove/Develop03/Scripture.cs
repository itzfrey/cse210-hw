public class Scripture 
{
    private Reference _reference;

    private List<Word> _words;

    private Random _random = new Random();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsToHide = Math.Min(numberToHide, _words.Count);
        List<int> indicesToHide = Enumerable.Range(0, _words.Count).OrderBy(x => Guid.NewGuid()).Take(wordsToHide).ToList();

        foreach ( int index in indicesToHide)
        {
            _words[index].Hide();
        } 
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
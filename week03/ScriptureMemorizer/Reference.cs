public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, string verse)
    {
        _book = book;
        _chapter = chapter;

        if (verse.Contains('-'))
        {
            int hyphenIndex = verse.IndexOf('-');
            int firstVerse = int.Parse(verse.Substring(0, hyphenIndex));
            int lastVerse = int.Parse(verse.Substring(hyphenIndex + 1));

            _verse = firstVerse;
            _endVerse = lastVerse;
        }
        else
        {
            _verse = int.Parse(verse);
            _endVerse = 0;
        }
    }

    public string GetDisplay()
    {
        string display = $"{_book} {_chapter}:{_verse}";

        if (_endVerse != 0)
        {
            display += $"-{_endVerse}";
        }

        return display;
    }
}
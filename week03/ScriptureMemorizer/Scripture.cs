public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordsArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        List<Word> wordsList = new List<Word>();
        foreach (string word in wordsArray)
        {
            //trim word string then make new word obj and add to list
            Word wordObj = new Word(word.Trim());
            wordsList.Add(wordObj);
        }

        _words = wordsList;
    }

    public void HideWord()
    {
        Random random = new Random();
        List<Word> availableWords = new List<Word>();

        foreach (Word word in _words) {
            if (word.IsHidden() == false){
                availableWords.Add(word);
            }
        }

        if (availableWords.Count > 0) {
            availableWords[random.Next(availableWords.Count)].Hide();
        }
    }

    public string GetDisplay()
    {
        string display = "";

        foreach (Word word in _words)
        {
            display += $"{word.GetDisplay()} ";
        }

        return display;
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}
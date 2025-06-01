public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        char[] delimiterChars = [' ', ',', '.'];
        string[] wordsArray = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

        List<Word> wordsList = new List<Word>();
        foreach (string word in wordsArray)
        {
            //trim word string then make new word obj and add to list
        }

        _words = wordsList;
    }
}
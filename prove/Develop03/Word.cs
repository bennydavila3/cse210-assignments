public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word) // sets attributes
    {
        _word = word;
        _hidden = false;
    }
    public void Hide() // turns _hidden to true to hide the word
    {
        _hidden = true;
    }
    public string GetDisplayValue() // either returns "_" or word depending on hidden
    {
        if(_hidden)
        {
            return "_____";
        }
        return _word;
    }
    public bool IsHidden() //checks if a word is hidden
    {
        return _hidden;
    }
}
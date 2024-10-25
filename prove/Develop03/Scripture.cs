using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;
    private string _scriptureText;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _scriptureText = scriptureText;

        foreach (var word in _scriptureText.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetFullScripture()
    {
        string refString = _reference.GetReference();
        string wordsString = "";

        foreach (var word in _words)
        {
            if (wordsString != "")
            {
                wordsString += " ";
            }
            wordsString += word.GetDisplayValue();
        }
        return $"{refString}: {wordsString}";
    }
    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();

        for (int i = 0; i < _words.Count; i++) //count visible words
        {
            if (!_words[i].IsHidden()) //check if the word is not hidden
            {
                visibleWords.Add(_words[i]); // Add visible word to the list
            }
        }

        if (visibleWords.Count > 0) //hide random visible word
        {
            int randomIndex = random.Next(visibleWords.Count); //get random index from visible words
            visibleWords[randomIndex].Hide(); //hide the randomly selected word
        }
    }
    public bool AllWordsHidden()
    {
        for(int i = 0; i < _words.Count; i++)
        {
            if(!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
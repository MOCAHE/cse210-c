using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Constructor
    public Scripture(Reference referencia, string text)
    {
        _reference = referencia;
        _words = new List<Word>();

        string[] palabrasArray = text.Split(' ');
        foreach (string palabra in palabrasArray)
        {
            _words.Add(new Word(palabra));
        }
    }

    public void HideRandomWords(int numToHide)
    {
        Random aleatorio = new Random();
        List<Word> wordsToHide = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                wordsToHide.Add(word);
            }
        }

        for (int i = 0; i < numToHide && wordsToHide.Count > 0; i++)
        {
            int index = aleatorio.Next(0, wordsToHide.Count);
            wordsToHide[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
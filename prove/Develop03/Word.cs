using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    //Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    //Use chatGPT para implemengtar string.Emty;
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string displayText = string.Empty;
            foreach (char c in _text)
            {
                if (char.IsWhiteSpace(c))
                {
                    displayText += c;
                }
                else
                {
                    displayText += '_';
                }
            }
            return displayText;
        }

        else
        {
            return _text;
        }
    }
}
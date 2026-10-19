using System;

namespace Develop03;

public class Word
{
   private string _word;
   private bool _isHidden;

   public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void hide()
    {
        _isHidden = true;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public void display()
    {
        Console.Write($"{_word} ");
    }

    public string GetWordString()
    {
        return _word;
    }
}

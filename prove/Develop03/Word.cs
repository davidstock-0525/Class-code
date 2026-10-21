using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

namespace Develop03;

public class Word
{
   private string _word;
   private bool _isHidden;

   private int _length;

   public Word(string word)
    {
        _word = word;
        _isHidden = false;
        _length = word.Length;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public void PrintWord()
    {
        Console.Write($"{_word} ");
    }

    public void PrintBlanks()
    {
        for (int i = 0; i < _length; i++)
        {
            Console.Write("_ ");
        }
    }
}

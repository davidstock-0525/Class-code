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

    public void hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public void printword()
    {
        Console.Write($"{_word} ");
    }

    public void printblanks()
    {
        for (int i = 0; i < _length; i++)
        {
            Console.Write("_ ");
        }
    }
}

using System;
using System.Reflection.Metadata.Ecma335;

namespace Develop03;

public class Scripture
{
    private List<Word> _words;
    private string _book;
    private int _chapter;
    private int _verse;

    private int _startVerse;

    private int _endVerse;

    public Scripture(string Bookname, int chapter, int verse, string text)
    {
        _book = Bookname;
        _chapter = chapter;
        _verse = verse;
        _words = ConvertToWords(text);
    }
    public Scripture(string Bookname, int chapter, int startverse, int endverse, string text)
    {
        _book = Bookname;
        _chapter = chapter;
        _startVerse = startverse;
        _endVerse = endverse;
        _words = ConvertToWords(text);
    }

    public void ShowScripture()
    {
        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden();
            if (hidden == false)
            {
                word.PrintWord();
            }
            else
            {
                word.PrintBlanks();
            }
        }
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }

        return tempWords;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void PickandHide()
    {
        for (int i = 0; i < 7; i++)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            Word selectedWord = _words[index];
            if (selectedWord.IsHidden() == false)
            {
                selectedWord.Hide();
            }
            else
            {
                i = i - 1;
            }
        }
    }

    public int EndProgram()
    {
        int killswitch = 1;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                killswitch = 0;
            }
        }
        return killswitch;
    }
}

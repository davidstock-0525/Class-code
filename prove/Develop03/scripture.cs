using System;
using System.Reflection.Metadata.Ecma335;

namespace Develop03;

public class Scripture
{
    private List<Word> _words;
    private string _book;
    private int _chapter;
    private int _verse;

    private int _startverse;

    private int _endverse;
    private string _text;

    public Scripture(string Bookname, int chapter, int verse, string text)
    {
        _words = convertToWords(text);
    }
    public Scripture(string BookName, int chapter, int startverse, int endverses, string text)
    {
        
    }

    public void showScripture()
    {
        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden();
            if (hidden == false)
            {
                word.printword();
            }
            else
            {
                word.printblanks();
            }
        }
    }

    private List<Word> convertToWords(string text)
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

    public string getBook()
    {
        return _book;
    }

    public int getChapter()
    {
        return _chapter;
    }

    public int getVerse()
    {
        return _verse;
    }

    public int getStartVerse()
    {
        return _startverse;
    }

    public int getEndVerse()
    {
        return _endverse;
    }
}

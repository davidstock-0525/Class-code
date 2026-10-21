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

    public Scripture(string Bookname, int chapter, int verse, string text)
    {
        _book = Bookname;
        _chapter = chapter;
        _verse = verse;
        _words = convertToWords(text);
    }
    public Scripture(string Bookname, int chapter, int startverse, int endverse, string text)
    {
        _book = Bookname;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
        _words = convertToWords(text);
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

    public void Pickandhide()
    {
        for (int i = 0; i < 7; i++)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            Word selectedWord = _words[index];
            if (selectedWord.IsHidden() == false)
            {
                selectedWord.hide();
            }
            else
            {
                i = i - 1;
            }
        }
    }
}

using System;

namespace Develop03;

public class Scripture
{
    List<Word> _words;
    // Add scripture

    public Scripture(string Bookname, int chapter, int verse, string text)
    {
        _words = convertToWords(text);
    }
    public Scripture(string BookName, int chapter, int startverse, int endverses, string text)
    {
        
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
    
}

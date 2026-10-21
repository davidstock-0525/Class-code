using System;
using System.Diagnostics.Contracts;

namespace Develop03;

public class Reference
{
    private string _fullReference;
    private Scripture _startingPoint;


    public string BuildRef(Scripture Scripture)
    {
        int runversion1 = Scripture.getVerse();
        if (runversion1 == 0)
        {
            string reference = ($"{Scripture.getBook()} {Scripture.getChapter().ToString()}:{Scripture.getStartVerse().ToString()}-{Scripture.getEndVerse().ToString()}");
            return reference;
        }
        else
        {
           string reference = ($"{Scripture.getBook()} {Scripture.getChapter().ToString()}:{Scripture.getVerse().ToString()}");
            return reference; 
        }
            
    }

    public Reference(Scripture scripture)
    {
        _startingPoint = scripture;
        _fullReference = BuildRef(scripture);
    }

    public void printRef()
    {
        Console.WriteLine(_fullReference);
    }
    

    
    

    
}

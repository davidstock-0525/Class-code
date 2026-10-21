using System;
using System.Diagnostics.Contracts;

namespace Develop03;

public class Reference
{
    private string _fullReference;
    private Scripture _startingPoint;


    public string BuildRef(Scripture Scripture)
    {
        int runversion1 = Scripture.GetVerse();
        if (runversion1 == 0)
        {
            string reference = ($"{Scripture.GetBook()} {Scripture.GetChapter().ToString()}:{Scripture.GetStartVerse().ToString()}-{Scripture.GetEndVerse().ToString()}");
            return reference;
        }
        else
        {
           string reference = ($"{Scripture.GetBook()} {Scripture.GetChapter().ToString()}:{Scripture.GetVerse().ToString()}");
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

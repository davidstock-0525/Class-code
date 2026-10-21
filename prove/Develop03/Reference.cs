using System;
using System.Diagnostics.Contracts;

namespace Develop03;

public class Reference
{
    private string _fullReference;
    private Scripture _startingPoint;


    public string BuildRef(Scripture Scripture)
    {
        string reference = ($"{Scripture.getBook()}{Scripture.getChapter().ToString()}:{Scripture.getVerse()}{Scripture.getStartVerse}-{Scripture.getEndVerse()}");
        return reference;
    }

    public Reference(Scripture scripture)
    {
        _startingPoint = scripture;
        _fullReference = BuildRef(scripture);
    }
    

    
    

    
}

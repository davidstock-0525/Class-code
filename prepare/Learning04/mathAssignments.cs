class Math:Assignment
{
    private string _textBookSection;
    private string __problems;

    public Math(string textBookSection, string problems, string studentName, string topic)
    : base ( studentName, topic)
    {
        _textBookSection = textBookSection;
        __problems = problems;
    }

    public string GetHomeworkList()
    {
        string homeworkList = ($"Section {_textBookSection} problems {__problems}");
        return homeworkList;
    }
    
    
}
using System.Diagnostics.Contracts;

class Writing:Assignment
{
    private string _title;

    public Writing(string title, string studentName, string topic)
    : base (studentName, topic)
    {
        title = _title;
    }

    public string getWritinginformation()
    {
        string information = ($"{_title}");
        return information;
    }
}
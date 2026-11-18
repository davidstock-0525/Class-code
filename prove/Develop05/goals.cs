class Goals
{
    private List<Basegoal> _goalList;

    public void AddGoal(Basegoal goal)
    {
        _goalList.Add(goal);
    }

    public List<Basegoal> Getlist()
    {
        return _goalList;
    }
    
}
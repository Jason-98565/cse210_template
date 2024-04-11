using System;

public class Checklist : Goal
{
    public int _completecount;
    public int _timescompleted;
    public int _bonuspoints;

    public Checklist(int pointvalue,string goalname,string description,int completecount,int bonuspoints,int timescompleted = 0,bool ending = false,bool complete = false) :base(pointvalue,goalname,description)
    {
        _pointvalue = pointvalue;
        _goalname = goalname;
        _description = description;
        _ending = ending;
        _complete = complete;
        _completecount = completecount;
        _bonuspoints = bonuspoints;
        _timescompleted = timescompleted;
    }
        public override string ToString()
    {
        string gi;
        if (_complete)
            {
                gi = "[X]";
            }
        else
            {
                gi = "[]";
            }
        string U = gi + $" {_goalname} ({_description}) -- {_timescompleted}/{_completecount}";
        return U;
    }
}
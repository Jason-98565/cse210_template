using System;

public class Entry
{
    public string _datetime;
    public string _currentPrompt;
    public string _response;
    
    override
    public string ToString()
    {
        string s = ($"Date:_{_datetime}_Prompt:_{_currentPrompt}_Response:_{_response}");
        return s;
    }
}
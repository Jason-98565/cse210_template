using System;

public class Breathing:Activity
{
    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus your breathing";
        Startmessage();
        getduration();
        Pause_Speen(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        do
        {
            breath();
            currentTime = DateTime.Now;
        }
        while (currentTime < endTime);
        Endmessage();
    }
    public void breath()
    {
        Console.WriteLine("Breath In");
        Pause_Countdown(4);
        Console.WriteLine("Breath Out");
        Pause_Countdown(6);
    }
}

